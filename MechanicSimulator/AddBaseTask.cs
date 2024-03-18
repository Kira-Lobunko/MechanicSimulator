using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicSimulator
{
    public partial class AddBaseTask : Form
    {
        private ConfigForm configForm;
        public AddBaseTask(ConfigForm cfgForm)
        {
            InitializeComponent();

            configForm = cfgForm;

            taskNameTextBox.Validating += TaskNameTextBox_Validating;
            taskVolumeMaskedTextBox.Validating += TaskVolumeMaskedTextBox_Validating;
            taskWeightMaskedTextBox.Validating += TaskWeightMaskedTextBox_Validating;
            taskDurationMaskedTextBox.Validating += TaskDurationMaskedTextBox_Validating;
        }

        private void TaskDurationMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            TimeSpan taskDuration;
            if (!TimeSpan.TryParse(taskDurationMaskedTextBox.Text, out taskDuration))
            {
                errorProvider1.SetError(taskDurationMaskedTextBox, "Невозможно разобрать данные в поле");
                e.Cancel = true;
                return;
            }
            if (taskDuration == TimeSpan.Zero)
            {
                errorProvider1.SetError(taskDurationMaskedTextBox, "Невозможно установить продолжительность = 00:00");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void TaskWeightMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            int taskWeight;
            if (!int.TryParse(taskWeightMaskedTextBox.Text, out taskWeight))
            {
                errorProvider1.SetError(taskWeightMaskedTextBox, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }
            if (taskWeight== 0)
            {
                errorProvider1.SetError(taskWeightMaskedTextBox, "Невозможно установить это поле со значением 0");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void TaskVolumeMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            int taskVolume;
            if (!int.TryParse(taskVolumeMaskedTextBox.Text, out taskVolume))
            {
                errorProvider1.SetError(taskVolumeMaskedTextBox, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }
            if (taskVolume == 0)
            {
                errorProvider1.SetError(taskVolumeMaskedTextBox, "Невозможно установить это поле со значением 0");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void TaskNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(taskNameTextBox.Text))
            {
                errorProvider1.SetError(taskNameTextBox, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void confirmAddTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = taskNameTextBox.Text;
                var volume = int.Parse(taskVolumeMaskedTextBox.Text);
                var weight = int.Parse(taskWeightMaskedTextBox.Text);
                var duration = TimeSpan.Parse(taskDurationMaskedTextBox.Text);
                var baseTask = new FixTaskImpl(name, volume, weight, duration);

                configForm.AddBaseTask(baseTask);
                Close();
            }
            catch
            {
                MessageBox.Show("Поля заполнены неполностью или допущены ошибки в формате данных.", "Ошибка ввода", MessageBoxButtons.OK);
            }

        }
    }
}
