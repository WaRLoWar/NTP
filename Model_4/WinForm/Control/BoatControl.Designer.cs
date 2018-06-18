namespace WinForm
{
    partial class BoatControl
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
            this.tb_Speed = new System.Windows.Forms.TextBox();
            this.l_BoatCapacity = new System.Windows.Forms.Label();
            this.tb_BoatCapacity = new System.Windows.Forms.TextBox();
            this.l_Draft = new System.Windows.Forms.Label();
            this.tb_Draft = new System.Windows.Forms.TextBox();
            this.l_Speed = new System.Windows.Forms.Label();
            this.gb_Boat = new System.Windows.Forms.GroupBox();
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
            this.gb_Boat.SuspendLayout();
            this.gb_DistinctiveCharacteristic.SuspendLayout();
            this.gb_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Speed
            // 
            this.tb_Speed.Location = new System.Drawing.Point(120, 19);
            this.tb_Speed.Name = "tb_Speed";
            this.tb_Speed.Size = new System.Drawing.Size(125, 20);
            this.tb_Speed.TabIndex = 20;
            this.tb_Speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Speed_KeyPress);
            this.tb_Speed.Leave += new System.EventHandler(this.Tb_Speed_Leave);
            // 
            // l_BoatCapacity
            // 
            this.l_BoatCapacity.AutoSize = true;
            this.l_BoatCapacity.Location = new System.Drawing.Point(11, 75);
            this.l_BoatCapacity.Name = "l_BoatCapacity";
            this.l_BoatCapacity.Size = new System.Drawing.Size(73, 13);
            this.l_BoatCapacity.TabIndex = 19;
            this.l_BoatCapacity.Text = "Boat Capacity";
            // 
            // tb_BoatCapacity
            // 
            this.tb_BoatCapacity.Location = new System.Drawing.Point(120, 72);
            this.tb_BoatCapacity.Name = "tb_BoatCapacity";
            this.tb_BoatCapacity.Size = new System.Drawing.Size(125, 20);
            this.tb_BoatCapacity.TabIndex = 9;
            this.tb_BoatCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_BoatCapacity_KeyPress);
            this.tb_BoatCapacity.Leave += new System.EventHandler(this.Tb_BoatCapacity_Leave);
            // 
            // l_Draft
            // 
            this.l_Draft.AutoSize = true;
            this.l_Draft.Location = new System.Drawing.Point(11, 49);
            this.l_Draft.Name = "l_Draft";
            this.l_Draft.Size = new System.Drawing.Size(30, 13);
            this.l_Draft.TabIndex = 1;
            this.l_Draft.Text = "Draft";
            // 
            // tb_Draft
            // 
            this.tb_Draft.Location = new System.Drawing.Point(120, 46);
            this.tb_Draft.Name = "tb_Draft";
            this.tb_Draft.Size = new System.Drawing.Size(125, 20);
            this.tb_Draft.TabIndex = 8;
            this.tb_Draft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Draft_KeyPress);
            this.tb_Draft.Leave += new System.EventHandler(this.Tb_Draft_Leave);
            // 
            // l_Speed
            // 
            this.l_Speed.AutoSize = true;
            this.l_Speed.Location = new System.Drawing.Point(11, 22);
            this.l_Speed.Name = "l_Speed";
            this.l_Speed.Size = new System.Drawing.Size(38, 13);
            this.l_Speed.TabIndex = 0;
            this.l_Speed.Text = "Speed";
            // 
            // gb_Boat
            // 
            this.gb_Boat.Controls.Add(this.gb_DistinctiveCharacteristic);
            this.gb_Boat.Controls.Add(this.gb_General);
            this.gb_Boat.Location = new System.Drawing.Point(3, 3);
            this.gb_Boat.Name = "gb_Boat";
            this.gb_Boat.Size = new System.Drawing.Size(271, 257);
            this.gb_Boat.TabIndex = 12;
            this.gb_Boat.TabStop = false;
            // 
            // gb_DistinctiveCharacteristic
            // 
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_Speed);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_Speed);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_BoatCapacity);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_Draft);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_BoatCapacity);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_Draft);
            this.gb_DistinctiveCharacteristic.Location = new System.Drawing.Point(6, 148);
            this.gb_DistinctiveCharacteristic.Name = "gb_DistinctiveCharacteristic";
            this.gb_DistinctiveCharacteristic.Size = new System.Drawing.Size(258, 103);
            this.gb_DistinctiveCharacteristic.TabIndex = 13;
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
            this.gb_General.TabIndex = 12;
            this.gb_General.TabStop = false;
            this.gb_General.Text = "General";
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(120, 71);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(125, 20);
            this.tb_Cost.TabIndex = 5;
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
            this.dtp_Date.TabIndex = 6;
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
            this.tb_Name.TabIndex = 3;
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
            this.tb_SerialNumber.TabIndex = 4;
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
            // BoatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Boat);
            this.Name = "BoatControl";
            this.Size = new System.Drawing.Size(280, 267);
            this.gb_Boat.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.PerformLayout();
            this.gb_General.ResumeLayout(false);
            this.gb_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label l_BoatCapacity;
        private System.Windows.Forms.TextBox tb_BoatCapacity;
        private System.Windows.Forms.Label l_Draft;
        private System.Windows.Forms.TextBox tb_Draft;
        private System.Windows.Forms.Label l_Speed;
        private System.Windows.Forms.TextBox tb_Speed;
        private System.Windows.Forms.GroupBox gb_Boat;
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
