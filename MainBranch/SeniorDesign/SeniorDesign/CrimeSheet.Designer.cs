namespace SeniorDesign
{
    partial class CrimeSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimeSheet));
            this.CrimeSheetTitle = new System.Windows.Forms.Label();
            this.BHPDLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.InvestigationButton = new System.Windows.Forms.Button();
            this.CrimeButton = new System.Windows.Forms.Button();
            this.VictimButton = new System.Windows.Forms.Button();
            this.InvestigationPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.InvestigationPanelEnterButton = new System.Windows.Forms.Button();
            this.RemarksLbl = new System.Windows.Forms.Label();
            this.DtcAssistantsLbl = new System.Windows.Forms.Label();
            this.ComplaintNoLbl = new System.Windows.Forms.Label();
            this.BusinessNameLbl = new System.Windows.Forms.Label();
            this.PrintsDNALbl = new System.Windows.Forms.Label();
            this.ArrestsMadeLbl = new System.Windows.Forms.Label();
            this.GangRelatedLbl = new System.Windows.Forms.Label();
            this.ChargeTypeLbl = new System.Windows.Forms.Label();
            this.CaseStatusLbl = new System.Windows.Forms.Label();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.tb18 = new System.Windows.Forms.TextBox();
            this.tb21 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb17 = new System.Windows.Forms.TextBox();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.VictimInfoPanel = new System.Windows.Forms.Panel();
            this.CrimeInfoPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CrimeInfoEnterButton = new System.Windows.Forms.Button();
            this.PropRecoveredLbl = new System.Windows.Forms.Label();
            this.PropValueLbl = new System.Windows.Forms.Label();
            this.PropDescripLbl = new System.Windows.Forms.Label();
            this.CrimeTimeLbl = new System.Windows.Forms.Label();
            this.AreaLbl = new System.Windows.Forms.Label();
            this.CrimeTypeLbl = new System.Windows.Forms.Label();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb04 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb05 = new System.Windows.Forms.TextBox();
            this.VictimInfoEnterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCrime = new System.Windows.Forms.DateTimePicker();
            this.slbAssist = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.InvestigationPanel.SuspendLayout();
            this.VictimInfoPanel.SuspendLayout();
            this.CrimeInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrimeSheetTitle
            // 
            this.CrimeSheetTitle.AutoSize = true;
            this.CrimeSheetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeSheetTitle.Location = new System.Drawing.Point(125, 34);
            this.CrimeSheetTitle.Name = "CrimeSheetTitle";
            this.CrimeSheetTitle.Size = new System.Drawing.Size(163, 13);
            this.CrimeSheetTitle.TabIndex = 8;
            this.CrimeSheetTitle.Text = "CRIME ANALYSIS WORKBOOK";
            // 
            // BHPDLogo
            // 
            this.BHPDLogo.Image = ((System.Drawing.Image)(resources.GetObject("BHPDLogo.Image")));
            this.BHPDLogo.Location = new System.Drawing.Point(37, 12);
            this.BHPDLogo.Name = "BHPDLogo";
            this.BHPDLogo.Size = new System.Drawing.Size(74, 58);
            this.BHPDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BHPDLogo.TabIndex = 7;
            this.BHPDLogo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 76);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SearchButton);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InvestigationPanel);
            this.splitContainer1.Panel2.Controls.Add(this.CrimeInfoPanel);
            this.splitContainer1.Panel2.Controls.Add(this.VictimInfoPanel);
            this.splitContainer1.Panel2.Controls.Add(this.ReviewButton);
            this.splitContainer1.Panel2.Controls.Add(this.InvestigationButton);
            this.splitContainer1.Panel2.Controls.Add(this.CrimeButton);
            this.splitContainer1.Panel2.Controls.Add(this.VictimButton);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(660, 373);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.BackgroundImage = global::SeniorDesign.Properties.Resources.ThumbprintGlass;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SearchButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(20, 18);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(83, 72);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.Gray;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReviewButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewButton.ForeColor = System.Drawing.Color.White;
            this.ReviewButton.Location = new System.Drawing.Point(373, 18);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(118, 23);
            this.ReviewButton.TabIndex = 10;
            this.ReviewButton.Text = "REVIEW";
            this.ReviewButton.UseVisualStyleBackColor = false;
            // 
            // InvestigationButton
            // 
            this.InvestigationButton.BackColor = System.Drawing.Color.Gray;
            this.InvestigationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InvestigationButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestigationButton.ForeColor = System.Drawing.Color.White;
            this.InvestigationButton.Location = new System.Drawing.Point(266, 18);
            this.InvestigationButton.Name = "InvestigationButton";
            this.InvestigationButton.Size = new System.Drawing.Size(101, 23);
            this.InvestigationButton.TabIndex = 9;
            this.InvestigationButton.Text = "INVESTIGATION";
            this.InvestigationButton.UseVisualStyleBackColor = false;
            this.InvestigationButton.Click += new System.EventHandler(this.InvestigationButton_Click);
            // 
            // CrimeButton
            // 
            this.CrimeButton.BackColor = System.Drawing.Color.Gray;
            this.CrimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrimeButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeButton.ForeColor = System.Drawing.Color.White;
            this.CrimeButton.Location = new System.Drawing.Point(144, 18);
            this.CrimeButton.Name = "CrimeButton";
            this.CrimeButton.Size = new System.Drawing.Size(116, 23);
            this.CrimeButton.TabIndex = 8;
            this.CrimeButton.Text = "CRIME INFORMATION";
            this.CrimeButton.UseVisualStyleBackColor = false;
            this.CrimeButton.Click += new System.EventHandler(this.CrimeButton_Click);
            // 
            // VictimButton
            // 
            this.VictimButton.BackColor = System.Drawing.Color.Black;
            this.VictimButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VictimButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictimButton.ForeColor = System.Drawing.Color.White;
            this.VictimButton.Location = new System.Drawing.Point(24, 18);
            this.VictimButton.Name = "VictimButton";
            this.VictimButton.Size = new System.Drawing.Size(114, 23);
            this.VictimButton.TabIndex = 7;
            this.VictimButton.Text = "VICTIM INFORMATION";
            this.VictimButton.UseVisualStyleBackColor = false;
            this.VictimButton.Click += new System.EventHandler(this.VictimButton_Click_1);
            // 
            // InvestigationPanel
            // 
            this.InvestigationPanel.Controls.Add(this.slbAssist);
            this.InvestigationPanel.Controls.Add(this.label10);
            this.InvestigationPanel.Controls.Add(this.InvestigationPanelEnterButton);
            this.InvestigationPanel.Controls.Add(this.RemarksLbl);
            this.InvestigationPanel.Controls.Add(this.DtcAssistantsLbl);
            this.InvestigationPanel.Controls.Add(this.ComplaintNoLbl);
            this.InvestigationPanel.Controls.Add(this.BusinessNameLbl);
            this.InvestigationPanel.Controls.Add(this.PrintsDNALbl);
            this.InvestigationPanel.Controls.Add(this.ArrestsMadeLbl);
            this.InvestigationPanel.Controls.Add(this.GangRelatedLbl);
            this.InvestigationPanel.Controls.Add(this.ChargeTypeLbl);
            this.InvestigationPanel.Controls.Add(this.CaseStatusLbl);
            this.InvestigationPanel.Controls.Add(this.tb22);
            this.InvestigationPanel.Controls.Add(this.tb18);
            this.InvestigationPanel.Controls.Add(this.tb21);
            this.InvestigationPanel.Controls.Add(this.tb20);
            this.InvestigationPanel.Controls.Add(this.tb17);
            this.InvestigationPanel.Controls.Add(this.tb16);
            this.InvestigationPanel.Controls.Add(this.tb15);
            this.InvestigationPanel.Controls.Add(this.tb14);
            this.InvestigationPanel.Location = new System.Drawing.Point(24, 45);
            this.InvestigationPanel.Name = "InvestigationPanel";
            this.InvestigationPanel.Size = new System.Drawing.Size(504, 326);
            this.InvestigationPanel.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(126, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "*";
            // 
            // InvestigationPanelEnterButton
            // 
            this.InvestigationPanelEnterButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestigationPanelEnterButton.Location = new System.Drawing.Point(403, 299);
            this.InvestigationPanelEnterButton.Name = "InvestigationPanelEnterButton";
            this.InvestigationPanelEnterButton.Size = new System.Drawing.Size(75, 23);
            this.InvestigationPanelEnterButton.TabIndex = 18;
            this.InvestigationPanelEnterButton.Text = "ENTER";
            this.InvestigationPanelEnterButton.UseVisualStyleBackColor = true;
            this.InvestigationPanelEnterButton.Click += new System.EventHandler(this.Submit);
            // 
            // RemarksLbl
            // 
            this.RemarksLbl.AutoSize = true;
            this.RemarksLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksLbl.Location = new System.Drawing.Point(163, 221);
            this.RemarksLbl.Name = "RemarksLbl";
            this.RemarksLbl.Size = new System.Drawing.Size(56, 15);
            this.RemarksLbl.TabIndex = 17;
            this.RemarksLbl.Text = "REMARKS:";
            // 
            // DtcAssistantsLbl
            // 
            this.DtcAssistantsLbl.AutoSize = true;
            this.DtcAssistantsLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtcAssistantsLbl.Location = new System.Drawing.Point(55, 147);
            this.DtcAssistantsLbl.Name = "DtcAssistantsLbl";
            this.DtcAssistantsLbl.Size = new System.Drawing.Size(164, 15);
            this.DtcAssistantsLbl.TabIndex = 16;
            this.DtcAssistantsLbl.Text = "ASSISTED BY OTHER DETECTIVES:";
            // 
            // ComplaintNoLbl
            // 
            this.ComplaintNoLbl.AutoSize = true;
            this.ComplaintNoLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaintNoLbl.Location = new System.Drawing.Point(138, 122);
            this.ComplaintNoLbl.Name = "ComplaintNoLbl";
            this.ComplaintNoLbl.Size = new System.Drawing.Size(81, 15);
            this.ComplaintNoLbl.TabIndex = 15;
            this.ComplaintNoLbl.Text = "COMPLAINT NO:";
            // 
            // BusinessNameLbl
            // 
            this.BusinessNameLbl.AutoSize = true;
            this.BusinessNameLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessNameLbl.Location = new System.Drawing.Point(133, 199);
            this.BusinessNameLbl.Name = "BusinessNameLbl";
            this.BusinessNameLbl.Size = new System.Drawing.Size(86, 15);
            this.BusinessNameLbl.TabIndex = 14;
            this.BusinessNameLbl.Text = "BUSINESS NAME:";
            // 
            // PrintsDNALbl
            // 
            this.PrintsDNALbl.AutoSize = true;
            this.PrintsDNALbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintsDNALbl.Location = new System.Drawing.Point(136, 173);
            this.PrintsDNALbl.Name = "PrintsDNALbl";
            this.PrintsDNALbl.Size = new System.Drawing.Size(83, 15);
            this.PrintsDNALbl.TabIndex = 13;
            this.PrintsDNALbl.Text = "PRINTS OR DNA:";
            // 
            // ArrestsMadeLbl
            // 
            this.ArrestsMadeLbl.AutoSize = true;
            this.ArrestsMadeLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrestsMadeLbl.Location = new System.Drawing.Point(136, 96);
            this.ArrestsMadeLbl.Name = "ArrestsMadeLbl";
            this.ArrestsMadeLbl.Size = new System.Drawing.Size(83, 15);
            this.ArrestsMadeLbl.TabIndex = 12;
            this.ArrestsMadeLbl.Text = "ARRESTS MADE:";
            // 
            // GangRelatedLbl
            // 
            this.GangRelatedLbl.AutoSize = true;
            this.GangRelatedLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GangRelatedLbl.Location = new System.Drawing.Point(137, 70);
            this.GangRelatedLbl.Name = "GangRelatedLbl";
            this.GangRelatedLbl.Size = new System.Drawing.Size(82, 15);
            this.GangRelatedLbl.TabIndex = 11;
            this.GangRelatedLbl.Text = "GANG RELATED:";
            // 
            // ChargeTypeLbl
            // 
            this.ChargeTypeLbl.AutoSize = true;
            this.ChargeTypeLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeTypeLbl.Location = new System.Drawing.Point(143, 44);
            this.ChargeTypeLbl.Name = "ChargeTypeLbl";
            this.ChargeTypeLbl.Size = new System.Drawing.Size(76, 15);
            this.ChargeTypeLbl.TabIndex = 10;
            this.ChargeTypeLbl.Text = "CHARGE TYPE:";
            // 
            // CaseStatusLbl
            // 
            this.CaseStatusLbl.AutoSize = true;
            this.CaseStatusLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseStatusLbl.Location = new System.Drawing.Point(144, 18);
            this.CaseStatusLbl.Name = "CaseStatusLbl";
            this.CaseStatusLbl.Size = new System.Drawing.Size(75, 15);
            this.CaseStatusLbl.TabIndex = 9;
            this.CaseStatusLbl.Text = "CASE STATUS:";
            // 
            // tb22
            // 
            this.tb22.Location = new System.Drawing.Point(225, 221);
            this.tb22.Multiline = true;
            this.tb22.Name = "tb22";
            this.tb22.Size = new System.Drawing.Size(253, 56);
            this.tb22.TabIndex = 8;
            // 
            // tb18
            // 
            this.tb18.Location = new System.Drawing.Point(225, 117);
            this.tb18.Name = "tb18";
            this.tb18.Size = new System.Drawing.Size(253, 20);
            this.tb18.TabIndex = 6;
            // 
            // tb21
            // 
            this.tb21.Location = new System.Drawing.Point(225, 194);
            this.tb21.Name = "tb21";
            this.tb21.Size = new System.Drawing.Size(253, 20);
            this.tb21.TabIndex = 5;
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(225, 168);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(253, 20);
            this.tb20.TabIndex = 4;
            // 
            // tb17
            // 
            this.tb17.Location = new System.Drawing.Point(225, 91);
            this.tb17.Name = "tb17";
            this.tb17.Size = new System.Drawing.Size(253, 20);
            this.tb17.TabIndex = 3;
            // 
            // tb16
            // 
            this.tb16.Location = new System.Drawing.Point(225, 65);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(253, 20);
            this.tb16.TabIndex = 2;
            // 
            // tb15
            // 
            this.tb15.Location = new System.Drawing.Point(225, 39);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(253, 20);
            this.tb15.TabIndex = 1;
            // 
            // tb14
            // 
            this.tb14.Location = new System.Drawing.Point(225, 13);
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(253, 20);
            this.tb14.TabIndex = 0;
            // 
            // VictimInfoPanel
            // 
            this.VictimInfoPanel.Controls.Add(this.dtpCrime);
            this.VictimInfoPanel.Controls.Add(this.label8);
            this.VictimInfoPanel.Controls.Add(this.label7);
            this.VictimInfoPanel.Controls.Add(this.tb02);
            this.VictimInfoPanel.Controls.Add(this.tb04);
            this.VictimInfoPanel.Controls.Add(this.label4);
            this.VictimInfoPanel.Controls.Add(this.tb05);
            this.VictimInfoPanel.Controls.Add(this.VictimInfoEnterButton);
            this.VictimInfoPanel.Controls.Add(this.label1);
            this.VictimInfoPanel.Controls.Add(this.label2);
            this.VictimInfoPanel.Location = new System.Drawing.Point(24, 45);
            this.VictimInfoPanel.Name = "VictimInfoPanel";
            this.VictimInfoPanel.Size = new System.Drawing.Size(504, 326);
            this.VictimInfoPanel.TabIndex = 20;
            // 
            // CrimeInfoPanel
            // 
            this.CrimeInfoPanel.Controls.Add(this.label5);
            this.CrimeInfoPanel.Controls.Add(this.CrimeInfoEnterButton);
            this.CrimeInfoPanel.Controls.Add(this.PropRecoveredLbl);
            this.CrimeInfoPanel.Controls.Add(this.PropValueLbl);
            this.CrimeInfoPanel.Controls.Add(this.PropDescripLbl);
            this.CrimeInfoPanel.Controls.Add(this.CrimeTimeLbl);
            this.CrimeInfoPanel.Controls.Add(this.AreaLbl);
            this.CrimeInfoPanel.Controls.Add(this.CrimeTypeLbl);
            this.CrimeInfoPanel.Controls.Add(this.tb13);
            this.CrimeInfoPanel.Controls.Add(this.tb10);
            this.CrimeInfoPanel.Controls.Add(this.tb12);
            this.CrimeInfoPanel.Controls.Add(this.tb11);
            this.CrimeInfoPanel.Controls.Add(this.tb9);
            this.CrimeInfoPanel.Controls.Add(this.tb8);
            this.CrimeInfoPanel.Controls.Add(this.tb7);
            this.CrimeInfoPanel.Location = new System.Drawing.Point(24, 45);
            this.CrimeInfoPanel.Name = "CrimeInfoPanel";
            this.CrimeInfoPanel.Size = new System.Drawing.Size(504, 326);
            this.CrimeInfoPanel.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "LOST/STOLEN/DAMAGED VALUE:";
            // 
            // CrimeInfoEnterButton
            // 
            this.CrimeInfoEnterButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeInfoEnterButton.Location = new System.Drawing.Point(403, 299);
            this.CrimeInfoEnterButton.Name = "CrimeInfoEnterButton";
            this.CrimeInfoEnterButton.Size = new System.Drawing.Size(75, 23);
            this.CrimeInfoEnterButton.TabIndex = 16;
            this.CrimeInfoEnterButton.Text = "ENTER";
            this.CrimeInfoEnterButton.UseVisualStyleBackColor = true;
            this.CrimeInfoEnterButton.Click += new System.EventHandler(this.Submit);
            // 
            // PropRecoveredLbl
            // 
            this.PropRecoveredLbl.AutoSize = true;
            this.PropRecoveredLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropRecoveredLbl.Location = new System.Drawing.Point(147, 171);
            this.PropRecoveredLbl.Name = "PropRecoveredLbl";
            this.PropRecoveredLbl.Size = new System.Drawing.Size(71, 15);
            this.PropRecoveredLbl.TabIndex = 14;
            this.PropRecoveredLbl.Text = "ASSIGNMENT:";
            // 
            // PropValueLbl
            // 
            this.PropValueLbl.AutoSize = true;
            this.PropValueLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropValueLbl.Location = new System.Drawing.Point(117, 120);
            this.PropValueLbl.Name = "PropValueLbl";
            this.PropValueLbl.Size = new System.Drawing.Size(101, 15);
            this.PropValueLbl.TabIndex = 13;
            this.PropValueLbl.Text = "RECOVERED VALUE:";
            // 
            // PropDescripLbl
            // 
            this.PropDescripLbl.AutoSize = true;
            this.PropDescripLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropDescripLbl.Location = new System.Drawing.Point(93, 94);
            this.PropDescripLbl.Name = "PropDescripLbl";
            this.PropDescripLbl.Size = new System.Drawing.Size(126, 15);
            this.PropDescripLbl.TabIndex = 12;
            this.PropDescripLbl.Text = "PROPERTY DESCRIPTION:";
            // 
            // CrimeTimeLbl
            // 
            this.CrimeTimeLbl.AutoSize = true;
            this.CrimeTimeLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeTimeLbl.Location = new System.Drawing.Point(138, 69);
            this.CrimeTimeLbl.Name = "CrimeTimeLbl";
            this.CrimeTimeLbl.Size = new System.Drawing.Size(81, 15);
            this.CrimeTimeLbl.TabIndex = 10;
            this.CrimeTimeLbl.Text = "TIME OF CRIME:";
            // 
            // AreaLbl
            // 
            this.AreaLbl.AutoSize = true;
            this.AreaLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLbl.Location = new System.Drawing.Point(184, 44);
            this.AreaLbl.Name = "AreaLbl";
            this.AreaLbl.Size = new System.Drawing.Size(35, 15);
            this.AreaLbl.TabIndex = 9;
            this.AreaLbl.Text = "AREA:";
            // 
            // CrimeTypeLbl
            // 
            this.CrimeTypeLbl.AutoSize = true;
            this.CrimeTypeLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeTypeLbl.Location = new System.Drawing.Point(152, 18);
            this.CrimeTypeLbl.Name = "CrimeTypeLbl";
            this.CrimeTypeLbl.Size = new System.Drawing.Size(67, 15);
            this.CrimeTypeLbl.TabIndex = 8;
            this.CrimeTypeLbl.Text = "CRIME TYPE:";
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(225, 169);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(252, 20);
            this.tb13.TabIndex = 6;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(225, 91);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(252, 20);
            this.tb10.TabIndex = 5;
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(225, 143);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(252, 20);
            this.tb12.TabIndex = 4;
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(225, 117);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(252, 20);
            this.tb11.TabIndex = 3;
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(225, 65);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(252, 20);
            this.tb9.TabIndex = 2;
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(225, 39);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(252, 20);
            this.tb8.TabIndex = 1;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(225, 13);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(252, 20);
            this.tb7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(123, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "ZIP CODE:";
            // 
            // tb02
            // 
            this.tb02.Location = new System.Drawing.Point(226, 44);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(253, 20);
            this.tb02.TabIndex = 1;
            // 
            // tb04
            // 
            this.tb04.Location = new System.Drawing.Point(226, 74);
            this.tb04.Name = "tb04";
            this.tb04.Size = new System.Drawing.Size(253, 20);
            this.tb04.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "STREET ADDRESS:";
            // 
            // tb05
            // 
            this.tb05.Location = new System.Drawing.Point(226, 105);
            this.tb05.Name = "tb05";
            this.tb05.Size = new System.Drawing.Size(253, 20);
            this.tb05.TabIndex = 14;
            // 
            // VictimInfoEnterButton
            // 
            this.VictimInfoEnterButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictimInfoEnterButton.Location = new System.Drawing.Point(403, 299);
            this.VictimInfoEnterButton.Name = "VictimInfoEnterButton";
            this.VictimInfoEnterButton.Size = new System.Drawing.Size(75, 23);
            this.VictimInfoEnterButton.TabIndex = 6;
            this.VictimInfoEnterButton.Text = "ENTER";
            this.VictimInfoEnterButton.UseVisualStyleBackColor = true;
            this.VictimInfoEnterButton.Click += new System.EventHandler(this.Submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATE OF CRIME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "VICTIM\'S NAME:";
            // 
            // dtpCrime
            // 
            this.dtpCrime.Location = new System.Drawing.Point(226, 13);
            this.dtpCrime.Name = "dtpCrime";
            this.dtpCrime.Size = new System.Drawing.Size(231, 20);
            this.dtpCrime.TabIndex = 23;
            // 
            // slbAssist
            // 
            this.slbAssist.FormattingEnabled = true;
            this.slbAssist.Location = new System.Drawing.Point(224, 143);
            this.slbAssist.Name = "slbAssist";
            this.slbAssist.Size = new System.Drawing.Size(252, 19);
            this.slbAssist.TabIndex = 24;
            // 
            // CrimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.CrimeSheetTitle);
            this.Controls.Add(this.BHPDLogo);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CrimeSheet";
            this.Text = "CrimeSheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Return);
            this.Load += new System.EventHandler(this.CrimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.InvestigationPanel.ResumeLayout(false);
            this.InvestigationPanel.PerformLayout();
            this.VictimInfoPanel.ResumeLayout(false);
            this.VictimInfoPanel.PerformLayout();
            this.CrimeInfoPanel.ResumeLayout(false);
            this.CrimeInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrimeSheetTitle;
        private System.Windows.Forms.PictureBox BHPDLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel CrimeInfoPanel;
        private System.Windows.Forms.Panel InvestigationPanel;
        private System.Windows.Forms.Button InvestigationPanelEnterButton;
        private System.Windows.Forms.Label RemarksLbl;
        private System.Windows.Forms.Label DtcAssistantsLbl;
        private System.Windows.Forms.Label ComplaintNoLbl;
        private System.Windows.Forms.Label BusinessNameLbl;
        private System.Windows.Forms.Label PrintsDNALbl;
        private System.Windows.Forms.Label ArrestsMadeLbl;
        private System.Windows.Forms.Label GangRelatedLbl;
        private System.Windows.Forms.Label ChargeTypeLbl;
        private System.Windows.Forms.Label CaseStatusLbl;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb18;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb17;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.Label PropRecoveredLbl;
        private System.Windows.Forms.Label PropValueLbl;
        private System.Windows.Forms.Label PropDescripLbl;
        private System.Windows.Forms.Label CrimeTimeLbl;
        private System.Windows.Forms.Label AreaLbl;
        private System.Windows.Forms.Label CrimeTypeLbl;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Button ReviewButton;
        private System.Windows.Forms.Button InvestigationButton;
        private System.Windows.Forms.Button CrimeButton;
        private System.Windows.Forms.Button VictimButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel VictimInfoPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb04;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb05;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CrimeInfoEnterButton;
        private System.Windows.Forms.Button VictimInfoEnterButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpCrime;
        private System.Windows.Forms.CheckedListBox slbAssist;

    }
}