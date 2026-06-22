namespace park_management
{
    partial class AdminRate
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.numBaseFee = new System.Windows.Forms.NumericUpDown();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRateID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.dashboardBttn = new System.Windows.Forms.Button();
            this.TranscBttn = new System.Windows.Forms.Button();
            this.EntryBttn = new System.Windows.Forms.Button();
            this.RateBttn = new System.Windows.Forms.Button();
            this.vehicleBttn = new System.Windows.Forms.Button();
            this.parkSlotbttn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseFee)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dgvPreview);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numHourlyRate);
            this.panel2.Controls.Add(this.numBaseFee);
            this.panel2.Controls.Add(this.cmbVehicleType);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtPlate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRateID);
            this.panel2.Location = new System.Drawing.Point(180, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 479);
            this.panel2.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 37);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rate Management";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Current Rates";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(214, 107);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fee Preview ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToOrderColumns = true;
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(446, 161);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.Size = new System.Drawing.Size(233, 168);
            this.dgvPreview.TabIndex = 25;
            this.dgvPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(322, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 37);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 37);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 37);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Rate";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hourly (RM)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Base fee (RM)";
            // 
            // numHourlyRate
            // 
            this.numHourlyRate.Location = new System.Drawing.Point(189, 209);
            this.numHourlyRate.Name = "numHourlyRate";
            this.numHourlyRate.Size = new System.Drawing.Size(120, 22);
            this.numHourlyRate.TabIndex = 19;
            this.numHourlyRate.ValueChanged += new System.EventHandler(this.numHourlyRate_ValueChanged);
            // 
            // numBaseFee
            // 
            this.numBaseFee.Location = new System.Drawing.Point(30, 209);
            this.numBaseFee.Name = "numBaseFee";
            this.numBaseFee.Size = new System.Drawing.Size(120, 22);
            this.numBaseFee.TabIndex = 18;
            this.numBaseFee.ValueChanged += new System.EventHandler(this.numBaseFee_ValueChanged);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(220, 146);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(121, 24);
            this.cmbVehicleType.TabIndex = 10;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 62);
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
            // txtPlate
            // 
            this.txtPlate.AutoSize = true;
            this.txtPlate.Location = new System.Drawing.Point(217, 129);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(92, 16);
            this.txtPlate.TabIndex = 15;
            this.txtPlate.Text = "Vehicle Type*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rate ID (Auto)";
            // 
            // txtRateID
            // 
            this.txtRateID.Location = new System.Drawing.Point(25, 148);
            this.txtRateID.Name = "txtRateID";
            this.txtRateID.Size = new System.Drawing.Size(125, 22);
            this.txtRateID.TabIndex = 13;
            this.txtRateID.TextChanged += new System.EventHandler(this.txtRateID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.linkLogOut);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dashboardBttn);
            this.panel1.Controls.Add(this.TranscBttn);
            this.panel1.Controls.Add(this.EntryBttn);
            this.panel1.Controls.Add(this.RateBttn);
            this.panel1.Controls.Add(this.vehicleBttn);
            this.panel1.Controls.Add(this.parkSlotbttn);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 357);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Admin Panel";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "ParkSys";
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
            // AdminRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(996, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminRate";
            this.Text = "AdminRate";
            this.Load += new System.EventHandler(this.AdminRate_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourlyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseFee)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.Label txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRateID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHourlyRate;
        private System.Windows.Forms.NumericUpDown numBaseFee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dashboardBttn;
        private System.Windows.Forms.Button TranscBttn;
        private System.Windows.Forms.Button EntryBttn;
        private System.Windows.Forms.Button RateBttn;
        private System.Windows.Forms.Button vehicleBttn;
        private System.Windows.Forms.Button parkSlotbttn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
    }
}