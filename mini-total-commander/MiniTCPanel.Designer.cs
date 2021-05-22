namespace mini_total_commander
{
    partial class MiniTCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.поле = new System.Windows.Forms.ListBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.Location = new System.Drawing.Point(344, 69);
            this.comboBoxDrives.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(65, 24);
            this.comboBoxDrives.TabIndex = 0;
            this.comboBoxDrives.DropDown += new System.EventHandler(this.loadDrives);
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.changeDrive);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(49, 37);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(360, 22);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.Text = "F:\\";
            this.textBoxPath.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // поле
            // 
            this.поле.FormattingEnabled = true;
            this.поле.ItemHeight = 16;
            this.поле.Location = new System.Drawing.Point(49, 139);
            this.поле.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.поле.Name = "поле";
            this.поле.Size = new System.Drawing.Size(360, 340);
            this.поле.TabIndex = 5;
            this.поле.SelectedIndexChanged += new System.EventHandler(this.SelectedItem);
            this.поле.DoubleClick += new System.EventHandler(this.ExecutePath);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(49, 101);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 28);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ReturnButtonClick);
            // 
            // MiniTCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.поле);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.comboBoxDrives);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiniTCPanel";
            this.Size = new System.Drawing.Size(461, 508);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListBox поле;
        private System.Windows.Forms.Button buttonReturn;
    }
}
