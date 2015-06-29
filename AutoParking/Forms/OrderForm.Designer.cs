namespace AutoParking.Forms
{
    partial class OrderForm
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edFromDate = new System.Windows.Forms.DateTimePicker();
            this.edToDate = new System.Windows.Forms.DateTimePicker();
            this.edFactDate = new System.Windows.Forms.DateTimePicker();
            this.cmbParkingPlaceTypes = new System.Windows.Forms.ComboBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.edMustPay = new System.Windows.Forms.NumericUpDown();
            this.edPay = new System.Windows.Forms.NumericUpDown();
            this.lblParkingPlace = new System.Windows.Forms.Label();
            this.rbReserve = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.pnlBottom.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMustPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 319);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(378, 58);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.rbRent);
            this.pnlData.Controls.Add(this.rbReserve);
            this.pnlData.Controls.Add(this.lblParkingPlace);
            this.pnlData.Controls.Add(this.edPay);
            this.pnlData.Controls.Add(this.edMustPay);
            this.pnlData.Controls.Add(this.edRate);
            this.pnlData.Controls.Add(this.cmbClients);
            this.pnlData.Controls.Add(this.cmbParkingPlaceTypes);
            this.pnlData.Controls.Add(this.edFactDate);
            this.pnlData.Controls.Add(this.edToDate);
            this.pnlData.Controls.Add(this.edFromDate);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(378, 319);
            this.pnlData.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(199, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата въезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата выезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фактическая дата выезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип стояночного места";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Тариф";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "К оплате";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Оплачено";
            // 
            // edFromDate
            // 
            this.edFromDate.Location = new System.Drawing.Point(175, 5);
            this.edFromDate.Name = "edFromDate";
            this.edFromDate.Size = new System.Drawing.Size(186, 22);
            this.edFromDate.TabIndex = 2;
            // 
            // edToDate
            // 
            this.edToDate.Location = new System.Drawing.Point(175, 35);
            this.edToDate.Name = "edToDate";
            this.edToDate.Size = new System.Drawing.Size(186, 22);
            this.edToDate.TabIndex = 10;
            // 
            // edFactDate
            // 
            this.edFactDate.Location = new System.Drawing.Point(175, 65);
            this.edFactDate.Name = "edFactDate";
            this.edFactDate.Size = new System.Drawing.Size(186, 22);
            this.edFactDate.TabIndex = 11;
            // 
            // cmbParkingPlaceTypes
            // 
            this.cmbParkingPlaceTypes.FormattingEnabled = true;
            this.cmbParkingPlaceTypes.Location = new System.Drawing.Point(175, 126);
            this.cmbParkingPlaceTypes.Name = "cmbParkingPlaceTypes";
            this.cmbParkingPlaceTypes.Size = new System.Drawing.Size(186, 22);
            this.cmbParkingPlaceTypes.TabIndex = 12;
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(175, 95);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(186, 22);
            this.cmbClients.TabIndex = 13;
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(175, 227);
            this.edRate.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(186, 22);
            this.edRate.TabIndex = 14;
            // 
            // edMustPay
            // 
            this.edMustPay.DecimalPlaces = 2;
            this.edMustPay.Location = new System.Drawing.Point(175, 255);
            this.edMustPay.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.edMustPay.Name = "edMustPay";
            this.edMustPay.Size = new System.Drawing.Size(186, 22);
            this.edMustPay.TabIndex = 15;
            // 
            // edPay
            // 
            this.edPay.DecimalPlaces = 2;
            this.edPay.Location = new System.Drawing.Point(175, 284);
            this.edPay.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.edPay.Name = "edPay";
            this.edPay.Size = new System.Drawing.Size(186, 22);
            this.edPay.TabIndex = 16;
            // 
            // lblParkingPlace
            // 
            this.lblParkingPlace.AutoSize = true;
            this.lblParkingPlace.Location = new System.Drawing.Point(12, 197);
            this.lblParkingPlace.Name = "lblParkingPlace";
            this.lblParkingPlace.Size = new System.Drawing.Size(143, 14);
            this.lblParkingPlace.TabIndex = 17;
            this.lblParkingPlace.Text = "Тип стояночного места";
            // 
            // rbReserve
            // 
            this.rbReserve.AutoSize = true;
            this.rbReserve.Location = new System.Drawing.Point(15, 162);
            this.rbReserve.Name = "rbReserve";
            this.rbReserve.Size = new System.Drawing.Size(59, 18);
            this.rbReserve.TabIndex = 18;
            this.rbReserve.Text = "Бронь";
            this.rbReserve.UseVisualStyleBackColor = true;
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Checked = true;
            this.rbRent.Location = new System.Drawing.Point(175, 162);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(67, 18);
            this.rbRent.TabIndex = 19;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Аренда";
            this.rbRent.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 377);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка";
            this.pnlBottom.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMustPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ComboBox cmbParkingPlaceTypes;
        private System.Windows.Forms.DateTimePicker edFactDate;
        private System.Windows.Forms.DateTimePicker edToDate;
        private System.Windows.Forms.DateTimePicker edFromDate;
        private System.Windows.Forms.NumericUpDown edPay;
        private System.Windows.Forms.NumericUpDown edMustPay;
        private System.Windows.Forms.Label lblParkingPlace;
        private System.Windows.Forms.RadioButton rbReserve;
        private System.Windows.Forms.RadioButton rbRent;
    }
}