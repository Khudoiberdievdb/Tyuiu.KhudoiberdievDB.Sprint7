namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    partial class FormChart
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelChart_HDB = new Panel();
            buttonBackToMM_HDB = new Button();
            chart_HDB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGraphChart_HDB = new Button();
            buttonSaveFileChart_HDB = new Button();
            buttonAddFileChart_HDB = new Button();
            panelGridChart_HDB = new Panel();
            dataGridViewChart_HDB = new DataGridView();
            ColumnCount__HDB = new DataGridViewTextBoxColumn();
            ColumnCodePro_HDB = new DataGridViewTextBoxColumn();
            ColumnNameOfPro_HDB = new DataGridViewTextBoxColumn();
            ColumnCount_HDB = new DataGridViewTextBoxColumn();
            ColumnPrice_HDB = new DataGridViewTextBoxColumn();
            ColumnInfo_HDB = new DataGridViewTextBoxColumn();
            openFileDialogTaskChart_HDB = new OpenFileDialog();
            saveFileDialogTaskChart_HDB = new SaveFileDialog();
            toolTipCHart_HDB = new ToolTip(components);
            panelChart_HDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_HDB).BeginInit();
            panelGridChart_HDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_HDB).BeginInit();
            SuspendLayout();
            // 
            // panelChart_HDB
            // 
            panelChart_HDB.BackColor = SystemColors.GradientInactiveCaption;
            panelChart_HDB.Controls.Add(buttonBackToMM_HDB);
            panelChart_HDB.Controls.Add(chart_HDB);
            panelChart_HDB.Controls.Add(buttonGraphChart_HDB);
            panelChart_HDB.Controls.Add(buttonSaveFileChart_HDB);
            panelChart_HDB.Controls.Add(buttonAddFileChart_HDB);
            panelChart_HDB.Dock = DockStyle.Right;
            panelChart_HDB.Location = new Point(684, 0);
            panelChart_HDB.Name = "panelChart_HDB";
            panelChart_HDB.Size = new Size(684, 496);
            panelChart_HDB.TabIndex = 1;
            // 
            // buttonBackToMM_HDB
            // 
            buttonBackToMM_HDB.Cursor = Cursors.Hand;
            buttonBackToMM_HDB.Image = Properties.Resources.back_icon;
            buttonBackToMM_HDB.Location = new Point(15, 12);
            buttonBackToMM_HDB.Name = "buttonBackToMM_HDB";
            buttonBackToMM_HDB.Size = new Size(186, 80);
            buttonBackToMM_HDB.TabIndex = 9;
            toolTipCHart_HDB.SetToolTip(buttonBackToMM_HDB, "Вернуться в главное меню");
            buttonBackToMM_HDB.UseVisualStyleBackColor = true;
            buttonBackToMM_HDB.Click += buttonBackToMM_HDB_Click;
            // 
            // chart_HDB
            // 
            chartArea1.Name = "ChartArea1";
            chart_HDB.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart_HDB.Legends.Add(legend1);
            chart_HDB.Location = new Point(15, 118);
            chart_HDB.Name = "chart_HDB";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_HDB.Series.Add(series1);
            chart_HDB.Size = new Size(657, 375);
            chart_HDB.TabIndex = 8;
            // 
            // buttonGraphChart_HDB
            // 
            buttonGraphChart_HDB.Cursor = Cursors.Hand;
            buttonGraphChart_HDB.Image = Properties.Resources.статистика;
            buttonGraphChart_HDB.Location = new Point(379, 3);
            buttonGraphChart_HDB.Name = "buttonGraphChart_HDB";
            buttonGraphChart_HDB.Size = new Size(293, 109);
            buttonGraphChart_HDB.TabIndex = 7;
            toolTipCHart_HDB.SetToolTip(buttonGraphChart_HDB, "Подтвердить данные");
            buttonGraphChart_HDB.UseVisualStyleBackColor = true;
            buttonGraphChart_HDB.Click += buttonGraphChart_HDB_Click;
            // 
            // buttonSaveFileChart_HDB
            // 
            buttonSaveFileChart_HDB.Cursor = Cursors.Hand;
            buttonSaveFileChart_HDB.Image = Properties.Resources.page_save;
            buttonSaveFileChart_HDB.Location = new Point(293, 12);
            buttonSaveFileChart_HDB.Name = "buttonSaveFileChart_HDB";
            buttonSaveFileChart_HDB.Size = new Size(80, 80);
            buttonSaveFileChart_HDB.TabIndex = 2;
            toolTipCHart_HDB.SetToolTip(buttonSaveFileChart_HDB, "Сохранить файл");
            buttonSaveFileChart_HDB.UseVisualStyleBackColor = true;
            buttonSaveFileChart_HDB.Click += buttonSaveFileChart_HDB_Click;
            // 
            // buttonAddFileChart_HDB
            // 
            buttonAddFileChart_HDB.Cursor = Cursors.Hand;
            buttonAddFileChart_HDB.Image = Properties.Resources.page_add;
            buttonAddFileChart_HDB.Location = new Point(207, 12);
            buttonAddFileChart_HDB.Name = "buttonAddFileChart_HDB";
            buttonAddFileChart_HDB.Size = new Size(80, 80);
            buttonAddFileChart_HDB.TabIndex = 2;
            toolTipCHart_HDB.SetToolTip(buttonAddFileChart_HDB, "ЗАгрузить файл");
            buttonAddFileChart_HDB.UseVisualStyleBackColor = true;
            buttonAddFileChart_HDB.Click += buttonAddFileChart_HDB_Click;
            // 
            // panelGridChart_HDB
            // 
            panelGridChart_HDB.BackColor = SystemColors.ActiveCaption;
            panelGridChart_HDB.Controls.Add(dataGridViewChart_HDB);
            panelGridChart_HDB.Dock = DockStyle.Left;
            panelGridChart_HDB.Location = new Point(0, 0);
            panelGridChart_HDB.Name = "panelGridChart_HDB";
            panelGridChart_HDB.Size = new Size(684, 496);
            panelGridChart_HDB.TabIndex = 2;
            // 
            // dataGridViewChart_HDB
            // 
            dataGridViewChart_HDB.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewChart_HDB.BorderStyle = BorderStyle.None;
            dataGridViewChart_HDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChart_HDB.Columns.AddRange(new DataGridViewColumn[] { ColumnCount__HDB, ColumnCodePro_HDB, ColumnNameOfPro_HDB, ColumnCount_HDB, ColumnPrice_HDB, ColumnInfo_HDB });
            dataGridViewChart_HDB.Location = new Point(3, 12);
            dataGridViewChart_HDB.Name = "dataGridViewChart_HDB";
            dataGridViewChart_HDB.RowHeadersVisible = false;
            dataGridViewChart_HDB.RowHeadersWidth = 51;
            dataGridViewChart_HDB.Size = new Size(675, 472);
            dataGridViewChart_HDB.TabIndex = 0;
            // 
            // ColumnCount__HDB
            // 
            ColumnCount__HDB.HeaderText = "№";
            ColumnCount__HDB.MinimumWidth = 6;
            ColumnCount__HDB.Name = "ColumnCount__HDB";
            ColumnCount__HDB.Width = 40;
            // 
            // ColumnCodePro_HDB
            // 
            ColumnCodePro_HDB.HeaderText = "Код товара";
            ColumnCodePro_HDB.MinimumWidth = 6;
            ColumnCodePro_HDB.Name = "ColumnCodePro_HDB";
            ColumnCodePro_HDB.Width = 70;
            // 
            // ColumnNameOfPro_HDB
            // 
            ColumnNameOfPro_HDB.HeaderText = "Название товара";
            ColumnNameOfPro_HDB.MinimumWidth = 6;
            ColumnNameOfPro_HDB.Name = "ColumnNameOfPro_HDB";
            ColumnNameOfPro_HDB.Width = 125;
            // 
            // ColumnCount_HDB
            // 
            ColumnCount_HDB.HeaderText = "Количество";
            ColumnCount_HDB.MinimumWidth = 6;
            ColumnCount_HDB.Name = "ColumnCount_HDB";
            ColumnCount_HDB.Width = 125;
            // 
            // ColumnPrice_HDB
            // 
            ColumnPrice_HDB.HeaderText = "Стоимость кг\\ед.";
            ColumnPrice_HDB.MinimumWidth = 6;
            ColumnPrice_HDB.Name = "ColumnPrice_HDB";
            ColumnPrice_HDB.Width = 125;
            // 
            // ColumnInfo_HDB
            // 
            ColumnInfo_HDB.HeaderText = "Примечание";
            ColumnInfo_HDB.MinimumWidth = 6;
            ColumnInfo_HDB.Name = "ColumnInfo_HDB";
            ColumnInfo_HDB.Width = 125;
            // 
            // openFileDialogTaskChart_HDB
            // 
            openFileDialogTaskChart_HDB.FileName = "openFileDialog1";
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 496);
            Controls.Add(panelChart_HDB);
            Controls.Add(panelGridChart_HDB);
            MaximizeBox = false;
            MaximumSize = new Size(1386, 543);
            MinimizeBox = false;
            MinimumSize = new Size(1386, 543);
            Name = "FormChart";
            Text = "FormChart";
            panelChart_HDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_HDB).EndInit();
            panelGridChart_HDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewChart_HDB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChart_HDB;
        private Button buttonGraphChart_HDB;
        private Button buttonSaveFileChart_HDB;
        private Button buttonAddFileChart_HDB;
        private Panel panelGridChart_HDB;
        private DataGridView dataGridViewChart_HDB;
        private DataGridViewTextBoxColumn ColumnCount__HDB;
        private DataGridViewTextBoxColumn ColumnCodePro_HDB;
        private DataGridViewTextBoxColumn ColumnNameOfPro_HDB;
        private DataGridViewTextBoxColumn ColumnCount_HDB;
        private DataGridViewTextBoxColumn ColumnPrice_HDB;
        private DataGridViewTextBoxColumn ColumnInfo_HDB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_HDB;
        private Button buttonBackToMM_HDB;
        private OpenFileDialog openFileDialogTaskChart_HDB;
        private SaveFileDialog saveFileDialogTaskChart_HDB;
        private ToolTip toolTipCHart_HDB;
    }
}