namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelMenu_HDB = new Panel();
            buttonGraph_HDB = new Button();
            textBoxMaxCost_HDB = new TextBox();
            textBoxMinCost_HDB = new TextBox();
            textBoxAvCost_HDB = new TextBox();
            textBoxSum_HDB = new TextBox();
            buttonMaxCost_HDB = new Button();
            buttonMinCost_HDB = new Button();
            buttonAvCost_HDB = new Button();
            buttonSum_HDB = new Button();
            groupBoxStringsAdd_HDB = new GroupBox();
            labelCountPro_HDB = new Label();
            labelInfoPro_HDB = new Label();
            labelPrice_HDB = new Label();
            labelCodeProduct_HDB = new Label();
            labelNameOfPro_HDB = new Label();
            textBoxPrice_HDB = new TextBox();
            textBoxCountPro_HDB = new TextBox();
            textBoxInfoPro_HDB = new TextBox();
            textBoxNameOfPro_HDB = new TextBox();
            textBoxCodeProduct_HDB = new TextBox();
            buttonAddProduct_HDB = new Button();
            buttonSaveFile_HDB = new Button();
            buttonAddFile_HDB = new Button();
            buttonHelp_HDB = new Button();
            buttonAbout_HDB = new Button();
            panelGrid_HDB = new Panel();
            dataGridView_HDB = new DataGridView();
            ColumnCount__HDB = new DataGridViewTextBoxColumn();
            ColumnCodePro_HDB = new DataGridViewTextBoxColumn();
            ColumnNameOfPro_HDB = new DataGridViewTextBoxColumn();
            ColumnCount_HDB = new DataGridViewTextBoxColumn();
            ColumnPrice_HDB = new DataGridViewTextBoxColumn();
            ColumnInfo_HDB = new DataGridViewTextBoxColumn();
            openFileDialogTask_HDB = new OpenFileDialog();
            saveFileDialogTask_HDB = new SaveFileDialog();
            panelMenu_HDB.SuspendLayout();
            groupBoxStringsAdd_HDB.SuspendLayout();
            panelGrid_HDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_HDB).BeginInit();
            SuspendLayout();
            // 
            // panelMenu_HDB
            // 
            panelMenu_HDB.BackColor = SystemColors.GradientInactiveCaption;
            panelMenu_HDB.Controls.Add(buttonGraph_HDB);
            panelMenu_HDB.Controls.Add(textBoxMaxCost_HDB);
            panelMenu_HDB.Controls.Add(textBoxMinCost_HDB);
            panelMenu_HDB.Controls.Add(textBoxAvCost_HDB);
            panelMenu_HDB.Controls.Add(textBoxSum_HDB);
            panelMenu_HDB.Controls.Add(buttonMaxCost_HDB);
            panelMenu_HDB.Controls.Add(buttonMinCost_HDB);
            panelMenu_HDB.Controls.Add(buttonAvCost_HDB);
            panelMenu_HDB.Controls.Add(buttonSum_HDB);
            panelMenu_HDB.Controls.Add(groupBoxStringsAdd_HDB);
            panelMenu_HDB.Controls.Add(buttonAddProduct_HDB);
            panelMenu_HDB.Controls.Add(buttonSaveFile_HDB);
            panelMenu_HDB.Controls.Add(buttonAddFile_HDB);
            panelMenu_HDB.Controls.Add(buttonHelp_HDB);
            panelMenu_HDB.Controls.Add(buttonAbout_HDB);
            panelMenu_HDB.Dock = DockStyle.Right;
            panelMenu_HDB.Location = new Point(684, 0);
            panelMenu_HDB.Name = "panelMenu_HDB";
            panelMenu_HDB.Size = new Size(684, 496);
            panelMenu_HDB.TabIndex = 0;
            // 
            // buttonGraph_HDB
            // 
            buttonGraph_HDB.Image = Properties.Resources.статистика;
            buttonGraph_HDB.Location = new Point(379, 3);
            buttonGraph_HDB.Name = "buttonGraph_HDB";
            buttonGraph_HDB.Size = new Size(293, 109);
            buttonGraph_HDB.TabIndex = 7;
            buttonGraph_HDB.UseVisualStyleBackColor = true;
            buttonGraph_HDB.Click += buttonGraph_HDB_Click;
            // 
            // textBoxMaxCost_HDB
            // 
            textBoxMaxCost_HDB.Location = new Point(200, 327);
            textBoxMaxCost_HDB.Name = "textBoxMaxCost_HDB";
            textBoxMaxCost_HDB.Size = new Size(125, 27);
            textBoxMaxCost_HDB.TabIndex = 6;
            // 
            // textBoxMinCost_HDB
            // 
            textBoxMinCost_HDB.Location = new Point(200, 258);
            textBoxMinCost_HDB.Name = "textBoxMinCost_HDB";
            textBoxMinCost_HDB.Size = new Size(125, 27);
            textBoxMinCost_HDB.TabIndex = 6;
            // 
            // textBoxAvCost_HDB
            // 
            textBoxAvCost_HDB.Location = new Point(200, 194);
            textBoxAvCost_HDB.Name = "textBoxAvCost_HDB";
            textBoxAvCost_HDB.Size = new Size(125, 27);
            textBoxAvCost_HDB.TabIndex = 6;
            // 
            // textBoxSum_HDB
            // 
            textBoxSum_HDB.Location = new Point(200, 131);
            textBoxSum_HDB.Name = "textBoxSum_HDB";
            textBoxSum_HDB.Size = new Size(125, 27);
            textBoxSum_HDB.TabIndex = 6;
            // 
            // buttonMaxCost_HDB
            // 
            buttonMaxCost_HDB.Location = new Point(15, 318);
            buttonMaxCost_HDB.Name = "buttonMaxCost_HDB";
            buttonMaxCost_HDB.Size = new Size(166, 45);
            buttonMaxCost_HDB.TabIndex = 5;
            buttonMaxCost_HDB.Text = "Максимальная цена";
            buttonMaxCost_HDB.UseVisualStyleBackColor = true;
            buttonMaxCost_HDB.Click += buttonMaxCost_HDB_Click;
            // 
            // buttonMinCost_HDB
            // 
            buttonMinCost_HDB.Location = new Point(15, 249);
            buttonMinCost_HDB.Name = "buttonMinCost_HDB";
            buttonMinCost_HDB.Size = new Size(166, 45);
            buttonMinCost_HDB.TabIndex = 5;
            buttonMinCost_HDB.Text = "Минимальная цена";
            buttonMinCost_HDB.UseVisualStyleBackColor = true;
            buttonMinCost_HDB.Click += buttonMinCost_HDB_Click;
            // 
            // buttonAvCost_HDB
            // 
            buttonAvCost_HDB.Location = new Point(15, 185);
            buttonAvCost_HDB.Name = "buttonAvCost_HDB";
            buttonAvCost_HDB.Size = new Size(166, 45);
            buttonAvCost_HDB.TabIndex = 5;
            buttonAvCost_HDB.Text = "Средняя цена";
            buttonAvCost_HDB.UseVisualStyleBackColor = true;
            buttonAvCost_HDB.Click += buttonAvCost_HDB_Click;
            // 
            // buttonSum_HDB
            // 
            buttonSum_HDB.Location = new Point(15, 118);
            buttonSum_HDB.Name = "buttonSum_HDB";
            buttonSum_HDB.Size = new Size(166, 52);
            buttonSum_HDB.TabIndex = 5;
            buttonSum_HDB.Text = "Общее количество продуктов на складе";
            buttonSum_HDB.UseVisualStyleBackColor = true;
            buttonSum_HDB.Click += buttonSum_HDB_Click;
            // 
            // groupBoxStringsAdd_HDB
            // 
            groupBoxStringsAdd_HDB.BackColor = SystemColors.ActiveCaption;
            groupBoxStringsAdd_HDB.Controls.Add(labelCountPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(labelInfoPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(labelPrice_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(labelCodeProduct_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(labelNameOfPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(textBoxPrice_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(textBoxCountPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(textBoxInfoPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(textBoxNameOfPro_HDB);
            groupBoxStringsAdd_HDB.Controls.Add(textBoxCodeProduct_HDB);
            groupBoxStringsAdd_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxStringsAdd_HDB.Location = new Point(379, 118);
            groupBoxStringsAdd_HDB.Name = "groupBoxStringsAdd_HDB";
            groupBoxStringsAdd_HDB.Size = new Size(293, 366);
            groupBoxStringsAdd_HDB.TabIndex = 4;
            groupBoxStringsAdd_HDB.TabStop = false;
            groupBoxStringsAdd_HDB.Text = "Добавить Поставку";
            // 
            // labelCountPro_HDB
            // 
            labelCountPro_HDB.AutoSize = true;
            labelCountPro_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCountPro_HDB.Location = new Point(9, 177);
            labelCountPro_HDB.Name = "labelCountPro_HDB";
            labelCountPro_HDB.Size = new Size(95, 20);
            labelCountPro_HDB.TabIndex = 1;
            labelCountPro_HDB.Text = "Количество";
            // 
            // labelInfoPro_HDB
            // 
            labelInfoPro_HDB.AutoSize = true;
            labelInfoPro_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInfoPro_HDB.Location = new Point(9, 305);
            labelInfoPro_HDB.Name = "labelInfoPro_HDB";
            labelInfoPro_HDB.Size = new Size(243, 20);
            labelInfoPro_HDB.TabIndex = 1;
            labelInfoPro_HDB.Text = "Примечания\\доп. Информация";
            // 
            // labelPrice_HDB
            // 
            labelPrice_HDB.AutoSize = true;
            labelPrice_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPrice_HDB.Location = new Point(9, 243);
            labelPrice_HDB.Name = "labelPrice_HDB";
            labelPrice_HDB.Size = new Size(132, 20);
            labelPrice_HDB.TabIndex = 1;
            labelPrice_HDB.Text = "Стоимость кг\\ед.";
            // 
            // labelCodeProduct_HDB
            // 
            labelCodeProduct_HDB.AutoSize = true;
            labelCodeProduct_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCodeProduct_HDB.Location = new Point(9, 44);
            labelCodeProduct_HDB.Name = "labelCodeProduct_HDB";
            labelCodeProduct_HDB.Size = new Size(95, 20);
            labelCodeProduct_HDB.TabIndex = 1;
            labelCodeProduct_HDB.Text = "Код товара:";
            // 
            // labelNameOfPro_HDB
            // 
            labelNameOfPro_HDB.AutoSize = true;
            labelNameOfPro_HDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNameOfPro_HDB.Location = new Point(9, 108);
            labelNameOfPro_HDB.Name = "labelNameOfPro_HDB";
            labelNameOfPro_HDB.Size = new Size(132, 20);
            labelNameOfPro_HDB.TabIndex = 1;
            labelNameOfPro_HDB.Text = "Название товара";
            // 
            // textBoxPrice_HDB
            // 
            textBoxPrice_HDB.Location = new Point(6, 266);
            textBoxPrice_HDB.Name = "textBoxPrice_HDB";
            textBoxPrice_HDB.Size = new Size(225, 27);
            textBoxPrice_HDB.TabIndex = 0;
            // 
            // textBoxCountPro_HDB
            // 
            textBoxCountPro_HDB.Location = new Point(6, 200);
            textBoxCountPro_HDB.Name = "textBoxCountPro_HDB";
            textBoxCountPro_HDB.Size = new Size(225, 27);
            textBoxCountPro_HDB.TabIndex = 0;
            // 
            // textBoxInfoPro_HDB
            // 
            textBoxInfoPro_HDB.Location = new Point(6, 328);
            textBoxInfoPro_HDB.Name = "textBoxInfoPro_HDB";
            textBoxInfoPro_HDB.Size = new Size(225, 27);
            textBoxInfoPro_HDB.TabIndex = 0;
            // 
            // textBoxNameOfPro_HDB
            // 
            textBoxNameOfPro_HDB.Location = new Point(6, 131);
            textBoxNameOfPro_HDB.Name = "textBoxNameOfPro_HDB";
            textBoxNameOfPro_HDB.Size = new Size(225, 27);
            textBoxNameOfPro_HDB.TabIndex = 0;
            // 
            // textBoxCodeProduct_HDB
            // 
            textBoxCodeProduct_HDB.Location = new Point(6, 67);
            textBoxCodeProduct_HDB.Name = "textBoxCodeProduct_HDB";
            textBoxCodeProduct_HDB.Size = new Size(225, 27);
            textBoxCodeProduct_HDB.TabIndex = 0;
            // 
            // buttonAddProduct_HDB
            // 
            buttonAddProduct_HDB.BackColor = SystemColors.HighlightText;
            buttonAddProduct_HDB.Image = (Image)resources.GetObject("buttonAddProduct_HDB.Image");
            buttonAddProduct_HDB.Location = new Point(293, 404);
            buttonAddProduct_HDB.Name = "buttonAddProduct_HDB";
            buttonAddProduct_HDB.Size = new Size(80, 80);
            buttonAddProduct_HDB.TabIndex = 3;
            buttonAddProduct_HDB.UseVisualStyleBackColor = false;
            buttonAddProduct_HDB.Click += buttonAddProduct_HDB_Click;
            // 
            // buttonSaveFile_HDB
            // 
            buttonSaveFile_HDB.Image = Properties.Resources.page_save;
            buttonSaveFile_HDB.Location = new Point(101, 12);
            buttonSaveFile_HDB.Name = "buttonSaveFile_HDB";
            buttonSaveFile_HDB.Size = new Size(80, 80);
            buttonSaveFile_HDB.TabIndex = 2;
            buttonSaveFile_HDB.UseVisualStyleBackColor = true;
            buttonSaveFile_HDB.Click += buttonSaveFile_HDB_Click;
            // 
            // buttonAddFile_HDB
            // 
            buttonAddFile_HDB.Image = Properties.Resources.page_add;
            buttonAddFile_HDB.Location = new Point(15, 12);
            buttonAddFile_HDB.Name = "buttonAddFile_HDB";
            buttonAddFile_HDB.Size = new Size(80, 80);
            buttonAddFile_HDB.TabIndex = 2;
            buttonAddFile_HDB.UseVisualStyleBackColor = true;
            buttonAddFile_HDB.Click += buttonAddFile_HDB_Click;
            // 
            // buttonHelp_HDB
            // 
            buttonHelp_HDB.Image = Properties.Resources.help;
            buttonHelp_HDB.Location = new Point(15, 404);
            buttonHelp_HDB.Name = "buttonHelp_HDB";
            buttonHelp_HDB.Size = new Size(80, 80);
            buttonHelp_HDB.TabIndex = 1;
            buttonHelp_HDB.UseVisualStyleBackColor = true;
            // 
            // buttonAbout_HDB
            // 
            buttonAbout_HDB.Image = Properties.Resources.information;
            buttonAbout_HDB.Location = new Point(101, 404);
            buttonAbout_HDB.Name = "buttonAbout_HDB";
            buttonAbout_HDB.Size = new Size(80, 80);
            buttonAbout_HDB.TabIndex = 1;
            buttonAbout_HDB.UseVisualStyleBackColor = true;
            // 
            // panelGrid_HDB
            // 
            panelGrid_HDB.BackColor = SystemColors.ActiveCaption;
            panelGrid_HDB.Controls.Add(dataGridView_HDB);
            panelGrid_HDB.Dock = DockStyle.Left;
            panelGrid_HDB.Location = new Point(0, 0);
            panelGrid_HDB.Name = "panelGrid_HDB";
            panelGrid_HDB.Size = new Size(684, 496);
            panelGrid_HDB.TabIndex = 0;
            // 
            // dataGridView_HDB
            // 
            dataGridView_HDB.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView_HDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_HDB.Columns.AddRange(new DataGridViewColumn[] { ColumnCount__HDB, ColumnCodePro_HDB, ColumnNameOfPro_HDB, ColumnCount_HDB, ColumnPrice_HDB, ColumnInfo_HDB });
            dataGridView_HDB.Location = new Point(3, 12);
            dataGridView_HDB.Name = "dataGridView_HDB";
            dataGridView_HDB.RowHeadersVisible = false;
            dataGridView_HDB.RowHeadersWidth = 51;
            dataGridView_HDB.Size = new Size(675, 472);
            dataGridView_HDB.TabIndex = 0;
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
            // openFileDialogTask_HDB
            // 
            openFileDialogTask_HDB.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 496);
            Controls.Add(panelMenu_HDB);
            Controls.Add(panelGrid_HDB);
            Name = "FormMain";
            Text = "Menu";
            panelMenu_HDB.ResumeLayout(false);
            panelMenu_HDB.PerformLayout();
            groupBoxStringsAdd_HDB.ResumeLayout(false);
            groupBoxStringsAdd_HDB.PerformLayout();
            panelGrid_HDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_HDB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu_HDB;
        private Panel panelGrid_HDB;
        private Button buttonSaveFile_HDB;
        private Button buttonAddFile_HDB;
        private Button buttonHelp_HDB;
        private Button buttonAbout_HDB;
        private DataGridView dataGridView_HDB;
        private OpenFileDialog openFileDialogTask_HDB;
        private SaveFileDialog saveFileDialogTask_HDB;
        private Button buttonAddProduct_HDB;
        private GroupBox groupBoxStringsAdd_HDB;
        private Label labelCountPro_HDB;
        private Label labelInfoPro_HDB;
        private Label labelPrice_HDB;
        private Label labelCodeProduct_HDB;
        private Label labelNameOfPro_HDB;
        private TextBox textBoxPrice_HDB;
        private TextBox textBoxCountPro_HDB;
        private TextBox textBoxInfoPro_HDB;
        private TextBox textBoxNameOfPro_HDB;
        private TextBox textBoxCodeProduct_HDB;
        private DataGridViewTextBoxColumn ColumnCount__HDB;
        private DataGridViewTextBoxColumn ColumnCodePro_HDB;
        private DataGridViewTextBoxColumn ColumnNameOfPro_HDB;
        private DataGridViewTextBoxColumn ColumnCount_HDB;
        private DataGridViewTextBoxColumn ColumnPrice_HDB;
        private DataGridViewTextBoxColumn ColumnInfo_HDB;
        private Button buttonMaxCost_HDB;
        private Button buttonMinCost_HDB;
        private Button buttonAvCost_HDB;
        private Button buttonSum_HDB;
        private TextBox textBoxAvCost_HDB;
        private TextBox textBoxSum_HDB;
        private TextBox textBoxMaxCost_HDB;
        private TextBox textBoxMinCost_HDB;
        private Button buttonGraph_HDB;
    }
}
