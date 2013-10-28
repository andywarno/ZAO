namespace SeniorDesign
{
    partial class SelectionMenu
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.rbNewCrimeSheet = new System.Windows.Forms.RadioButton();
            this.rbFinish = new System.Windows.Forms.RadioButton();
            this.rbMain = new System.Windows.Forms.RadioButton();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(40, 43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(92, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SELECT OPTION";
            // 
            // rbNewCrimeSheet
            // 
            this.rbNewCrimeSheet.AutoSize = true;
            this.rbNewCrimeSheet.Checked = true;
            this.rbNewCrimeSheet.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewCrimeSheet.Location = new System.Drawing.Point(43, 82);
            this.rbNewCrimeSheet.Name = "rbNewCrimeSheet";
            this.rbNewCrimeSheet.Size = new System.Drawing.Size(146, 19);
            this.rbNewCrimeSheet.TabIndex = 2;
            this.rbNewCrimeSheet.TabStop = true;
            this.rbNewCrimeSheet.Text = "START NEW CRIME SHEET";
            this.rbNewCrimeSheet.UseVisualStyleBackColor = true;
            this.rbNewCrimeSheet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // rbFinish
            // 
            this.rbFinish.AutoSize = true;
            this.rbFinish.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFinish.Location = new System.Drawing.Point(43, 108);
            this.rbFinish.Name = "rbFinish";
            this.rbFinish.Size = new System.Drawing.Size(139, 19);
            this.rbFinish.TabIndex = 3;
            this.rbFinish.Text = "FINISH PREVIOUS ENTRY";
            this.rbFinish.UseVisualStyleBackColor = true;
            this.rbFinish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // rbMain
            // 
            this.rbMain.AutoSize = true;
            this.rbMain.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMain.Location = new System.Drawing.Point(43, 134);
            this.rbMain.Name = "rbMain";
            this.rbMain.Size = new System.Drawing.Size(200, 19);
            this.rbMain.TabIndex = 4;
            this.rbMain.Text = "SEARCH CRIME ANALYSIS WORKBOOK";
            this.rbMain.UseVisualStyleBackColor = true;
            this.rbMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.Location = new System.Drawing.Point(43, 180);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // SelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 253);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.rbMain);
            this.Controls.Add(this.rbFinish);
            this.Controls.Add(this.rbNewCrimeSheet);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectionMenu";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.SelectionMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RadioButton rbNewCrimeSheet;
        private System.Windows.Forms.RadioButton rbFinish;
        private System.Windows.Forms.RadioButton rbMain;
        private System.Windows.Forms.Button OKbutton;
    }
}