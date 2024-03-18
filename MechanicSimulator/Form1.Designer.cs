namespace MechanicSimulator
{
    partial class ConfigForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RunButton = new System.Windows.Forms.Button();
            this.FormErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mechanicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRequestsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handledRequestsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedRequestsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitRequestsAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mechanicsDataGridView = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.currentDateTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.durationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.addMechanicButton = new System.Windows.Forms.Button();
            this.addFixTaskButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.taskFlowCapacityMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.updateFreqMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormErrorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicStatBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicDataBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(589, 12);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(146, 33);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "Запуск";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // FormErrorProvider
            // 
            this.FormErrorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Пауза";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 201);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 241);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1322, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Статистика механиков";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mechanicNameDataGridViewTextBoxColumn,
            this.totalRequestsAmountDataGridViewTextBoxColumn,
            this.handledRequestsAmountDataGridViewTextBoxColumn,
            this.delayedRequestsAmountDataGridViewTextBoxColumn,
            this.limitRequestsAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mechanicStatBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1316, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // mechanicNameDataGridViewTextBoxColumn
            // 
            this.mechanicNameDataGridViewTextBoxColumn.DataPropertyName = "MechanicName";
            this.mechanicNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.mechanicNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mechanicNameDataGridViewTextBoxColumn.Name = "mechanicNameDataGridViewTextBoxColumn";
            this.mechanicNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalRequestsAmountDataGridViewTextBoxColumn
            // 
            this.totalRequestsAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalRequestsAmount";
            this.totalRequestsAmountDataGridViewTextBoxColumn.HeaderText = "Общее число задач";
            this.totalRequestsAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalRequestsAmountDataGridViewTextBoxColumn.Name = "totalRequestsAmountDataGridViewTextBoxColumn";
            this.totalRequestsAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // handledRequestsAmountDataGridViewTextBoxColumn
            // 
            this.handledRequestsAmountDataGridViewTextBoxColumn.DataPropertyName = "HandledRequestsAmount";
            this.handledRequestsAmountDataGridViewTextBoxColumn.HeaderText = "Задач выполнено";
            this.handledRequestsAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.handledRequestsAmountDataGridViewTextBoxColumn.Name = "handledRequestsAmountDataGridViewTextBoxColumn";
            this.handledRequestsAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // delayedRequestsAmountDataGridViewTextBoxColumn
            // 
            this.delayedRequestsAmountDataGridViewTextBoxColumn.DataPropertyName = "DelayedRequestsAmount";
            this.delayedRequestsAmountDataGridViewTextBoxColumn.HeaderText = "Просроченных задач";
            this.delayedRequestsAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delayedRequestsAmountDataGridViewTextBoxColumn.Name = "delayedRequestsAmountDataGridViewTextBoxColumn";
            this.delayedRequestsAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // limitRequestsAmountDataGridViewTextBoxColumn
            // 
            this.limitRequestsAmountDataGridViewTextBoxColumn.DataPropertyName = "LimitRequestsAmount";
            this.limitRequestsAmountDataGridViewTextBoxColumn.HeaderText = "Предел задач на исполнение";
            this.limitRequestsAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.limitRequestsAmountDataGridViewTextBoxColumn.Name = "limitRequestsAmountDataGridViewTextBoxColumn";
            this.limitRequestsAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // mechanicStatBindingSource
            // 
            this.mechanicStatBindingSource.DataSource = typeof(MechanicSimulator.MechanicStat);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mechanicsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1322, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Механики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mechanicsDataGridView
            // 
            this.mechanicsDataGridView.AutoGenerateColumns = false;
            this.mechanicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanicsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.qLimitDataGridViewTextBoxColumn});
            this.mechanicsDataGridView.DataSource = this.mechanicDataBindingSource;
            this.mechanicsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mechanicsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.mechanicsDataGridView.Name = "mechanicsDataGridView";
            this.mechanicsDataGridView.ReadOnly = true;
            this.mechanicsDataGridView.RowHeadersWidth = 62;
            this.mechanicsDataGridView.RowTemplate.Height = 28;
            this.mechanicsDataGridView.Size = new System.Drawing.Size(1316, 202);
            this.mechanicsDataGridView.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // qLimitDataGridViewTextBoxColumn
            // 
            this.qLimitDataGridViewTextBoxColumn.DataPropertyName = "QLimit";
            this.qLimitDataGridViewTextBoxColumn.HeaderText = "Предел задач в работе";
            this.qLimitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qLimitDataGridViewTextBoxColumn.Name = "qLimitDataGridViewTextBoxColumn";
            this.qLimitDataGridViewTextBoxColumn.ReadOnly = true;
            this.qLimitDataGridViewTextBoxColumn.Width = 150;
            // 
            // mechanicDataBindingSource
            // 
            this.mechanicDataBindingSource.DataSource = typeof(MechanicSimulator.MechanicData);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tasksDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1322, 208);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Базовые задачи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tasksDataGridView
            // 
            this.tasksDataGridView.AutoGenerateColumns = false;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.tasksDataGridView.DataSource = this.taskDataBindingSource;
            this.tasksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tasksDataGridView.Name = "tasksDataGridView";
            this.tasksDataGridView.RowHeadersWidth = 62;
            this.tasksDataGridView.RowTemplate.Height = 28;
            this.tasksDataGridView.Size = new System.Drawing.Size(1322, 208);
            this.tasksDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Ёмкость";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Срок выполнения";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 150;
            // 
            // taskDataBindingSource
            // 
            this.taskDataBindingSource.DataSource = typeof(MechanicSimulator.TaskData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Текущие дата и  время в симуляции:";
            // 
            // currentDateTimeLabel
            // 
            this.currentDateTimeLabel.AutoSize = true;
            this.currentDateTimeLabel.Location = new System.Drawing.Point(1064, 12);
            this.currentDateTimeLabel.Name = "currentDateTimeLabel";
            this.currentDateTimeLabel.Size = new System.Drawing.Size(71, 20);
            this.currentDateTimeLabel.TabIndex = 16;
            this.currentDateTimeLabel.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Продолжительность симуляции (дд:чч:мм):";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDateTimePicker.Location = new System.Drawing.Point(359, 5);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.beginDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Продолжительность симуляции (дд:чч:мм):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шаг симуляции (дд:чч:мм):";
            // 
            // durationMaskedTextBox
            // 
            this.durationMaskedTextBox.Location = new System.Drawing.Point(358, 47);
            this.durationMaskedTextBox.Mask = "00:00:00";
            this.durationMaskedTextBox.Name = "durationMaskedTextBox";
            this.durationMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.durationMaskedTextBox.TabIndex = 1;
            // 
            // stepMaskedTextBox
            // 
            this.stepMaskedTextBox.Location = new System.Drawing.Point(358, 93);
            this.stepMaskedTextBox.Mask = "00:00:00";
            this.stepMaskedTextBox.Name = "stepMaskedTextBox";
            this.stepMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.stepMaskedTextBox.TabIndex = 2;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(589, 96);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(146, 35);
            this.restartButton.TabIndex = 20;
            this.restartButton.Text = "Перезапуск";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addMechanicButton
            // 
            this.addMechanicButton.Location = new System.Drawing.Point(746, 51);
            this.addMechanicButton.Name = "addMechanicButton";
            this.addMechanicButton.Size = new System.Drawing.Size(191, 35);
            this.addMechanicButton.TabIndex = 5;
            this.addMechanicButton.Text = "Добавить механика";
            this.addMechanicButton.UseVisualStyleBackColor = true;
            this.addMechanicButton.Click += new System.EventHandler(this.addMechanicButton_Click);
            // 
            // addFixTaskButton
            // 
            this.addFixTaskButton.Location = new System.Drawing.Point(746, 92);
            this.addFixTaskButton.Name = "addFixTaskButton";
            this.addFixTaskButton.Size = new System.Drawing.Size(191, 39);
            this.addFixTaskButton.TabIndex = 6;
            this.addFixTaskButton.Text = "Добавить задачу";
            this.addFixTaskButton.UseVisualStyleBackColor = true;
            this.addFixTaskButton.Click += new System.EventHandler(this.addFixTaskButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Мощность потока задач:";
            // 
            // taskFlowCapacityMaskedTextBox
            // 
            this.taskFlowCapacityMaskedTextBox.Location = new System.Drawing.Point(358, 126);
            this.taskFlowCapacityMaskedTextBox.Mask = "0000";
            this.taskFlowCapacityMaskedTextBox.Name = "taskFlowCapacityMaskedTextBox";
            this.taskFlowCapacityMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.taskFlowCapacityMaskedTextBox.TabIndex = 3;
            // 
            // mechanicBindingSource
            // 
            this.mechanicBindingSource.DataSource = typeof(MechanicSimulator.Mechanic);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Частота обновления (с):";
            // 
            // updateFreqMaskedTextBox
            // 
            this.updateFreqMaskedTextBox.Location = new System.Drawing.Point(358, 158);
            this.updateFreqMaskedTextBox.Mask = "00.00";
            this.updateFreqMaskedTextBox.Name = "updateFreqMaskedTextBox";
            this.updateFreqMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateFreqMaskedTextBox.TabIndex = 4;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 454);
            this.Controls.Add(this.updateFreqMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taskFlowCapacityMaskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addFixTaskButton);
            this.Controls.Add(this.addMechanicButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.stepMaskedTextBox);
            this.Controls.Add(this.beginDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentDateTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.durationMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.label4);
            this.Name = "ConfigForm";
            this.Text = "Параметры программы";
            ((System.ComponentModel.ISupportInitialize)(this.FormErrorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicStatBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mechanicsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicDataBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ErrorProvider FormErrorProvider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label currentDateTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox stepMaskedTextBox;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.MaskedTextBox durationMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource mechanicStatBindingSource;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button addMechanicButton;
        private System.Windows.Forms.DataGridView mechanicsDataGridView;
        private System.Windows.Forms.BindingSource mechanicBindingSource;
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mechanicDataBindingSource;
        private System.Windows.Forms.Button addFixTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource taskDataBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox taskFlowCapacityMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRequestsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handledRequestsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedRequestsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitRequestsAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox updateFreqMaskedTextBox;
    }
}

