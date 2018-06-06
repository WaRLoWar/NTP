namespace WinForm
{
    partial class SecondaryForm
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
            this.gb_AddForm = new System.Windows.Forms.GroupBox();
            this.gb_DistinctiveCharacteristic = new System.Windows.Forms.GroupBox();
            this.cb_FirstPersonal = new System.Windows.Forms.ComboBox();
            this.tb_ThirdPersonal = new System.Windows.Forms.TextBox();
            this.tb_SecondPersonal = new System.Windows.Forms.TextBox();
            this.tb_FirstPersonal = new System.Windows.Forms.TextBox();
            this.l_ThirdPersonal = new System.Windows.Forms.Label();
            this.l_SecondPersonal = new System.Windows.Forms.Label();
            this.l_FirstPersonal = new System.Windows.Forms.Label();
            this.gb_GeneralСharacteristic = new System.Windows.Forms.GroupBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.l_SerialNumber = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.l_Cost = new System.Windows.Forms.Label();
            this.l_ManufacturesYear = new System.Windows.Forms.Label();
            this.tb_SerialNumber = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.gb_TypeVehicle = new System.Windows.Forms.GroupBox();
            this.rbtn_Car = new System.Windows.Forms.RadioButton();
            this.rbtn_Boat = new System.Windows.Forms.RadioButton();
            this.rbtn_Helicopter = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.gb_AddForm.SuspendLayout();
            this.gb_DistinctiveCharacteristic.SuspendLayout();
            this.gb_GeneralСharacteristic.SuspendLayout();
            this.gb_TypeVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_AddForm
            // 
            this.gb_AddForm.Controls.Add(this.gb_DistinctiveCharacteristic);
            this.gb_AddForm.Controls.Add(this.gb_GeneralСharacteristic);
            this.gb_AddForm.Controls.Add(this.gb_TypeVehicle);
            this.gb_AddForm.Controls.Add(this.btn_Cancel);
            this.gb_AddForm.Controls.Add(this.btn_OK);
            this.gb_AddForm.Location = new System.Drawing.Point(12, 12);
            this.gb_AddForm.Name = "gb_AddForm";
            this.gb_AddForm.Size = new System.Drawing.Size(311, 354);
            this.gb_AddForm.TabIndex = 10;
            this.gb_AddForm.TabStop = false;
            // 
            // gb_DistinctiveCharacteristic
            // 
            this.gb_DistinctiveCharacteristic.Controls.Add(this.cb_FirstPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_ThirdPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_SecondPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.tb_FirstPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_ThirdPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_SecondPersonal);
            this.gb_DistinctiveCharacteristic.Controls.Add(this.l_FirstPersonal);
            this.gb_DistinctiveCharacteristic.Location = new System.Drawing.Point(6, 203);
            this.gb_DistinctiveCharacteristic.Name = "gb_DistinctiveCharacteristic";
            this.gb_DistinctiveCharacteristic.Size = new System.Drawing.Size(274, 104);
            this.gb_DistinctiveCharacteristic.TabIndex = 7;
            this.gb_DistinctiveCharacteristic.TabStop = false;
            this.gb_DistinctiveCharacteristic.Text = "Distinctive Characteristic";
            // 
            // cb_FirstPersonal
            // 
            this.cb_FirstPersonal.FormattingEnabled = true;
            this.cb_FirstPersonal.Items.AddRange(new object[] {
            "Mini",
            "Sub",
            "Compact",
            "MidSize",
            "Large",
            "NULL"});
            this.cb_FirstPersonal.Location = new System.Drawing.Point(246, 19);
            this.cb_FirstPersonal.Name = "cb_FirstPersonal";
            this.cb_FirstPersonal.Size = new System.Drawing.Size(24, 21);
            this.cb_FirstPersonal.TabIndex = 7;
            // 
            // tb_ThirdPersonal
            // 
            this.tb_ThirdPersonal.Location = new System.Drawing.Point(115, 71);
            this.tb_ThirdPersonal.Name = "tb_ThirdPersonal";
            this.tb_ThirdPersonal.Size = new System.Drawing.Size(125, 20);
            this.tb_ThirdPersonal.TabIndex = 9;
            this.tb_ThirdPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ThirdPersonal_KeyPress);
            this.tb_ThirdPersonal.Leave += new System.EventHandler(this.tb_ThirdPersonal_Leave);
            // 
            // tb_SecondPersonal
            // 
            this.tb_SecondPersonal.Location = new System.Drawing.Point(115, 45);
            this.tb_SecondPersonal.Name = "tb_SecondPersonal";
            this.tb_SecondPersonal.Size = new System.Drawing.Size(125, 20);
            this.tb_SecondPersonal.TabIndex = 8;
            this.tb_SecondPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SecondPersonal_KeyPress);
            this.tb_SecondPersonal.Leave += new System.EventHandler(this.tb_SecondPersonal_Leave);
            // 
            // tb_FirstPersonal
            // 
            this.tb_FirstPersonal.Location = new System.Drawing.Point(115, 19);
            this.tb_FirstPersonal.Name = "tb_FirstPersonal";
            this.tb_FirstPersonal.Size = new System.Drawing.Size(125, 20);
            this.tb_FirstPersonal.TabIndex = 7;
            this.tb_FirstPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FirstPersonal_KeyPress);
            this.tb_FirstPersonal.Leave += new System.EventHandler(this.tb_FirstPersonal_Leave);
            // 
            // l_ThirdPersonal
            // 
            this.l_ThirdPersonal.AutoSize = true;
            this.l_ThirdPersonal.Location = new System.Drawing.Point(6, 75);
            this.l_ThirdPersonal.Name = "l_ThirdPersonal";
            this.l_ThirdPersonal.Size = new System.Drawing.Size(31, 13);
            this.l_ThirdPersonal.TabIndex = 19;
            this.l_ThirdPersonal.Text = "Third";
            // 
            // l_SecondPersonal
            // 
            this.l_SecondPersonal.AutoSize = true;
            this.l_SecondPersonal.Location = new System.Drawing.Point(6, 51);
            this.l_SecondPersonal.Name = "l_SecondPersonal";
            this.l_SecondPersonal.Size = new System.Drawing.Size(44, 13);
            this.l_SecondPersonal.TabIndex = 1;
            this.l_SecondPersonal.Text = "Second";
            // 
            // l_FirstPersonal
            // 
            this.l_FirstPersonal.AutoSize = true;
            this.l_FirstPersonal.Location = new System.Drawing.Point(6, 25);
            this.l_FirstPersonal.Name = "l_FirstPersonal";
            this.l_FirstPersonal.Size = new System.Drawing.Size(26, 13);
            this.l_FirstPersonal.TabIndex = 0;
            this.l_FirstPersonal.Text = "First";
            // 
            // gb_GeneralСharacteristic
            // 
            this.gb_GeneralСharacteristic.Controls.Add(this.l_Name);
            this.gb_GeneralСharacteristic.Controls.Add(this.l_SerialNumber);
            this.gb_GeneralСharacteristic.Controls.Add(this.dtp_Date);
            this.gb_GeneralСharacteristic.Controls.Add(this.tb_Cost);
            this.gb_GeneralСharacteristic.Controls.Add(this.l_Cost);
            this.gb_GeneralСharacteristic.Controls.Add(this.l_ManufacturesYear);
            this.gb_GeneralСharacteristic.Controls.Add(this.tb_SerialNumber);
            this.gb_GeneralСharacteristic.Controls.Add(this.tb_Name);
            this.gb_GeneralСharacteristic.Location = new System.Drawing.Point(6, 73);
            this.gb_GeneralСharacteristic.Name = "gb_GeneralСharacteristic";
            this.gb_GeneralСharacteristic.Size = new System.Drawing.Size(274, 124);
            this.gb_GeneralСharacteristic.TabIndex = 3;
            this.gb_GeneralСharacteristic.TabStop = false;
            this.gb_GeneralСharacteristic.Text = "General";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(6, 22);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(35, 13);
            this.l_Name.TabIndex = 5;
            this.l_Name.Text = "Name";
            // 
            // l_SerialNumber
            // 
            this.l_SerialNumber.AutoSize = true;
            this.l_SerialNumber.Location = new System.Drawing.Point(6, 48);
            this.l_SerialNumber.Name = "l_SerialNumber";
            this.l_SerialNumber.Size = new System.Drawing.Size(71, 13);
            this.l_SerialNumber.TabIndex = 6;
            this.l_SerialNumber.Text = "Serial number";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(115, 97);
            this.dtp_Date.MaxDate = new System.DateTime(2018, 6, 3, 20, 28, 27, 0);
            this.dtp_Date.MinDate = new System.DateTime(1753, 1, 3, 0, 0, 0, 0);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(125, 20);
            this.dtp_Date.TabIndex = 6;
            this.dtp_Date.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(115, 71);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(125, 20);
            this.tb_Cost.TabIndex = 5;
            this.tb_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_KeyPress);
            // 
            // l_Cost
            // 
            this.l_Cost.AutoSize = true;
            this.l_Cost.Location = new System.Drawing.Point(6, 74);
            this.l_Cost.Name = "l_Cost";
            this.l_Cost.Size = new System.Drawing.Size(43, 13);
            this.l_Cost.TabIndex = 7;
            this.l_Cost.Text = "Cost ($)";
            // 
            // l_ManufacturesYear
            // 
            this.l_ManufacturesYear.AutoSize = true;
            this.l_ManufacturesYear.Location = new System.Drawing.Point(6, 100);
            this.l_ManufacturesYear.Name = "l_ManufacturesYear";
            this.l_ManufacturesYear.Size = new System.Drawing.Size(97, 13);
            this.l_ManufacturesYear.TabIndex = 8;
            this.l_ManufacturesYear.Text = "Manufactures Year";
            // 
            // tb_SerialNumber
            // 
            this.tb_SerialNumber.Location = new System.Drawing.Point(115, 45);
            this.tb_SerialNumber.Name = "tb_SerialNumber";
            this.tb_SerialNumber.Size = new System.Drawing.Size(125, 20);
            this.tb_SerialNumber.TabIndex = 4;
            this.tb_SerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SerialNumber_KeyPress);
            this.tb_SerialNumber.Leave += new System.EventHandler(this.tb_SerialNumber_Leave);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(115, 19);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(125, 20);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // gb_TypeVehicle
            // 
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Car);
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Boat);
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Helicopter);
            this.gb_TypeVehicle.Location = new System.Drawing.Point(6, 16);
            this.gb_TypeVehicle.Name = "gb_TypeVehicle";
            this.gb_TypeVehicle.Size = new System.Drawing.Size(190, 51);
            this.gb_TypeVehicle.TabIndex = 0;
            this.gb_TypeVehicle.TabStop = false;
            this.gb_TypeVehicle.Text = "Type Vehicle";
            // 
            // rbtn_Car
            // 
            this.rbtn_Car.AutoSize = true;
            this.rbtn_Car.Location = new System.Drawing.Point(6, 19);
            this.rbtn_Car.Name = "rbtn_Car";
            this.rbtn_Car.Size = new System.Drawing.Size(41, 17);
            this.rbtn_Car.TabIndex = 0;
            this.rbtn_Car.TabStop = true;
            this.rbtn_Car.Text = "Car";
            this.rbtn_Car.UseVisualStyleBackColor = true;
            this.rbtn_Car.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChange);
            // 
            // rbtn_Boat
            // 
            this.rbtn_Boat.AutoSize = true;
            this.rbtn_Boat.Location = new System.Drawing.Point(51, 19);
            this.rbtn_Boat.Name = "rbtn_Boat";
            this.rbtn_Boat.Size = new System.Drawing.Size(47, 17);
            this.rbtn_Boat.TabIndex = 1;
            this.rbtn_Boat.TabStop = true;
            this.rbtn_Boat.Text = "Boat";
            this.rbtn_Boat.UseVisualStyleBackColor = true;
            this.rbtn_Boat.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChange);
            // 
            // rbtn_Helicopter
            // 
            this.rbtn_Helicopter.AutoSize = true;
            this.rbtn_Helicopter.Location = new System.Drawing.Point(103, 19);
            this.rbtn_Helicopter.Name = "rbtn_Helicopter";
            this.rbtn_Helicopter.Size = new System.Drawing.Size(73, 17);
            this.rbtn_Helicopter.TabIndex = 2;
            this.rbtn_Helicopter.TabStop = true;
            this.rbtn_Helicopter.Text = "Helicopter";
            this.rbtn_Helicopter.UseVisualStyleBackColor = true;
            this.rbtn_Helicopter.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChange);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(88, 313);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(76, 30);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(6, 313);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(76, 30);
            this.btn_OK.TabIndex = 10;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 383);
            this.ControlBox = false;
            this.Controls.Add(this.gb_AddForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SecondaryForm";
            this.Text = "Add Vehicle";
            this.gb_AddForm.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.ResumeLayout(false);
            this.gb_DistinctiveCharacteristic.PerformLayout();
            this.gb_GeneralСharacteristic.ResumeLayout(false);
            this.gb_GeneralСharacteristic.PerformLayout();
            this.gb_TypeVehicle.ResumeLayout(false);
            this.gb_TypeVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_AddForm;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.RadioButton rbtn_Helicopter;
        private System.Windows.Forms.RadioButton rbtn_Boat;
        private System.Windows.Forms.RadioButton rbtn_Car;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label l_ManufacturesYear;
        private System.Windows.Forms.Label l_Cost;
        private System.Windows.Forms.Label l_SerialNumber;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.GroupBox gb_TypeVehicle;
        private System.Windows.Forms.TextBox tb_SerialNumber;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.GroupBox gb_DistinctiveCharacteristic;
        private System.Windows.Forms.GroupBox gb_GeneralСharacteristic;
        private System.Windows.Forms.Label l_ThirdPersonal;
        private System.Windows.Forms.Label l_SecondPersonal;
        private System.Windows.Forms.Label l_FirstPersonal;
        private System.Windows.Forms.TextBox tb_ThirdPersonal;
        private System.Windows.Forms.TextBox tb_SecondPersonal;
        private System.Windows.Forms.TextBox tb_FirstPersonal;
        private System.Windows.Forms.ComboBox cb_FirstPersonal;
    }
}