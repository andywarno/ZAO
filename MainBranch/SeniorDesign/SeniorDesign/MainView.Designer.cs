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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.BHPDLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fields = new System.Windows.Forms.GroupBox();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.btnUpdateFields = new System.Windows.Forms.Button();
            this.btnPrintRep = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.cmbCrimeType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).BeginInit();
            this.Fields.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(163, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "CRIME ANALYSIS WORKBOOK";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Location = new System.Drawing.Point(12, 99);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1149, 595);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.editCell);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(1167, 99);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 25);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Edit Users";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // BHPDLogo
            // 
            this.BHPDLogo.Image = ((System.Drawing.Image)(resources.GetObject("BHPDLogo.Image")));
            this.BHPDLogo.Location = new System.Drawing.Point(424, 23);
            this.BHPDLogo.Name = "BHPDLogo";
            this.BHPDLogo.Size = new System.Drawing.Size(74, 58);
            this.BHPDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BHPDLogo.TabIndex = 4;
            this.BHPDLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "+ New Crime Sheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fields
            // 
            this.Fields.Controls.Add(this.clb);
            this.Fields.Controls.Add(this.btnUpdateFields);
            this.Fields.Location = new System.Drawing.Point(1167, 346);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(254, 348);
            this.Fields.TabIndex = 10;
            this.Fields.TabStop = false;
            this.Fields.Text = "Fields";
            // 
            // clb
            // 
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(6, 19);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(242, 289);
            this.clb.TabIndex = 11;
            // 
            // btnUpdateFields
            // 
            this.btnUpdateFields.Location = new System.Drawing.Point(6, 319);
            this.btnUpdateFields.Name = "btnUpdateFields";
            this.btnUpdateFields.Size = new System.Drawing.Size(242, 23);
            this.btnUpdateFields.TabIndex = 11;
            this.btnUpdateFields.Text = "Update Fields";
            this.btnUpdateFields.UseVisualStyleBackColor = true;
            this.btnUpdateFields.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrintRep
            // 
            this.btnPrintRep.Location = new System.Drawing.Point(1167, 130);
            this.btnPrintRep.Name = "btnPrintRep";
            this.btnPrintRep.Size = new System.Drawing.Size(120, 26);
            this.btnPrintRep.TabIndex = 11;
            this.btnPrintRep.Text = "Print Report";
            this.btnPrintRep.UseVisualStyleBackColor = true;
            this.btnPrintRep.Click += new System.EventHandler(this.btnPrintRep_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1212, 233);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1212, 269);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1167, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1167, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "End:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1167, 162);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 26);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "- Delete Crime Sheet";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(1296, 99);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(65, 89);
            this.btnMap.TabIndex = 17;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(1367, 99);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(66, 89);
            this.btnChart.TabIndex = 18;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // cmbCrimeType
            // 
            this.cmbCrimeType.FormattingEnabled = true;
            this.cmbCrimeType.Location = new System.Drawing.Point(1236, 306);
            this.cmbCrimeType.Name = "cmbCrimeType";
            this.cmbCrimeType.Size = new System.Drawing.Size(176, 21);
            this.cmbCrimeType.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1167, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Crime Type:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(1082, 58);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(248, 29);
            this.txtSearchBox.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1327, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 721);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCrimeType);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnPrintRep);
            this.Controls.Add(this.Fields);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BHPDLogo);
            this.Name = "MainView";
            this.Text = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BHPDLogo)).EndInit();
            this.Fields.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BHPDLogo;
        private System.Windows.Forms.Label TitleLabel;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Fields;
        private System.Windows.Forms.Button btnUpdateFields;
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Button btnPrintRep;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.ComboBox cmbCrimeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
    }
}