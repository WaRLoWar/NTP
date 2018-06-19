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
using System.Diagnostics.Tracing;
using Model;

namespace WinForm
{
    public partial class VehicleControl : UserControl
    {
        private IVehicle _vehicle;
        /// <summary>
        /// Сonstructor
        /// </summary>
        public VehicleControl()
        {            
            InitializeComponent();
            DefaultSettingVehicle();            
        }

        /// <summary>
        /// Default Setting
        /// </summary>
        private void DefaultSettingVehicle()
        {
            VisibilityControl();
            this.Size= new Size(280, 350);
            rbtn_Car.Checked = true;
            carControl_First.Visible = true;
            ReadOnly = true;           
            Point startLocation = carControl_First.Location;
            boatControl_First.Location = startLocation;
            helicopterControl_First.Location = startLocation;                       
        }

        /// <summary>
        /// Interaction with vehicle
        /// </summary>
        public IVehicle Vehicle
        {
            get => _vehicle;
            set
            {
                if (value == null) return;
                _vehicle = value;
                CheckVehicle(_vehicle);
            }
        }

        /// <summary>
        /// The current type of transport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            VisibilityControl();            
            if (rbtn_Car.Checked)
            {              
                carControl_First.Visible = true;                              
            }
            else if (rbtn_Boat.Checked)
            {               
                boatControl_First.Visible = true;             
            }
            else if (rbtn_Helicopter.Checked)
            {
                helicopterControl_First.Visible = true;     
            }               
        }


        /// <summary>
        /// Checking the received vehicle
        /// </summary>
        /// <param name="data"></param>
        private void CheckVehicle(IVehicle data)
        {
            switch (data)
            {
                case Car car:
                    rbtn_Car.Checked = true;
                    carControl_First.CarVehicle = car;
                    break;
                case Boat boat:
                    rbtn_Boat.Checked = true;
                    boatControl_First.BoatVehicle = boat;
                    break;
                case Helicopter helicopter:
                    rbtn_Helicopter.Checked = true;
                    helicopterControl_First.HelicopterVehicle = helicopter;
                    break;
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
            ((Form)this.TopLevelControl).DialogResult = DialogResult.Cancel;            
            ((Form)this.TopLevelControl)?.Close();
        }

        /// <summary>
        /// OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).DialogResult = DialogResult.OK;
            GetData();
            ((Form)this.TopLevelControl)?.Close();
        }

        #endregion Buttons

        /// <summary>
        /// Getting data from Control 
        /// </summary>
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
    }
}







