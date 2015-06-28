namespace AutoParking.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miCatalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.miClients = new System.Windows.Forms.ToolStripMenuItem();
            this.miInflations = new System.Windows.Forms.ToolStripMenuItem();
            this.miParking = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.msMain.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miParking,
            this.miCatalogs,
            this.miAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(675, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // miCatalogs
            // 
            this.miCatalogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClients,
            this.miInflations});
            this.miCatalogs.Name = "miCatalogs";
            this.miCatalogs.Size = new System.Drawing.Size(94, 20);
            this.miCatalogs.Text = "Справочники";
            // 
            // miClients
            // 
            this.miClients.Name = "miClients";
            this.miClients.Size = new System.Drawing.Size(152, 22);
            this.miClients.Text = "Клиенты";
            // 
            // miInflations
            // 
            this.miInflations.Name = "miInflations";
            this.miInflations.Size = new System.Drawing.Size(152, 22);
            this.miInflations.Text = "Инфляция";
            // 
            // miParking
            // 
            this.miParking.Name = "miParking";
            this.miParking.Size = new System.Drawing.Size(64, 20);
            this.miParking.Text = "Стоянка";
            this.miParking.Click += new System.EventHandler(this.button1_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(94, 20);
            this.miAbout.Text = "О программе";
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(675, 44);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 315);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(675, 56);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgwOrders);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 68);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(675, 247);
            this.pnlData.TabIndex = 3;
            // 
            // dgwOrders
            // 
            this.dgwOrders.AllowUserToAddRows = false;
            this.dgwOrders.AllowUserToDeleteRows = false;
            this.dgwOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwOrders.Location = new System.Drawing.Point(0, 0);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.ReadOnly = true;
            this.dgwOrders.Size = new System.Drawing.Size(675, 247);
            this.dgwOrders.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 371);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АС \"Платная стоянка\"";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miParking;
        private System.Windows.Forms.ToolStripMenuItem miCatalogs;
        private System.Windows.Forms.ToolStripMenuItem miClients;
        private System.Windows.Forms.ToolStripMenuItem miInflations;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgwOrders;

    }
}

