namespace Maps
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_isp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_mapas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.lbl_region = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_region);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_ip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_isp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Controls.Add(this.lbl_longitude);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_latitude);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_city);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_country);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbox_mapas);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(969, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(32, 289);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(17, 13);
            this.lbl_ip.TabIndex = 17;
            this.lbl_ip.Text = "# ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "IP: ";
            // 
            // lbl_isp
            // 
            this.lbl_isp.AutoSize = true;
            this.lbl_isp.Location = new System.Drawing.Point(32, 264);
            this.lbl_isp.Name = "lbl_isp";
            this.lbl_isp.Size = new System.Drawing.Size(17, 13);
            this.lbl_isp.TabIndex = 15;
            this.lbl_isp.Text = "# ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ISP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP: ";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(6, 48);
            this.txt_ip.Multiline = true;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ip.Size = new System.Drawing.Size(178, 60);
            this.txt_ip.TabIndex = 12;
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.Location = new System.Drawing.Point(54, 170);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(17, 13);
            this.lbl_longitude.TabIndex = 9;
            this.lbl_longitude.Text = "# ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Longitud: ";
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.Location = new System.Drawing.Point(54, 148);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(14, 13);
            this.lbl_latitude.TabIndex = 7;
            this.lbl_latitude.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Latitud: ";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(44, 241);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(17, 13);
            this.lbl_city.TabIndex = 5;
            this.lbl_city.Text = "# ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciudad: ";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(44, 195);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(17, 13);
            this.lbl_country.TabIndex = 3;
            this.lbl_country.Text = "# ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "País: ";
            // 
            // cmbox_mapas
            // 
            this.cmbox_mapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_mapas.FormattingEnabled = true;
            this.cmbox_mapas.Items.AddRange(new object[] {
            "Google Mapa",
            "Google Satélite",
            "Google Mapa Híbrido",
            "Google Mapa China",
            "Google Satélite China",
            "Bing Satélite",
            "Bing Mapa",
            "Yahoo Mapa",
            "Yahoo Satélite",
            "Yahoo Mapa Hibrído",
            "Open Street Map",
            "Open Clycle Map"});
            this.cmbox_mapas.Location = new System.Drawing.Point(6, 114);
            this.cmbox_mapas.Name = "cmbox_mapas";
            this.cmbox_mapas.Size = new System.Drawing.Size(178, 21);
            this.cmbox_mapas.TabIndex = 1;
            this.cmbox_mapas.SelectedIndexChanged += new System.EventHandler(this.cmbox_mapas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemmory = 5;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 2;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(969, 438);
            this.Map.TabIndex = 2;
            this.Map.Zoom = 0D;
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(44, 218);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(17, 13);
            this.lbl_region.TabIndex = 19;
            this.lbl_region.Text = "# ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Región: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 438);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.ComboBox cmbox_mapas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_longitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_latitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lbl_isp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Label label9;
    }
}

