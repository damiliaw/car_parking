using System;

namespace Project_EDP
{
    partial class FormDriverLogin
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.labelPlateNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlateNumber = new System.Windows.Forms.TextBox();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonBackLanding = new System.Windows.Forms.Button();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.labelTitle.Font = new System.Drawing.Font("Lucida Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(274, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(258, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Driver Portal";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEnter.Location = new System.Drawing.Point(278, 105);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(256, 18);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "Enter your vehicle number to continue";
            // 
            // labelPlateNumber
            // 
            this.labelPlateNumber.AutoSize = true;
            this.labelPlateNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.labelPlateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlateNumber.Location = new System.Drawing.Point(292, 154);
            this.labelPlateNumber.Name = "labelPlateNumber";
            this.labelPlateNumber.Size = new System.Drawing.Size(155, 22);
            this.labelPlateNumber.TabIndex = 2;
            this.labelPlateNumber.Text = "License plate num";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(468, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "*";
            // 
            // textBoxPlateNumber
            // 
            this.textBoxPlateNumber.Location = new System.Drawing.Point(296, 189);
            this.textBoxPlateNumber.Name = "textBoxPlateNumber";
            this.textBoxPlateNumber.Size = new System.Drawing.Size(199, 22);
            this.textBoxPlateNumber.TabIndex = 4;
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.labelPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurpose.Location = new System.Drawing.Point(292, 225);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(82, 22);
            this.labelPurpose.TabIndex = 5;
            this.labelPurpose.Text = "Purpose ";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(418, 301);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(177, 47);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Enter Portal";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonBackLanding
            // 
            this.buttonBackLanding.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonBackLanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackLanding.Location = new System.Drawing.Point(224, 301);
            this.buttonBackLanding.Name = "buttonBackLanding";
            this.buttonBackLanding.Size = new System.Drawing.Size(177, 47);
            this.buttonBackLanding.TabIndex = 7;
            this.buttonBackLanding.Text = "Back to Landing";
            this.buttonBackLanding.UseVisualStyleBackColor = false;
            this.buttonBackLanding.Click += new System.EventHandler(this.buttonBackLanding_Click);
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Location = new System.Drawing.Point(296, 250);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(199, 22);
            this.textBoxPurpose.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(123)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 357);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDriverLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPurpose);
            this.Controls.Add(this.buttonBackLanding);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.textBoxPlateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlateNumber);
            this.Controls.Add(this.label2);
            this.Name = "FormDriverLogin";
            this.Text = "FormDriverLogin";
            this.Load += new System.EventHandler(this.FormDriverLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Label labelPlateNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlateNumber;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonBackLanding;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.Label label2;
    }
}

