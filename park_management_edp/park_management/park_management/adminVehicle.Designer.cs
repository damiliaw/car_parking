namespace park_management
{
    partial class adminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchPlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColorModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtNoPlate = new System.Windows.Forms.TextBox();
            this.txtPlate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.dashboardBttn = new System.Windows.Forms.Button();
            this.TranscBttn = new System.Windows.Forms.Button();
            this.EntryBttn = new System.Windows.Forms.Button();
            this.RateBttn = new System.Windows.Forms.Button();
            this.vehicleBttn = new System.Windows.Forms.Button();
            this.parkSlotbttn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSearchPlate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvVehicles);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtColorModel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbVehicleType);
            this.panel2.Controls.Add(this.txtNoPlate);
            this.panel2.Controls.Add(this.txtPlate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtVehicleID);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(180, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 422);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Vehicle";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(545, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 26);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Search Plate...";
            // 
            // txtSearchPlate
            // 
            this.txtSearchPlate.Location = new System.Drawing.Point(374, 92);
            this.txtSearchPlate.Name = "txtSearchPlate";
            this.txtSearchPlate.Size = new System.Drawing.Size(147, 22);
            this.txtSearchPlate.TabIndex = 22;
            this.txtSearchPlate.TextChanged += new System.EventHandler(this.txtSearchPlate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Registered Vehicles";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(374, 194);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(240, 173);
            this.dgvVehicles.TabIndex = 20;
            this.dgvVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(126, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(19, 352);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 36);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color / Model";
            // 
            // txtColorModel
            // 
            this.txtColorModel.Location = new System.Drawing.Point(18, 306);
            this.txtColorModel.Name = "txtColorModel";
            this.txtColorModel.Size = new System.Drawing.Size(318, 22);
            this.txtColorModel.TabIndex = 15;
            this.txtColorModel.TextChanged += new System.EventHandler(this.txtColorModel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vehicle Type*";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(18, 223);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(318, 24);
            this.cmbVehicleType.TabIndex = 13;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // txtNoPlate
            // 
            this.txtNoPlate.Location = new System.Drawing.Point(209, 152);
            this.txtNoPlate.Name = "txtNoPlate";
            this.txtNoPlate.Size = new System.Drawing.Size(127, 22);
            this.txtNoPlate.TabIndex = 12;
            this.txtNoPlate.TextChanged += new System.EventHandler(this.txtNoPlate_TextChanged);
            // 
            // txtPlate
            // 
            this.txtPlate.AutoSize = true;
            this.txtPlate.Location = new System.Drawing.Point(206, 133);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(93, 16);
            this.txtPlate.TabIndex = 11;
            this.txtPlate.Text = "License Plate*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vehicle ID (auto)";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(18, 152);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(125, 22);
            this.txtVehicleID.TabIndex = 9;
            this.txtVehicleID.TextChanged += new System.EventHandler(this.txtVehicleID_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 62);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.linkLogOut);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dashboardBttn);
            this.panel1.Controls.Add(this.TranscBttn);
            this.panel1.Controls.Add(this.EntryBttn);
            this.panel1.Controls.Add(this.RateBttn);
            this.panel1.Controls.Add(this.vehicleBttn);
            this.panel1.Controls.Add(this.parkSlotbttn);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 357);
            this.panel1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Admin Panel";
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
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "ParkSys";
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
            this.dashboardBttn.Click += new System.EventHandler(this.dashboardBttn_Click);
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
            this.TranscBttn.Click += new System.EventHandler(this.TranscBttn_Click);
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
            this.EntryBttn.Click += new System.EventHandler(this.EntryBttn_Click);
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
            this.RateBttn.Click += new System.EventHandler(this.RateBttn_Click);
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
            this.vehicleBttn.Click += new System.EventHandler(this.vehicleBttn_Click);
            // 
            // parkSlotbttn
            // 
            this.parkSlotbttn.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkSlotbttn.Location = new System.Drawing.Point(7, 268);
            this.parkSlotbttn.Name = "parkSlotbttn";
            this.parkSlotbttn.Size = new System.Drawing.Size(138, 35);
            this.parkSlotbttn.TabIndex = 0;
            this.parkSlotbttn.Text = "Parking Slot";
            this.parkSlotbttn.UseVisualStyleBackColor = true;
            this.parkSlotbttn.Click += new System.EventHandler(this.parkSlotbttn_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(861, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "adminDashboard";
            this.Text = "adminDashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer lblClock;
        private System.Windows.Forms.TextBox txtNoPlate;
        private System.Windows.Forms.Label txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColorModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchPlate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dashboardBttn;
        private System.Windows.Forms.Button TranscBttn;
        private System.Windows.Forms.Button EntryBttn;
        private System.Windows.Forms.Button RateBttn;
        private System.Windows.Forms.Button vehicleBttn;
        private System.Windows.Forms.Button parkSlotbttn;
        private System.Windows.Forms.Label label9;
    }
}