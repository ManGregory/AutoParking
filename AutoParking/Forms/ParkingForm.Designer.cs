namespace AutoParking.Forms
{
    partial class ParkingForm
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReserve = new System.Windows.Forms.Label();
            this.lblBusy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFree = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOnceOnly = new System.Windows.Forms.Label();
            this.lblEconom = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblVip = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edToDate = new System.Windows.Forms.DateTimePicker();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.edToHour = new System.Windows.Forms.NumericUpDown();
            this.edFromHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edFromDate = new System.Windows.Forms.DateTimePicker();
            this.pnlParking = new System.Windows.Forms.Panel();
            this.grpLegend = new System.Windows.Forms.GroupBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.edCost = new System.Windows.Forms.NumericUpDown();
            this.edInflation = new System.Windows.Forms.NumericUpDown();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFromHour)).BeginInit();
            this.grpLegend.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInflation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.grpInfo);
            this.pnlBottom.Controls.Add(this.grpLegend);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 524);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(818, 93);
            this.pnlBottom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Забронировано";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Занято";
            // 
            // lblReserve
            // 
            this.lblReserve.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblReserve.Location = new System.Drawing.Point(103, 47);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(20, 20);
            this.lblReserve.TabIndex = 11;
            // 
            // lblBusy
            // 
            this.lblBusy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBusy.Location = new System.Drawing.Point(229, 47);
            this.lblBusy.Name = "lblBusy";
            this.lblBusy.Size = new System.Drawing.Size(20, 20);
            this.lblBusy.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Свободно";
            // 
            // lblFree
            // 
            this.lblFree.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFree.Location = new System.Drawing.Point(7, 47);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(20, 20);
            this.lblFree.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 14);
            this.label13.TabIndex = 7;
            this.label13.Text = "Разовые";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 6;
            this.label12.Text = "Эконом";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "Средний";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "VIP";
            // 
            // lblOnceOnly
            // 
            this.lblOnceOnly.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOnceOnly.Location = new System.Drawing.Point(332, 18);
            this.lblOnceOnly.Name = "lblOnceOnly";
            this.lblOnceOnly.Size = new System.Drawing.Size(20, 20);
            this.lblOnceOnly.TabIndex = 3;
            // 
            // lblEconom
            // 
            this.lblEconom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEconom.Location = new System.Drawing.Point(102, 18);
            this.lblEconom.Name = "lblEconom";
            this.lblEconom.Size = new System.Drawing.Size(20, 20);
            this.lblEconom.TabIndex = 2;
            // 
            // lblMiddle
            // 
            this.lblMiddle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMiddle.Location = new System.Drawing.Point(228, 18);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(20, 20);
            this.lblMiddle.TabIndex = 1;
            // 
            // lblVip
            // 
            this.lblVip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVip.Location = new System.Drawing.Point(6, 18);
            this.lblVip.Name = "lblVip";
            this.lblVip.Size = new System.Drawing.Size(20, 20);
            this.lblVip.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.edToDate);
            this.pnlTop.Controls.Add(this.chkDate);
            this.pnlTop.Controls.Add(this.edToHour);
            this.pnlTop.Controls.Add(this.edFromHour);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.edFromDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(818, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "по";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "с";
            // 
            // edToDate
            // 
            this.edToDate.Location = new System.Drawing.Point(386, 9);
            this.edToDate.Name = "edToDate";
            this.edToDate.Size = new System.Drawing.Size(142, 22);
            this.edToDate.TabIndex = 7;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(13, 14);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(15, 14);
            this.chkDate.TabIndex = 6;
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // edToHour
            // 
            this.edToHour.Location = new System.Drawing.Point(666, 9);
            this.edToHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.edToHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edToHour.Name = "edToHour";
            this.edToHour.Size = new System.Drawing.Size(83, 22);
            this.edToHour.TabIndex = 5;
            this.edToHour.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // edFromHour
            // 
            this.edFromHour.Location = new System.Drawing.Point(550, 9);
            this.edFromHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.edFromHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edFromHour.Name = "edFromHour";
            this.edFromHour.Size = new System.Drawing.Size(83, 22);
            this.edFromHour.TabIndex = 4;
            this.edFromHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "по";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата и время актуальности";
            // 
            // edFromDate
            // 
            this.edFromDate.Location = new System.Drawing.Point(213, 9);
            this.edFromDate.Name = "edFromDate";
            this.edFromDate.Size = new System.Drawing.Size(142, 22);
            this.edFromDate.TabIndex = 0;
            // 
            // pnlParking
            // 
            this.pnlParking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParking.Location = new System.Drawing.Point(0, 40);
            this.pnlParking.Name = "pnlParking";
            this.pnlParking.Size = new System.Drawing.Size(818, 484);
            this.pnlParking.TabIndex = 2;
            this.pnlParking.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlParking_Paint);
            // 
            // grpLegend
            // 
            this.grpLegend.Controls.Add(this.lblVip);
            this.grpLegend.Controls.Add(this.label9);
            this.grpLegend.Controls.Add(this.label8);
            this.grpLegend.Controls.Add(this.lblBusy);
            this.grpLegend.Controls.Add(this.lblEconom);
            this.grpLegend.Controls.Add(this.label13);
            this.grpLegend.Controls.Add(this.label10);
            this.grpLegend.Controls.Add(this.label11);
            this.grpLegend.Controls.Add(this.lblReserve);
            this.grpLegend.Controls.Add(this.lblOnceOnly);
            this.grpLegend.Controls.Add(this.label12);
            this.grpLegend.Controls.Add(this.lblMiddle);
            this.grpLegend.Controls.Add(this.label6);
            this.grpLegend.Controls.Add(this.lblFree);
            this.grpLegend.Location = new System.Drawing.Point(3, 5);
            this.grpLegend.Name = "grpLegend";
            this.grpLegend.Size = new System.Drawing.Size(423, 77);
            this.grpLegend.TabIndex = 14;
            this.grpLegend.TabStop = false;
            this.grpLegend.Text = "Описание";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.edInflation);
            this.grpInfo.Controls.Add(this.edCost);
            this.grpInfo.Controls.Add(this.label19);
            this.grpInfo.Controls.Add(this.label25);
            this.grpInfo.Location = new System.Drawing.Point(432, 5);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(373, 77);
            this.grpInfo.TabIndex = 15;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Информация о стоянке";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 14);
            this.label19.TabIndex = 4;
            this.label19.Text = "Себестоимость";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 14);
            this.label25.TabIndex = 9;
            this.label25.Text = "Коэффициент инфляции";
            // 
            // edCost
            // 
            this.edCost.DecimalPlaces = 2;
            this.edCost.Location = new System.Drawing.Point(175, 16);
            this.edCost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edCost.Name = "edCost";
            this.edCost.Size = new System.Drawing.Size(120, 22);
            this.edCost.TabIndex = 10;
            this.edCost.ValueChanged += new System.EventHandler(this.edCost_ValueChanged);
            // 
            // edInflation
            // 
            this.edInflation.DecimalPlaces = 2;
            this.edInflation.Enabled = false;
            this.edInflation.Location = new System.Drawing.Point(175, 45);
            this.edInflation.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.edInflation.Name = "edInflation";
            this.edInflation.Size = new System.Drawing.Size(120, 22);
            this.edInflation.TabIndex = 11;
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 617);
            this.Controls.Add(this.pnlParking);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParkingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоянка";
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFromHour)).EndInit();
            this.grpLegend.ResumeLayout(false);
            this.grpLegend.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edInflation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlParking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker edFromDate;
        private System.Windows.Forms.NumericUpDown edFromHour;
        private System.Windows.Forms.NumericUpDown edToHour;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker edToDate;
        private System.Windows.Forms.Label lblEconom;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblVip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOnceOnly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReserve;
        private System.Windows.Forms.Label lblBusy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.GroupBox grpLegend;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown edInflation;
        private System.Windows.Forms.NumericUpDown edCost;
    }
}