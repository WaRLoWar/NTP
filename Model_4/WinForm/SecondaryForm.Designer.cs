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
            this.vehicleControl_SecondForm = new WinForm.VehicleControl();
            this.SuspendLayout();
            // 
            // vehicleControl_SecondForm
            // 
            this.vehicleControl_SecondForm.Location = new System.Drawing.Point(11, 12);
            this.vehicleControl_SecondForm.Name = "vehicleControl_SecondForm";
            //this.vehicleControl_SecondForm.Result = System.Windows.Forms.DialogResult.None;
            this.vehicleControl_SecondForm.Size = new System.Drawing.Size(280, 350);
            this.vehicleControl_SecondForm.TabIndex = 0;
            //this.vehicleControl_SecondForm.Vehicle = null;
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 368);
            this.ControlBox = false;
            this.Controls.Add(this.vehicleControl_SecondForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SecondaryForm";
            this.Text = "Add Vehicle";
            this.ResumeLayout(false);

        }

        #endregion

        private VehicleControl vehicleControl_SecondForm;
    }
}