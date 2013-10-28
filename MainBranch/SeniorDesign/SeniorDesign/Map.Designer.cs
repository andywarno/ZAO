namespace SeniorDesign
{
    partial class Map
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
            this.gmc1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmc1
            // 
            this.gmc1.Bearing = 0F;
            this.gmc1.CanDragMap = true;
            this.gmc1.GrayScaleMode = false;
            this.gmc1.LevelsKeepInMemmory = 5;
            this.gmc1.Location = new System.Drawing.Point(3, 38);
            this.gmc1.MarkersEnabled = true;
            this.gmc1.MaxZoom = 2;
            this.gmc1.MinZoom = 2;
            this.gmc1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmc1.Name = "gmc1";
            this.gmc1.NegativeMode = false;
            this.gmc1.PolygonsEnabled = true;
            this.gmc1.RetryLoadTile = 0;
            this.gmc1.RoutesEnabled = true;
            this.gmc1.ShowTileGridLines = false;
            this.gmc1.Size = new System.Drawing.Size(819, 550);
            this.gmc1.TabIndex = 0;
            this.gmc1.Zoom = 0D;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(828, 50);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(62, 55);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(896, 50);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(57, 55);
            this.btnZoomOut.TabIndex = 2;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 600);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.gmc1);
            this.Name = "Map";
            this.Text = "Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmc1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
    }
}