using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using Model;

namespace WinForm
{
    public partial class VehicleControl : UserControl
    {
        private DialogResult _result;

        public VehicleControl()
        {            
            InitializeComponent();
            DefaultSettingView();            
        }

        private void DefaultSettingView()
        {
            VisibilityControl();
            this.Size= new Size(280, 350);
            rbtn_Car.Checked = true;
            carControl_First.Visible = true;
            ReadOnly = false;           
            Point startLocation = carControl_First.Location;
            boatControl_First.Location = startLocation;
            helicopterControl_First.Location = startLocation;                       
        }


        public IVehicle Vehicle { get; set; }

        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            VisibilityControl();
            if (rbtn_Car.Checked)
            {                
                carControl_First.Visible = true;               
                carControl_First.CarVehicle = (Car)Vehicle;
            }
            else if (rbtn_Boat.Checked)
            {               
                boatControl_First.Visible = true;
                boatControl_First.BoatVehicle = (Boat) Vehicle;
            }
            else if (rbtn_Helicopter.Checked)
            {
                helicopterControl_First.Visible = true;
                helicopterControl_First.HelicopterVehicle = (Helicopter) Vehicle;
            }   
        }

        #region Management Control


        /// <summary>
        /// Hiding fields
        /// </summary>
        private void VisibilityControl()
        {
            carControl_First.Visible = false;
            boatControl_First.Visible = false;
            helicopterControl_First.Visible = false;
        }

        /// <summary>
        /// If 'true', all fields become 'ReadOnly'
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                btn_Cancel.Visible = !value;
                btn_OK.Visible = !value;
                gb_TypeVehicle.Enabled = !value;
                carControl_First.ReadOnly = value;
                boatControl_First.ReadOnly = value;
                helicopterControl_First.ReadOnly = value;
            }
        }

        #endregion Management Control

        #region Buttons

        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            ((Form)this.TopLevelControl)?.Close();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            GetData();
            ((Form)this.TopLevelControl)?.Close();
        }

        #endregion Buttons

        private void GetData()
        {
            if (rbtn_Car.Checked)
            {
                Vehicle = carControl_First.CarVehicle;
            }
            else if (rbtn_Boat.Checked)
            {
                Vehicle = boatControl_First.BoatVehicle;
            }
            else if (rbtn_Helicopter.Checked)
            {
                Vehicle = helicopterControl_First.HelicopterVehicle;
            }
        }

        //private void ClearFields()
        //{
        //    _tb_Name.Text = "";
        //    _tb_SerialNumber.Text = "";
        //    _tb_Cost.Text = "";
        //    _dtp_Date.Value = _dtp_Date.MaxDate;
        //    _tb_FirstPersonal.Text = "";
        //    _tb_SecondPersonal.Text = "";
        //    _tb_ThirdPersonal.Text = "";
        //}

    }
}



