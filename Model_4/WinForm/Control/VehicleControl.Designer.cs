namespace WinForm
{
    partial class VehicleControl
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
            this.gb_TypeVehicle = new System.Windows.Forms.GroupBox();
            this.rbtn_Car = new System.Windows.Forms.RadioButton();
            this.rbtn_Boat = new System.Windows.Forms.RadioButton();
            this.rbtn_Helicopter = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.helicopterControl_First = new WinForm.HelicopterControl();
            this.boatControl_First = new WinForm.BoatControl();
            this.carControl_First = new WinForm.CarControl();
            this.gb_TypeVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TypeVehicle
            // 
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Car);
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Boat);
            this.gb_TypeVehicle.Controls.Add(this.rbtn_Helicopter);
            this.gb_TypeVehicle.Location = new System.Drawing.Point(3, 3);
            this.gb_TypeVehicle.Name = "gb_TypeVehicle";
            this.gb_TypeVehicle.Size = new System.Drawing.Size(190, 49);
            this.gb_TypeVehicle.TabIndex = 1;
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
            this.rbtn_Car.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChange);
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
            this.rbtn_Boat.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChange);
            // 
            // rbtn_Helicopter
            // 
            this.rbtn_Helicopter.AutoSize = true;
            this.rbtn_Helicopter.Location = new System.Drawing.Point(104, 19);
            this.rbtn_Helicopter.Name = "rbtn_Helicopter";
            this.rbtn_Helicopter.Size = new System.Drawing.Size(73, 17);
            this.rbtn_Helicopter.TabIndex = 2;
            this.rbtn_Helicopter.TabStop = true;
            this.rbtn_Helicopter.Text = "Helicopter";
            this.rbtn_Helicopter.UseVisualStyleBackColor = true;
            this.rbtn_Helicopter.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChange);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(9, 319);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(110, 25);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(154, 319);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 25);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // helicopterControl_First
            // 
           
            this.helicopterControl_First.Location = new System.Drawing.Point(280, 319);
            this.helicopterControl_First.Name = "helicopterControl_First";
            this.helicopterControl_First.Size = new System.Drawing.Size(277, 261);
            this.helicopterControl_First.TabIndex = 4;
            // 
            // boatControl_First
            // 
           
            this.boatControl_First.Location = new System.Drawing.Point(283, 52);
            this.boatControl_First.Name = "boatControl_First";
            this.boatControl_First.Size = new System.Drawing.Size(277, 261);
            this.boatControl_First.TabIndex = 3;
            // 
            // carControl_First
            // 
          
            this.carControl_First.Location = new System.Drawing.Point(0, 52);
            this.carControl_First.Name = "carControl_First";
            this.carControl_First.Size = new System.Drawing.Size(277, 261);
            this.carControl_First.TabIndex = 2;
            // 
            // VehicleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.helicopterControl_First);
            this.Controls.Add(this.boatControl_First);
            this.Controls.Add(this.carControl_First);
            this.Controls.Add(this.gb_TypeVehicle);
            this.Name = "VehicleControl";
            this.Size = new System.Drawing.Size(560, 591);
            this.gb_TypeVehicle.ResumeLayout(false);
            this.gb_TypeVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TypeVehicle;
        private System.Windows.Forms.RadioButton rbtn_Car;
        private System.Windows.Forms.RadioButton rbtn_Boat;
        private System.Windows.Forms.RadioButton rbtn_Helicopter;
        private CarControl carControl_First;
        private BoatControl boatControl_First;
        private HelicopterControl helicopterControl_First;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
