using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicSimulator
{
    public partial class ConfigForm : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private SimulationConfigs cfg = new SimulationConfigs();
        public ConfigForm()
        {
            InitializeComponent();
            InitializeValues();

            timer.Interval = 1000;
            timer.Tick += timer_Tick;

            mechanicsDataGridView.UserDeletingRow += MechanicsDataGridView_UserDeletingRow;
            mechanicsDataGridView.UserDeletedRow += MechanicsDataGridView_UserDeletedRow;
            LoadMechanics();
            LoadTasks();

            FormClosing += ConfigForm_FormClosing;
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cfg = GetConfigs();
            string json = JsonConvert.SerializeObject(cfg, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText(configPath, json);
        }

        private void LoadTasks()
        {
            taskDataBindingSource.DataSource = weightedTasks.GetAll().Select(task => new TaskData(task)).ToList();
        }

        private void LoadMechanics()
        {
            mechanicDataBindingSource.DataSource = mechanics.GetAll().Select(mech => new MechanicData(mech)).ToList();
        }
        private void MechanicsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            mechanics.Clear();
            foreach (MechanicData md in mechanicDataBindingSource)
            {
                mechanics.Add(new MechanicImpl(md.FullName, md.QLimit, GetCurrentDateTime()));
            }
        }

        private void MechanicsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (timer.Enabled)
            {
                MessageBox.Show("Невозможно удалять сотрудников при запущенной симуляции", "Конфликт данных", MessageBoxButtons.OK);
                e.Cancel = true;
                return;
            }


            var res = MessageBox.Show("Удалить данные о механиках?", "Удаление данных", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private SimulationConfigs GetConfigs()         
        {            
            try
            {
                cfg.SimulationBegin = beginDateTimePicker.Value;
                cfg.SimulationDuration = TimeSpan.ParseExact(durationMaskedTextBox.Text, @"dd\:hh\:mm", null);
                cfg.SimulationStep = TimeSpan.ParseExact(stepMaskedTextBox.Text, @"dd\:hh\:mm", null);
                cfg.TaskFlowCapacity = int.Parse(taskFlowCapacityMaskedTextBox.Text);
                cfg.UpdateFrequency = double.Parse(updateFreqMaskedTextBox.Text);
                timer.Interval = (int)(cfg.UpdateFrequency * 1000);
            }
            catch 
            {
                var res = MessageBox.Show("Не удалось разобрать параметры симуляции. Установлен шаг в 5 минут и продолжительность в сутки, мощность потока заявок - 1000. Частота обновления - 1 секунда. Принять параметры по умолчанию?", "Ошибка форматирования", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    cfg.SimulationStep = TimeSpan.FromMinutes(5);
                    cfg.SimulationDuration = TimeSpan.FromDays(1);
                    cfg.TaskFlowCapacity = 1000;
                    cfg.UpdateFrequency = 1000;
                    durationMaskedTextBox.Text = cfg.SimulationDuration.ToString(@"dd\:hh\:mm");
                    stepMaskedTextBox.Text = cfg.SimulationStep.ToString(@"dd\:hh\:mm");
                    taskFlowCapacityMaskedTextBox.Text = cfg.TaskFlowCapacity.ToString();
                    updateFreqMaskedTextBox.Text = "01,00";
                    timer.Interval = (int)(cfg.UpdateFrequency * 1000);
                }
                else 
                {
                    throw new ArgumentException();
                }
            }

            return cfg;
        }

        private readonly string configPath = "Configs.json";
        private void InitializeValues()
        {
            try
            {
                if (File.Exists(configPath))
                {
                    string json = File.ReadAllText(configPath);
                    cfg = JsonConvert.DeserializeObject<SimulationConfigs>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

                    beginDateTimePicker.Text = cfg.SimulationBegin.ToString();
                    durationMaskedTextBox.Text = cfg.SimulationDuration.ToString(@"dd\:hh\:mm");
                    stepMaskedTextBox.Text = cfg.SimulationStep.ToString(@"dd\:hh\:mm");
                    taskFlowCapacityMaskedTextBox.Text = cfg.TaskFlowCapacity.ToString();
                    updateFreqMaskedTextBox.Text = cfg.UpdateFrequency.ToString();
       
                    timer.Interval = (int)(cfg.UpdateFrequency * 1000);
                }
                else 
                {
                    DefaultInitializeValues();
                }
            }
            catch
            {
                DefaultInitializeValues();
            }
        }

        private void DefaultInitializeValues()
        {
            cfg.SimulationStep = TimeSpan.FromMinutes(5);
            cfg.SimulationDuration = TimeSpan.FromDays(1);
            cfg.TaskFlowCapacity = 1000;
            cfg.UpdateFrequency = 1000;
            durationMaskedTextBox.Text = cfg.SimulationDuration.ToString(@"dd\:hh\:mm");
            stepMaskedTextBox.Text = cfg.SimulationStep.ToString(@"dd\:hh\:mm");
            taskFlowCapacityMaskedTextBox.Text = cfg.TaskFlowCapacity.ToString();
            updateFreqMaskedTextBox.Text = "01,00";
            timer.Interval = (int)(cfg.UpdateFrequency * 1000);
        }


        private async void timer_Tick(object sender, EventArgs e)
        {
            try
            {
               service.ExecuteStep();
                currentDateTimeLabel.Text = service.GetCurrentDateTime().ToString();
                mechanicStatBindingSource.DataSource = service.GetMechanicStats();
            }
            catch
            {
                currentDateTimeLabel.Text = service.GetCurrentDateTime().ToString();
                mechanicStatBindingSource.DataSource = service.GetMechanicStats();
                timer.Stop();
                MessageBox.Show("Cимуляция подошла к концу.", "Конец симуляции", MessageBoxButtons.OK);
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (service == null) 
                {
                    service = new MechanicServiceImpl(GetConfigs(), weightedTasks.GetAll(), mechanics.GetAll());
                }
            }
            catch
            {
                return;
            }

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private MechanicService service = null;

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            try
            {
                var newMechanics = new List<Mechanic>();
                foreach (var mech in mechanics.GetAll())
                {
                    newMechanics.Add(new MechanicImpl(mech.GetName(), mech.GetQueueLenLimit(), GetCurrentDateTime()));
                }

                mechanics.Clear();
                foreach (var mech in newMechanics)
                {
                    mechanics.Add(mech);
                }

                service = new MechanicServiceImpl(GetConfigs(), weightedTasks.GetAll(), mechanics.GetAll());

                mechanicStatBindingSource.DataSource = new List<MechanicStat>();
                timer.Start();
            }
            catch
            { 
            
            }
        }

        private void addMechanicButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                MessageBox.Show("Невозможно добавлять новых работников при запущенной симуляции", "Конфликт данных", MessageBoxButtons.OK);
                return;
            }

            try
            {
                var addMechanicForm = new AddMechanicForm(this);
                addMechanicForm.ShowDialog();

            }
            catch
            { 
            }
        }

        internal void AddMechanic(Mechanic m)
        {
            mechanics.Add(m);
            mechanicDataBindingSource.DataSource = mechanics.GetAll().Select(mech => new MechanicData(mech)).ToList();
        }

        private MechanicRepository mechanics = new MechanicRepositoryImpl();
        private FixTaskRepository weightedTasks = new FixTaskRepositoryImpl();

        private void addFixTaskButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                MessageBox.Show("Невозможно добавлять новые базовые задачи при запущенной симуляции", "Конфликт данных", MessageBoxButtons.OK);
                return;
            }
            try
            {
                var addBaseTaskForm = new AddBaseTask(this);
                addBaseTaskForm.ShowDialog();
            }
            catch
            {
            }
        }

        internal void AddBaseTask(FixTaskImpl baseTask)
        {
            weightedTasks.Add(baseTask);
            taskDataBindingSource.DataSource = weightedTasks.GetAll().Select(t => new TaskData(t)).ToList();
        }

        internal DateTime GetCurrentDateTime()
        {
            try
            {
                return DateTime.Parse(beginDateTimePicker.Text);
            }
            catch 
            {
                MessageBox.Show("Данные о дате и времени начала симуляции не установлены, установите и попробуйте снова.", "Ошибка зависимости по данным", MessageBoxButtons.OK);
                throw new ArgumentException();
            }
        }
    }
}
