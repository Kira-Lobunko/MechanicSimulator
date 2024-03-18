using System;
using System.Windows.Forms;

namespace MechanicSimulator
{
    public partial class AddMechanicForm : Form
    {
        ConfigForm cfgForm;
        public AddMechanicForm(ConfigForm cfgForm)
        {
            InitializeComponent();
            this.cfgForm = cfgForm;
            nameTextBox.Validating += NameTextBox_Validating;
            maskedTextBox1.Validating += QueueLenLimitLabel_Validating;
        }

        private void QueueLenLimitLabel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int value;
            if (!int.TryParse(maskedTextBox1.Text, out value))
            {
                errorProvider1.SetError(maskedTextBox1, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }
            if (value <= 0)
            {
                errorProvider1.SetError(maskedTextBox1, "Поле не может быть равно 0");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                errorProvider1.SetError(nameTextBox, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }

            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var name = nameTextBox.Text;
                var qLimit = int.Parse(maskedTextBox1.Text);
                Mechanic m = new MechanicImpl(name, qLimit, cfgForm.GetCurrentDateTime());

                cfgForm.AddMechanic(m);
                Close();
            }
            catch 
            {
                MessageBox.Show("Поля заполнены неполностью или допущены ошибки в формате данных.", "Ошибка ввода", MessageBoxButtons.OK);
            }
         }
    }
}
