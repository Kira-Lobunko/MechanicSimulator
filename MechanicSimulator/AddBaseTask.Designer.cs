namespace MechanicSimulator
{
    partial class AddBaseTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskVolumeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmAddTaskButton = new System.Windows.Forms.Button();
            this.taskWeightMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.taskDurationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ёмкость задачи";
            // 
            // taskVolumeMaskedTextBox
            // 
            this.taskVolumeMaskedTextBox.Location = new System.Drawing.Point(219, 81);
            this.taskVolumeMaskedTextBox.Mask = "000";
            this.taskVolumeMaskedTextBox.Name = "taskVolumeMaskedTextBox";
            this.taskVolumeMaskedTextBox.Size = new System.Drawing.Size(160, 26);
            this.taskVolumeMaskedTextBox.TabIndex = 1;
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(219, 49);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(160, 26);
            this.taskNameTextBox.TabIndex = 0;
            // 
            // confirmAddTaskButton
            // 
            this.confirmAddTaskButton.Location = new System.Drawing.Point(12, 183);
            this.confirmAddTaskButton.Name = "confirmAddTaskButton";
            this.confirmAddTaskButton.Size = new System.Drawing.Size(366, 56);
            this.confirmAddTaskButton.TabIndex = 4;
            this.confirmAddTaskButton.Text = "Добавить задачу";
            this.confirmAddTaskButton.UseVisualStyleBackColor = true;
            this.confirmAddTaskButton.Click += new System.EventHandler(this.confirmAddTaskButton_Click);
            // 
            // taskWeightMaskedTextBox
            // 
            this.taskWeightMaskedTextBox.Location = new System.Drawing.Point(219, 113);
            this.taskWeightMaskedTextBox.Mask = "000";
            this.taskWeightMaskedTextBox.Name = "taskWeightMaskedTextBox";
            this.taskWeightMaskedTextBox.Size = new System.Drawing.Size(160, 26);
            this.taskWeightMaskedTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вес задачи";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // taskDurationMaskedTextBox
            // 
            this.taskDurationMaskedTextBox.Location = new System.Drawing.Point(219, 145);
            this.taskDurationMaskedTextBox.Mask = "00:00";
            this.taskDurationMaskedTextBox.Name = "taskDurationMaskedTextBox";
            this.taskDurationMaskedTextBox.Size = new System.Drawing.Size(160, 26);
            this.taskDurationMaskedTextBox.TabIndex = 3;
            this.taskDurationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срок задачи";
            // 
            // AddBaseTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskDurationMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskWeightMaskedTextBox);
            this.Controls.Add(this.confirmAddTaskButton);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.taskVolumeMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBaseTask";
            this.Text = "Добавление базовой задачи";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox taskVolumeMaskedTextBox;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Button confirmAddTaskButton;
        private System.Windows.Forms.MaskedTextBox taskWeightMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox taskDurationMaskedTextBox;
    }
}