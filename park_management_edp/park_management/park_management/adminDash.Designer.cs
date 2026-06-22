namespace park_management
{
    partial class adminDashBooard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalSlots = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboardBttn = new System.Windows.Forms.Button();
            this.TranscBttn = new System.Windows.Forms.Button();
            this.EntryBttn = new System.Windows.Forms.Button();
            this.RateBttn = new System.Windows.Forms.Button();
            this.vehicleBttn = new System.Windows.Forms.Button();
            this.parkSlotBttn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(180, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 463);
            this.panel2.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 252);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Vehicle";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(554, 186);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dasboard";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 227);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(554, 10);
            this.progressBar1.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(164)))), ((int)(((byte)(118)))));
            this.groupBox3.Controls.Add(this.lblAvailable);
            this.groupBox3.Location = new System.Drawing.Point(286, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 94);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(38, 47);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(30, 32);
            this.lblAvailable.TabIndex = 15;
            this.lblAvailable.Text = "0";
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(164)))), ((int)(((byte)(118)))));
            this.groupBox2.Controls.Add(this.lblOccupied);
            this.groupBox2.Location = new System.Drawing.Point(163, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Occupied";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupied.Location = new System.Drawing.Point(37, 47);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(30, 32);
            this.lblOccupied.TabIndex = 16;
            this.lblOccupied.Text = "0";
            this.lblOccupied.Click += new System.EventHandler(this.lblOccupied_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(164)))), ((int)(((byte)(118)))));
            this.groupBox4.Controls.Add(this.lblRevenue);
            this.groupBox4.Location = new System.Drawing.Point(415, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 94);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Revenue today";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(16, 50);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(69, 29);
            this.lblRevenue.TabIndex = 14;
            this.lblRevenue.Text = "RM 0";
            this.lblRevenue.Click += new System.EventHandler(this.lblRevenue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(164)))), ((int)(((byte)(118)))));
            this.groupBox1.Controls.Add(this.lblTotalSlots);
            this.groupBox1.Location = new System.Drawing.Point(39, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Slots";
            // 
            // lblTotalSlots
            // 
            this.lblTotalSlots.AutoSize = true;
            this.lblTotalSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSlots.Location = new System.Drawing.Point(36, 47);
            this.lblTotalSlots.Name = "lblTotalSlots";
            this.lblTotalSlots.Size = new System.Drawing.Size(30, 32);
            this.lblTotalSlots.TabIndex = 13;
            this.lblTotalSlots.Text = "0";
            this.lblTotalSlots.Click += new System.EventHandler(this.lblTotalSlots_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 62);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cark Park Management System ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.linkLogOut);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dashboardBttn);
            this.panel4.Controls.Add(this.TranscBttn);
            this.panel4.Controls.Add(this.EntryBttn);
            this.panel4.Controls.Add(this.RateBttn);
            this.panel4.Controls.Add(this.vehicleBttn);
            this.panel4.Controls.Add(this.parkSlotBttn);
            this.panel4.Location = new System.Drawing.Point(12, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 357);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Admin Panel";
            // 
            // linkLogOut
            // 
            this.linkLogOut.AutoSize = true;
            this.linkLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogOut.LinkColor = System.Drawing.Color.Brown;
            this.linkLogOut.Location = new System.Drawing.Point(45, 315);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(66, 18);
            this.linkLogOut.TabIndex = 8;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "Log Out";
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "ParkSys";
            // 
            // dashboardBttn
            // 
            this.dashboardBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBttn.Location = new System.Drawing.Point(7, 58);
            this.dashboardBttn.Name = "dashboardBttn";
            this.dashboardBttn.Size = new System.Drawing.Size(138, 35);
            this.dashboardBttn.TabIndex = 7;
            this.dashboardBttn.Text = "Dashboard";
            this.dashboardBttn.UseVisualStyleBackColor = true;
            this.dashboardBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TranscBttn
            // 
            this.TranscBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranscBttn.Location = new System.Drawing.Point(6, 227);
            this.TranscBttn.Name = "TranscBttn";
            this.TranscBttn.Size = new System.Drawing.Size(138, 35);
            this.TranscBttn.TabIndex = 4;
            this.TranscBttn.Text = "Transaction";
            this.TranscBttn.UseVisualStyleBackColor = true;
            this.TranscBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EntryBttn
            // 
            this.EntryBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryBttn.Location = new System.Drawing.Point(6, 185);
            this.EntryBttn.Name = "EntryBttn";
            this.EntryBttn.Size = new System.Drawing.Size(138, 35);
            this.EntryBttn.TabIndex = 3;
            this.EntryBttn.Text = "Entry";
            this.EntryBttn.UseVisualStyleBackColor = true;
            this.EntryBttn.Click += new System.EventHandler(this.button3_Click);
            // 
            // RateBttn
            // 
            this.RateBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateBttn.Location = new System.Drawing.Point(6, 143);
            this.RateBttn.Name = "RateBttn";
            this.RateBttn.Size = new System.Drawing.Size(138, 35);
            this.RateBttn.TabIndex = 2;
            this.RateBttn.Text = "Rate";
            this.RateBttn.UseVisualStyleBackColor = true;
            this.RateBttn.Click += new System.EventHandler(this.button4_Click);
            // 
            // vehicleBttn
            // 
            this.vehicleBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleBttn.Location = new System.Drawing.Point(6, 99);
            this.vehicleBttn.Name = "vehicleBttn";
            this.vehicleBttn.Size = new System.Drawing.Size(138, 35);
            this.vehicleBttn.TabIndex = 1;
            this.vehicleBttn.Text = "Vehicle";
            this.vehicleBttn.UseVisualStyleBackColor = true;
            this.vehicleBttn.Click += new System.EventHandler(this.button5_Click);
            // 
            // parkSlotBttn
            // 
            this.parkSlotBttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkSlotBttn.Location = new System.Drawing.Point(7, 268);
            this.parkSlotBttn.Name = "parkSlotBttn";
            this.parkSlotBttn.Size = new System.Drawing.Size(138, 35);
            this.parkSlotBttn.TabIndex = 0;
            this.parkSlotBttn.Text = "Parking Slot";
            this.parkSlotBttn.UseVisualStyleBackColor = true;
            this.parkSlotBttn.Click += new System.EventHandler(this.button6_Click);
            // 
            // adminDashBooard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "adminDashBooard";
            this.Text = "adminVehicle";
            this.Load += new System.EventHandler(this.adminDashBooard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalSlots;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dashboardBttn;
        private System.Windows.Forms.Button TranscBttn;
        private System.Windows.Forms.Button EntryBttn;
        private System.Windows.Forms.Button RateBttn;
        private System.Windows.Forms.Button vehicleBttn;
        private System.Windows.Forms.Button parkSlotBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}