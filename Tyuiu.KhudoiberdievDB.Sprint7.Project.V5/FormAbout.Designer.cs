namespace Tyuiu.KhudoiberdievDB.Sprint7.Project.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_HDB = new TextBox();
            SuspendLayout();
            // 
            // textBoxAbout_HDB
            // 
            textBoxAbout_HDB.Font = new Font("Segoe UI", 12F);
            textBoxAbout_HDB.Location = new Point(12, 12);
            textBoxAbout_HDB.Multiline = true;
            textBoxAbout_HDB.Name = "textBoxAbout_HDB";
            textBoxAbout_HDB.Size = new Size(629, 297);
            textBoxAbout_HDB.TabIndex = 0;
            textBoxAbout_HDB.TabStop = false;
            textBoxAbout_HDB.Text = resources.GetString("textBoxAbout_HDB.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 321);
            Controls.Add(textBoxAbout_HDB);
            MaximizeBox = false;
            MaximumSize = new Size(671, 368);
            MinimizeBox = false;
            MinimumSize = new Size(671, 368);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_HDB;
    }
}