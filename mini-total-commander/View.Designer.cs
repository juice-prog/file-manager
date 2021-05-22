namespace mini_total_commander
{
    partial class View
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.miniTCPanel2 = new mini_total_commander.MiniTCPanel();
            this.miniTCPanel1 = new mini_total_commander.MiniTCPanel();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(227, 539);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonClicked);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(588, 539);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 28);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Перемещение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonClicked);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(417, 539);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 28);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonClicked);
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Dir = null;
            this.miniTCPanel2.Drives = null;
            this.miniTCPanel2.Location = new System.Drawing.Point(471, 15);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.SelectedDir = null;
            this.miniTCPanel2.Size = new System.Drawing.Size(461, 569);
            this.miniTCPanel2.TabIndex = 1;
            this.miniTCPanel2.Load += new System.EventHandler(this.miniTCPanel2_Load);
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Dir = null;
            this.miniTCPanel1.Drives = null;
            this.miniTCPanel1.Location = new System.Drawing.Point(1, 15);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.SelectedDir = null;
            this.miniTCPanel1.Size = new System.Drawing.Size(461, 569);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 599);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.miniTCPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View";
            this.Text = "файл.Менеджер";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MiniTCPanel miniTCPanel1;
        private MiniTCPanel miniTCPanel2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCopy;
    }
}

