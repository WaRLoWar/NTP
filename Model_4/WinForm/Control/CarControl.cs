using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinForm
{
    public partial class CarControl : UserControl
    {     
        /// <summary>
        /// Constructor
        /// </summary>
        public CarControl()
        {
            InitializeComponent();           
            DefaultSettingCar();
        }

        /// <summary>
        /// Default Setting
        /// </summary>
        private void DefaultSettingCar()
        {
            tb_Name.MaxLength = 25;
            tb_Cost.MaxLength = 12;
            tb_SerialNumber.MaxLength = 17;
            dtp_Date.MaxDate = DateTime.Today;
            dtp_Date.Value = DateTime.Today;
            dtp_Date.MinDate = new DateTime(1900,01,01);
            cb_Type.Text = @"Null";
            cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            tb_Power.MaxLength = 3;
            tb_FuelConsuption.MaxLength = 2;         
            SettingTab();
        }

        /// <summary>
        /// Prohibition of interaction via 'Tab'
        /// </summary>
        private void SettingTab()
        {
            l_Name.TabStop = false;
            l_CarInterior.TabStop = false;
            l_Cost.TabStop = false;
            l_FuelConsuption.TabStop = false;
            l_ManufacturesYear.TabStop = false;
            l_Power.TabStop = false;
            l_SerialNumber.TabStop = false;
        }
        /// <summary>
        /// Interaction with the class 'Car'
        /// </summary>
        public Car CarVehicle
        {
            get
            {
                if (IsBlankSheet())
                {
                    return null; 
                }
                Car dataCar = new Car();
                dataCar.TypeVehicle = "Car";
                dataCar.Name = tb_Name.Text;  
                dataCar.SerialNumber = tb_SerialNumber.Text;      
                dataCar.Cost = Convert.ToDouble(tb_Cost.Text);
                dataCar.ManufacturesYear = InputValidation.CheckDateTime(dtp_Date.Value);
                dataCar.Type = cb_Type.Text;
                dataCar.Power = Convert.ToDouble(tb_Power.Text);
                dataCar.Consumption = Convert.ToDouble(tb_FuelConsuption.Text);
                return dataCar;
            }
            set
            {
                if (value != null)
                {
                    tb_Name.Text = value.Name;
                    tb_Cost.Text = Convert.ToString(value.Cost);
                    tb_SerialNumber.Text = value.SerialNumber;
                    dtp_Date.Value = InputValidation.CheckDateTime(value.ManufacturesYear);
                    cb_Type.Text = value.Type;
                    tb_Power.Text = Convert.ToString(value.Power);
                    tb_FuelConsuption.Text = Convert.ToString(value.Consumption);
                }
            }
        }

        /// <summary>
        /// If 'true', all fields become 'ReadOnly'
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                tb_Name.ReadOnly = value;
                tb_SerialNumber.ReadOnly = value;
                tb_Cost.ReadOnly = value;
                dtp_Date.Enabled = !value;
                cb_Type.Enabled = !value;
                tb_Power.ReadOnly = value;
                tb_FuelConsuption.ReadOnly = value;
            }
        }

        #region TextBox

        /// <summary>
        /// Action by pressing a key in the field 'Name'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!InputValidation.IsEnglishAndNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action by pressing a key in the field 'SerialNumber'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!InputValidation.IsEnglishAndNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'SerialNumber'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_SerialNumber_Leave(object sender, EventArgs e)
        {
            if (tb_SerialNumber.Text != "")
            {
                int lengthText = tb_SerialNumber.TextLength;
                const int constLength = 17;
                if (lengthText != constLength)
                {
                    MessageBox.Show("The length of the serial number must be 17 characters !");
                }
            }
        }

        /// <summary>
        /// Action by pressing a key in the field 'Cost'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.Tb_Cost_KeyPress(tb_Cost.Text, e);
        }

        /// <summary>
        /// Action by pressing a key in the field 'Power'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'Power'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Power_Leave(object sender, EventArgs e)
        {
            if (tb_Power.Text != "")
            {
                const uint maxValue = 600;
                var number = Convert.ToDouble(tb_Power.Text);
                if (!(number > maxValue)) return;
                MessageBox.Show("Engine power must be less than 600 !");
                tb_Power.Text = "";
            }
        }

        /// <summary>
        /// Action on leaving the field 'FuelConsuption'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_FuelConsuption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'FuelConsuption'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_FuelConsuption_Leave(object sender, EventArgs e)
        {
            if (tb_FuelConsuption.Text != "")
            {
                double number = Convert.ToDouble(tb_FuelConsuption.Text);
                const uint maxValue = 20;
                if (number > maxValue)
                {
                    MessageBox.Show("Fuel consumption more than 20 (liters / 100 km) !");
                    tb_FuelConsuption.Text = "";
                }
            }
        }

        #endregion TextBox        

        private bool IsBlankSheet()
        {
            return (string.IsNullOrWhiteSpace(tb_Name.Text) || string.IsNullOrWhiteSpace(tb_Cost.Text) ||
                    string.IsNullOrWhiteSpace(tb_SerialNumber.Text) ||
                    string.IsNullOrWhiteSpace(tb_Power.Text) ||
                    string.IsNullOrWhiteSpace(tb_FuelConsuption.Text));
        }
    }
}
