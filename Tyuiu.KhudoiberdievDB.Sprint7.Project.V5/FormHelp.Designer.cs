namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxHelp_HDB = new TextBox();
            buttonBackT0MM_HDB = new Button();
            toolTipHelp_HDB = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxHelp_HDB
            // 
            textBoxHelp_HDB.Location = new Point(12, 12);
            textBoxHelp_HDB.Multiline = true;
            textBoxHelp_HDB.Name = "textBoxHelp_HDB";
            textBoxHelp_HDB.Size = new Size(776, 426);
            textBoxHelp_HDB.TabIndex = 0;
            textBoxHelp_HDB.TabStop = false;
            textBoxHelp_HDB.Text = resources.GetString("textBoxHelp_HDB.Text");
            textBoxHelp_HDB.TextChanged += textBoxHelp_HDB_TextChanged;
            // 
            // buttonBackT0MM_HDB
            // 
            buttonBackT0MM_HDB.Image = Properties.Resources.back_icon;
            buttonBackT0MM_HDB.Location = new Point(12, 12);
            buttonBackT0MM_HDB.Name = "buttonBackT0MM_HDB";
            buttonBackT0MM_HDB.Size = new Size(155, 90);
            buttonBackT0MM_HDB.TabIndex = 1;
            toolTipHelp_HDB.SetToolTip(buttonBackT0MM_HDB, "Вернуться в главное меню");
            buttonBackT0MM_HDB.UseVisualStyleBackColor = true;
            buttonBackT0MM_HDB.Click += buttonBackT0MM_HDB_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(buttonBackT0MM_HDB);
            Controls.Add(textBoxHelp_HDB);
            MaximizeBox = false;
            MaximumSize = new Size(818, 498);
            MinimizeBox = false;
            MinimumSize = new Size(818, 498);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHelp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_HDB;
        private Button buttonBackT0MM_HDB;
        private ToolTip toolTipHelp_HDB;
    }
}