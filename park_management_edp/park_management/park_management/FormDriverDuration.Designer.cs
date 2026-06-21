using System;

namespace park_management
{
    partial class FormDriverDuration
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
            this.labelPlate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1H = new System.Windows.Forms.Button();
            this.button2H = new System.Windows.Forms.Button();
            this.button3H = new System.Windows.Forms.Button();
            this.button4H = new System.Windows.Forms.Button();
            this.labelCustomeHours = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.labelBaseFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.labelTotalHR = new System.Windows.Forms.Label();
            this.labelTotalPay = new System.Windows.Forms.Label();
            this.labelOutputTotalPay = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlate
            // 
            this.labelPlate.AutoSize = true;
            this.labelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlate.Location = new System.Drawing.Point(47, 24);
            this.labelPlate.Name = "labelPlate";
            this.labelPlate.Size = new System.Drawing.Size(199, 22);
            this.labelPlate.TabIndex = 0;
            this.labelPlate.Text = "License Number Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Parking Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "how long do you want to park? ";
            // 
            // button1H
            // 
            this.button1H.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1H.Location = new System.Drawing.Point(51, 117);
            this.button1H.Name = "button1H";
            this.button1H.Size = new System.Drawing.Size(144, 67);
            this.button1H.TabIndex = 3;
            this.button1H.Text = "1H";
            this.button1H.UseVisualStyleBackColor = true;
            this.button1H.Click += new System.EventHandler(this.button1H_Click);
            // 
            // button2H
            // 
            this.button2H.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2H.Location = new System.Drawing.Point(201, 117);
            this.button2H.Name = "button2H";
            this.button2H.Size = new System.Drawing.Size(144, 67);
            this.button2H.TabIndex = 4;
            this.button2H.Text = "2H";
            this.button2H.UseVisualStyleBackColor = true;
            this.button2H.Click += new System.EventHandler(this.button2H_Click);
            // 
            // button3H
            // 
            this.button3H.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3H.Location = new System.Drawing.Point(351, 117);
            this.button3H.Name = "button3H";
            this.button3H.Size = new System.Drawing.Size(144, 67);
            this.button3H.TabIndex = 5;
            this.button3H.Text = "3H";
            this.button3H.UseVisualStyleBackColor = true;
            this.button3H.Click += new System.EventHandler(this.button3H_Click);
            // 
            // button4H
            // 
            this.button4H.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4H.Location = new System.Drawing.Point(501, 117);
            this.button4H.Name = "button4H";
            this.button4H.Size = new System.Drawing.Size(144, 67);
            this.button4H.TabIndex = 6;
            this.button4H.Text = "4H";
            this.button4H.UseVisualStyleBackColor = true;
            this.button4H.Click += new System.EventHandler(this.button4H_Click);
            // 
            // labelCustomeHours
            // 
            this.labelCustomeHours.AutoSize = true;
            this.labelCustomeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomeHours.Location = new System.Drawing.Point(50, 198);
            this.labelCustomeHours.Name = "labelCustomeHours";
            this.labelCustomeHours.Size = new System.Drawing.Size(229, 18);
            this.labelCustomeHours.TabIndex = 7;
            this.labelCustomeHours.Text = "Need custom hours? Enter below";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(51, 219);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(121, 22);
            this.textBoxHours.TabIndex = 8;
            this.textBoxHours.TextChanged += new System.EventHandler(this.textBoxHours_TextChanged);
            // 
            // labelBaseFee
            // 
            this.labelBaseFee.AutoSize = true;
            this.labelBaseFee.BackColor = System.Drawing.Color.White;
            this.labelBaseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseFee.Location = new System.Drawing.Point(50, 263);
            this.labelBaseFee.Name = "labelBaseFee";
            this.labelBaseFee.Size = new System.Drawing.Size(201, 18);
            this.labelBaseFee.TabIndex = 9;
            this.labelBaseFee.Text = "output Base fee (vehicle type)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "output Hours x Rate\r\n";
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.BackColor = System.Drawing.Color.White;
            this.labelTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFee.Location = new System.Drawing.Point(563, 263);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(112, 18);
            this.labelTotalFee.TabIndex = 11;
            this.labelTotalFee.Text = "output BaseFee";
            this.labelTotalFee.Click += new System.EventHandler(this.labelTotalFee_Click);
            // 
            // labelTotalHR
            // 
            this.labelTotalHR.AutoSize = true;
            this.labelTotalHR.BackColor = System.Drawing.Color.White;
            this.labelTotalHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHR.Location = new System.Drawing.Point(563, 290);
            this.labelTotalHR.Name = "labelTotalHR";
            this.labelTotalHR.Size = new System.Drawing.Size(112, 18);
            this.labelTotalHR.TabIndex = 12;
            this.labelTotalHR.Text = "output Total HR";
            this.labelTotalHR.Click += new System.EventHandler(this.labelTotalHR_Click);
            // 
            // labelTotalPay
            // 
            this.labelTotalPay.AutoSize = true;
            this.labelTotalPay.BackColor = System.Drawing.Color.White;
            this.labelTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPay.Location = new System.Drawing.Point(50, 331);
            this.labelTotalPay.Name = "labelTotalPay";
            this.labelTotalPay.Size = new System.Drawing.Size(107, 22);
            this.labelTotalPay.TabIndex = 13;
            this.labelTotalPay.Text = "Total to Pay";
            this.labelTotalPay.Click += new System.EventHandler(this.labelTotalPay_Click);
            // 
            // labelOutputTotalPay
            // 
            this.labelOutputTotalPay.AutoSize = true;
            this.labelOutputTotalPay.BackColor = System.Drawing.Color.White;
            this.labelOutputTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputTotalPay.Location = new System.Drawing.Point(605, 331);
            this.labelOutputTotalPay.Name = "labelOutputTotalPay";
            this.labelOutputTotalPay.Size = new System.Drawing.Size(142, 22);
            this.labelOutputTotalPay.TabIndex = 14;
            this.labelOutputTotalPay.Text = "output Total Pay";
            this.labelOutputTotalPay.Click += new System.EventHandler(this.labelOutputTotalPay_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Green;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirm.Location = new System.Drawing.Point(54, 374);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(696, 66);
            this.buttonConfirm.TabIndex = 15;
            this.buttonConfirm.Text = "Confirm - proceed to pay";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(706, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(708, 114);
            this.label4.TabIndex = 17;
            // 
            // labelRM
            // 
            this.labelRM.AutoSize = true;
            this.labelRM.BackColor = System.Drawing.Color.White;
            this.labelRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRM.Location = new System.Drawing.Point(562, 331);
            this.labelRM.Name = "labelRM";
            this.labelRM.Size = new System.Drawing.Size(37, 22);
            this.labelRM.TabIndex = 18;
            this.labelRM.Text = "RM";
            // 
            // FormDriverDuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelOutputTotalPay);
            this.Controls.Add(this.labelTotalPay);
            this.Controls.Add(this.labelTotalHR);
            this.Controls.Add(this.labelTotalFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBaseFee);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.labelCustomeHours);
            this.Controls.Add(this.button4H);
            this.Controls.Add(this.button3H);
            this.Controls.Add(this.button2H);
            this.Controls.Add(this.button1H);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlate);
            this.Controls.Add(this.label4);
            this.Name = "FormDriverDuration";
            this.Text = "FormDriverDuration";
            this.Load += new System.EventHandler(this.FormDriverDuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelTotalFee_Click(object sender, EventArgs e)
        {
        }

        private void labelTotalHR_Click(object sender, EventArgs e)
        {
        }

        private void labelTotalPay_Click(object sender, EventArgs e)
        {
        }

        private void labelOutputTotalPay_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label labelPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1H;
        private System.Windows.Forms.Button button2H;
        private System.Windows.Forms.Button button3H;
        private System.Windows.Forms.Button button4H;
        private System.Windows.Forms.Label labelCustomeHours;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.Label labelBaseFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelTotalHR;
        private System.Windows.Forms.Label labelTotalPay;
        private System.Windows.Forms.Label labelOutputTotalPay;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRM;
    }
}