namespace park_management
{
    partial class adminTransaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboardBttn = new System.Windows.Forms.Button();
            this.TranscBttn = new System.Windows.Forms.Button();
            this.EntryBttn = new System.Windows.Forms.Button();
            this.RateBttn = new System.Windows.Forms.Button();
            this.vehicleBttn = new System.Windows.Forms.Button();
            this.parkSlotbttn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpboxActive = new System.Windows.Forms.GroupBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.gpboxCompleted = new System.Windows.Forms.GroupBox();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.gpboxRevenue = new System.Windows.Forms.GroupBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.gpboxTotalSessions = new System.Windows.Forms.GroupBox();
            this.lblTotalSessions = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnRecordExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpboxActive.SuspendLayout();
            this.gpboxCompleted.SuspendLayout();
            this.gpboxRevenue.SuspendLayout();
            this.gpboxTotalSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLogOut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dashboardBttn);
            this.panel1.Controls.Add(this.TranscBttn);
            this.panel1.Controls.Add(this.EntryBttn);
            this.panel1.Controls.Add(this.RateBttn);
            this.panel1.Controls.Add(this.vehicleBttn);
            this.panel1.Controls.Add(this.parkSlotbttn);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 357);
            this.panel1.TabIndex = 2;
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
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.gpboxActive);
            this.panel2.Controls.Add(this.gpboxCompleted);
            this.panel2.Controls.Add(this.gpboxRevenue);
            this.panel2.Controls.Add(this.gpboxTotalSessions);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dgvTransactions);
            this.panel2.Controls.Add(this.btnRecordExit);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(181, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 422);
            this.panel2.TabIndex = 12;
            // 
            // gpboxActive
            // 
            this.gpboxActive.Controls.Add(this.lblActive);
            this.gpboxActive.Location = new System.Drawing.Point(148, 158);
            this.gpboxActive.Name = "gpboxActive";
            this.gpboxActive.Size = new System.Drawing.Size(127, 72);
            this.gpboxActive.TabIndex = 39;
            this.gpboxActive.TabStop = false;
            this.gpboxActive.Text = "Active";
            this.gpboxActive.Enter += new System.EventHandler(this.gpboxActive_Enter);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(37, 36);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(14, 16);
            this.lblActive.TabIndex = 1;
            this.lblActive.Text = "0";
            this.lblActive.Click += new System.EventHandler(this.label4_Click);
            // 
            // gpboxCompleted
            // 
            this.gpboxCompleted.Controls.Add(this.lblCompleted);
            this.gpboxCompleted.Location = new System.Drawing.Point(281, 158);
            this.gpboxCompleted.Name = "gpboxCompleted";
            this.gpboxCompleted.Size = new System.Drawing.Size(127, 72);
            this.gpboxCompleted.TabIndex = 39;
            this.gpboxCompleted.TabStop = false;
            this.gpboxCompleted.Text = "Completed";
            this.gpboxCompleted.Enter += new System.EventHandler(this.gpboxCompleted_Enter);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(37, 32);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(14, 16);
            this.lblCompleted.TabIndex = 2;
            this.lblCompleted.Text = "0";
            this.lblCompleted.Click += new System.EventHandler(this.lblCompleted_Click);
            // 
            // gpboxRevenue
            // 
            this.gpboxRevenue.Controls.Add(this.lblRevenue);
            this.gpboxRevenue.Location = new System.Drawing.Point(414, 158);
            this.gpboxRevenue.Name = "gpboxRevenue";
            this.gpboxRevenue.Size = new System.Drawing.Size(127, 72);
            this.gpboxRevenue.TabIndex = 39;
            this.gpboxRevenue.TabStop = false;
            this.gpboxRevenue.Text = "Revenue";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(44, 32);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(38, 16);
            this.lblRevenue.TabIndex = 3;
            this.lblRevenue.Text = "RM 0";
            this.lblRevenue.Click += new System.EventHandler(this.lblRevenue_Click);
            // 
            // gpboxTotalSessions
            // 
            this.gpboxTotalSessions.Controls.Add(this.lblTotalSessions);
            this.gpboxTotalSessions.Location = new System.Drawing.Point(14, 158);
            this.gpboxTotalSessions.Name = "gpboxTotalSessions";
            this.gpboxTotalSessions.Size = new System.Drawing.Size(127, 72);
            this.gpboxTotalSessions.TabIndex = 38;
            this.gpboxTotalSessions.TabStop = false;
            this.gpboxTotalSessions.Text = "Total Sessions";
            this.gpboxTotalSessions.Enter += new System.EventHandler(this.gpboxTotalSessions_Enter);
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.AutoSize = true;
            this.lblTotalSessions.Location = new System.Drawing.Point(36, 32);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(14, 16);
            this.lblTotalSessions.TabIndex = 0;
            this.lblTotalSessions.Text = "0";
            this.lblTotalSessions.Click += new System.EventHandler(this.lblTotalSessions_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Transaction Monitor";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToOrderColumns = true;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(22, 251);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(519, 147);
            this.dgvTransactions.TabIndex = 27;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // btnRecordExit
            // 
            this.btnRecordExit.Location = new System.Drawing.Point(475, 106);
            this.btnRecordExit.Name = "btnRecordExit";
            this.btnRecordExit.Size = new System.Drawing.Size(85, 30);
            this.btnRecordExit.TabIndex = 24;
            this.btnRecordExit.Text = "Record Exit";
            this.btnRecordExit.UseVisualStyleBackColor = true;
            this.btnRecordExit.Click += new System.EventHandler(this.btnRecordExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(405, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 30);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search Plate :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(359, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // adminTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(855, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminTransaction";
            this.Text = "adminTransaction";
            this.Load += new System.EventHandler(this.adminTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpboxActive.ResumeLayout(false);
            this.gpboxActive.PerformLayout();
            this.gpboxCompleted.ResumeLayout(false);
            this.gpboxCompleted.PerformLayout();
            this.gpboxRevenue.ResumeLayout(false);
            this.gpboxRevenue.PerformLayout();
            this.gpboxTotalSessions.ResumeLayout(false);
            this.gpboxTotalSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Button dashboardBttn;
        private System.Windows.Forms.Button TranscBttn;
        private System.Windows.Forms.Button EntryBttn;
        private System.Windows.Forms.Button RateBttn;
        private System.Windows.Forms.Button vehicleBttn;
        private System.Windows.Forms.Button parkSlotbttn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnRecordExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gpboxActive;
        private System.Windows.Forms.GroupBox gpboxCompleted;
        private System.Windows.Forms.GroupBox gpboxRevenue;
        private System.Windows.Forms.GroupBox gpboxTotalSessions;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblTotalSessions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}