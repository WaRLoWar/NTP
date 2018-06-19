namespace WinForm
{
    partial class CarControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.tb_FuelConsuption = new System.Windows.Forms.TextBox();
            this.tb_Power = new System.Windows.Forms.TextBox();
            this.l_FuelConsuption = new System.Windows.Forms.Label();
            this.l_Power = new System.Windows.Forms.Label();
            this.l_CarInterior = new System.Windows.Forms.Label();
            this.gb_Car = new System.Windows.Forms.GroupBox();
            this.gb_DistinctiveCharacteristic = new System.Windows.Forms.GroupBox();
            this.gb_General = new System.Windows.Forms.GroupBox();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.l_Cost = new System.Windows.Forms.Label();
            this.l_SerialNumber = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.tb_SerialNumber = new System.Windows.Forms.TextBox();
            this.l_ManufacturesYear = new System.Windows.Forms.Label();
            this.gb_Car.SuspendLayout();
            this.gb_DistinctiveCharacteristic.SuspendLayout();
            this.gb_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "Mini",
            "Sub",
            "Compact",
            "MidSize",
            "Large",
            "Null"});
            this.cb_Type.Location = new System.Drawing.Point(120, 19);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(125, 21);
            this.cb_Type.TabIndex = 5;
            // 
            // tb_FuelConsuption
            // 
            this.tb_FuelConsuption.Location = new System.Drawing.Point(120, 72);
            this.tb_FuelConsuption.Name = "tb_FuelConsuption";
            this.tb_FuelConsuption.Size = new System.Drawing.Size(125, 20);
            this.tb_FuelConsuption.TabIndex = 7;
            this.tb_FuelConsuption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_FuelConsuption_KeyPress);
            this.tb_FuelConsuption.Leave += new System.EventHandler(this.Tb_FuelConsuption_Leave);
            // 
            // tb_Power
            // 
            this.tb_Power.Location = new System.Drawing.Point(120, 46);
            this.tb_Power.Name = "tb_Power";
            this.tb_Power.Size = new System.Drawing.Size(125, 20);
            this.tb_Power.TabIndex = 6;
            this.tb_Power.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Power_KeyPress);
            this.tb_Power.Leave += new System.EventHandler(this.Tb_Power_Leave);
            // 
            // l_FuelConsuption
            // 
            this.l_FuelConsuption.AutoSize = true;
            this.l_FuelConsuption.Location = new System.Drawing.Point(11, 75);
            this.l_FuelConsuption.Name = "l_FuelConsuption";
            this.l_FuelConsuption.Size = new System.Drawing.Size(83, 13);
            this.l_FuelConsuption.TabIndex = 19;
            this.l_FuelConsuption.Text = "Fuel Consuption";
            // 
            // l_Power
            // 
            this.l_Power.AutoSize = true;
            this.l_Power.Location = new System.Drawing.Point(11, 49);
            this.l_Power.Name = "l_Power";
            this.l_Power.Size = new System.Drawing.Size(37, 13);
            this.l_Power.TabIndex = 1;
            this.l_Power.Text = "Power";
            // 
            // l_CarInterior
            // 
            this.l_CarInterior.AutoSize = true;
            this.l_CarInterior.Location = new System.Drawing.Point(11, 22);
            this.l_CarInterior.Name = "l_CarInterior";
            this.l_CarInterior.Size = new System.Drawing.Size(58, 13);
            this.l_CarInterior.TabIndex = 0;
            this.l_CarInterior.Text = "Car Interior";
            // 
            // gb_Car
            // 
            this.gb_Car.Controls.Add(this.gb_DistinctiveCharacteristic);
            this.gb_Car.Controls.Add(this.gb_General);
            this.gb_Car.Location = new System.Drawing.Point(3, 3);
            this.gb_Car.Name = "gb_Car";
            this.gb_Car.Size = new System.Drawing.Size(271, 257);
            this.gb_Car.TabIndex = 13;
            this.gb_Car.TabStop = false;
            // 
            // gb_DistinctiveCharacteristic
            // 
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_FuelConsuption);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_Power);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_FuelConsuption);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_CarInterior);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_Power);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.cb_Type);
            this.gb_DistinctiveCharacteristic.Location = new System.Drawing.Point(6, 148);
            this.gb_DistinctiveCharacteristic.Name = "gb_DistinctiveCharacteristic";
            this.gb_DistinctiveCharacteristic.Size = new System.Drawing.Size(258, 103);
            this.gb_DistinctiveCharacteristic.TabIndex = 5;
            this.gb_DistinctiveCharacteristic.TabStop = false;
            this.gb_DistinctiveCharacteristic.Text = "Distinctive Characteristic";
            // 
            // gb_General
            // 
            this.gb_General.Controls.Add(this.tb_Cost);
            this.gb_General.Controls.Add(this.dtp_Date);
            this.gb_General.Controls.Add(this.l_Cost);
            this.gb_General.Controls.Add(this.l_SerialNumber);
            this.gb_General.Controls.Add(this.tb_Name);
            this.gb_General.Controls.Add(this.l_Name);
            this.gb_General.Controls.Add(this.tb_SerialNumber);
            this.gb_General.Controls.Add(this.l_ManufacturesYear);
            this.gb_General.Location = new System.Drawing.Point(6, 9);
            this.gb_General.Name = "gb_General";
            this.gb_General.Size = new System.Drawing.Size(258, 133);
            this.gb_General.TabIndex = 1;
            this.gb_General.TabStop = false;
            this.gb_General.Text = "General";
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(120, 71);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(125, 20);
            this.tb_Cost.TabIndex = 3;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Cost_KeyPress);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(120, 97);
            this.dtp_Date.MaxDate = new System.DateTime(2018, 6, 3, 20, 28, 27, 0);
            this.dtp_Date.MinDate = new System.DateTime(1753, 1, 3, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(125, 20);
            this.dtp_Date.TabIndex = 4;
            this.dtp_Date.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // l_Cost
            // 
            this.l_Cost.AutoSize = true;
            this.l_Cost.Location = new System.Drawing.Point(11, 74);
            this.l_Cost.Name = "l_Cost";
            this.l_Cost.Size = new System.Drawing.Size(43, 13);
            this.l_Cost.TabIndex = 7;
            this.l_Cost.Text = "Cost ($)";
            // 
            // l_SerialNumber
            // 
            this.l_SerialNumber.AutoSize = true;
            this.l_SerialNumber.Location = new System.Drawing.Point(11, 48);
            this.l_SerialNumber.Name = "l_SerialNumber";
            this.l_SerialNumber.Size = new System.Drawing.Size(71, 13);
            this.l_SerialNumber.TabIndex = 6;
            this.l_SerialNumber.Text = "Serial number";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(120, 19);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(125, 20);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Name_KeyPress);
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(11, 22);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(35, 13);
            this.l_Name.TabIndex = 5;
            this.l_Name.Text = "Name";
            // 
            // tb_SerialNumber
            // 
            this.tb_SerialNumber.Location = new System.Drawing.Point(120, 45);
            this.tb_SerialNumber.Name = "tb_SerialNumber";
            this.tb_SerialNumber.Size = new System.Drawing.Size(125, 20);
            this.tb_SerialNumber.TabIndex = 2;
            this.tb_SerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_SerialNumber_KeyPress);
            this.tb_SerialNumber.Leave += new System.EventHandler(this.Tb_SerialNumber_Leave);
            // 
            // l_ManufacturesYear
            // 
            this.l_ManufacturesYear.AutoSize = true;
            this.l_ManufacturesYear.Location = new System.Drawing.Point(11, 103);
            this.l_ManufacturesYear.Name = "l_ManufacturesYear";
            this.l_ManufacturesYear.Size = new System.Drawing.Size(97, 13);
            this.l_ManufacturesYear.TabIndex = 8;
            this.l_ManufacturesYear.Text = "Manufactures Year";
            // 
            // CarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Car);
            this.Name = "CarControl";
            this.Size = new System.Drawing.Size(280, 267);
            this.gb_Car.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.PerformLayout();
            this.gb_General.ResumeLayout(false);
            this.gb_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox tb_FuelConsuption;
        private System.Windows.Forms.TextBox tb_Power;
        private System.Windows.Forms.Label l_FuelConsuption;
        private System.Windows.Forms.Label l_Power;
        private System.Windows.Forms.Label l_CarInterior;
        private System.Windows.Forms.GroupBox gb_Car;
        private System.Windows.Forms.GroupBox gb_DistinctiveCharacteristic;
        private System.Windows.Forms.GroupBox gb_General;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label l_Cost;
        private System.Windows.Forms.Label l_SerialNumber;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_SerialNumber;
        private System.Windows.Forms.Label l_ManufacturesYear;
    }
}
