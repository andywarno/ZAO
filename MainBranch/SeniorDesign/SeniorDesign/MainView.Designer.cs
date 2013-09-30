namespace SeniorDesign
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnQueryAll = new System.Windows.Forms.Button();
            this.txtQueryResult = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NewSheetButton = new System.Windows.Forms.Button();
            this.BHPDLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(548, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Connected to DB";
            // 
            // btnQueryAll
            // 
            this.btnQueryAll.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryAll.Location = new System.Drawing.Point(562, 422);
            this.btnQueryAll.Name = "btnQueryAll";
            this.btnQueryAll.Size = new System.Drawing.Size(75, 23);
            this.btnQueryAll.TabIndex = 2;
            this.btnQueryAll.Text = "QUERY ALL";
            this.btnQueryAll.UseVisualStyleBackColor = true;
            this.btnQueryAll.Click += new System.EventHandler(this.btnQueryAll_Click);
            // 
            // txtQueryResult
            // 
            this.txtQueryResult.Location = new System.Drawing.Point(138, 87);
            this.txtQueryResult.Multiline = true;
            this.txtQueryResult.Name = "txtQueryResult";
            this.txtQueryResult.Size = new System.Drawing.Size(499, 317);
            this.txtQueryResult.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(125, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(163, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "CRIME ANALYSIS WORKBOOK";
            // 
            // NewSheetButton
            // 
            this.NewSheetButton.BackgroundImage = global::SeniorDesign.Properties.Resources.CriminalPic;
            this.NewSheetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewSheetButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.NewSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSheetButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSheetButton.Location = new System.Drawing.Point(32, 87);
            this.NewSheetButton.Name = "NewSheetButton";
            this.NewSheetButton.Size = new System.Drawing.Size(83, 72);
            this.NewSheetButton.TabIndex = 0;
            this.NewSheetButton.Text = "NEW CRIMESHEET";
            this.NewSheetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewSheetButton.UseVisualStyleBackColor = true;
            // 
            // BHPDLogo
            // 
            this.BHPDLogo.Image = ((System.Drawing.Image)(resources.GetObject("BHPDLogo.Image")));
            this.BHPDLogo.Location = new System.Drawing.Point(37, 12);
            this.BHPDLogo.Name = "BHPDLogo";
            this.BHPDLogo.Size = new System.Drawing.Size(74, 58);
            this.BHPDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BHPDLogo.TabIndex = 4;
            this.BHPDLogo.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.NewSheetButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BHPDLogo);
            this.Controls.Add(this.txtQueryResult);
            this.Controls.Add(this.btnQueryAll);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnQueryAll;
        private System.Windows.Forms.TextBox txtQueryResult;
        private System.Windows.Forms.PictureBox BHPDLogo;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button NewSheetButton;
    }
}