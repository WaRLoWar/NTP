using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace WinForm
{
    public partial class SecondaryForm : Form
    {
        /// <summary>
        /// Сonstructor
        /// </summary>
        public SecondaryForm()
        {
            InitializeComponent();
            DefaultSetting();
        }

        private void DefaultSetting()
        {
            vehicleControl_SecondForm.ReadOnly = false;
        }

        public IVehicle Vehicle
        {
            get => vehicleControl_SecondForm.Vehicle;
            set => vehicleControl_SecondForm.Vehicle = value;
        }   

        #region Get and Set Value  

        /// <summary>
        /// Combining fields under one interface
        /// </summary>
        /// <returns></returns>
        //public IVehicle GetVehicle()
        //{
        //    IVehicle newVehicle = null;            
        //    if (rbtn_Car.Checked)
        //    {
        //        Car newCar = new Car();                
        //        newCar.Type = cb_FirstPersonal.Text;
        //        newCar.Power = Convert.ToDouble(tb_SecondPersonal.Text);
        //        newCar.Consumption = Convert.ToDouble(tb_ThirdPersonal.Text);
        //        newVehicle = newCar;
        //        newVehicle.TypeVehicle = "Car";
        //    }
        //    else if (rbtn_Boat.Checked)
        //    {
        //        Boat newBoat = new Boat();               
        //        newBoat.Speed= Convert.ToDouble(tb_FirstPersonal.Text);
        //        newBoat.Draft = Convert.ToDouble(tb_SecondPersonal.Text);
        //        newBoat.BoatCapacity = Convert.ToUInt32(tb_ThirdPersonal.Text);
        //        newVehicle = newBoat;
        //        newVehicle.TypeVehicle = "Boat";
        //    }
        //    else
        //    {
        //        Helicopter newHelicopter = new Helicopter();                
        //        newHelicopter.Range= Convert.ToUInt32(tb_FirstPersonal.Text);
        //        newHelicopter.Capacity = Convert.ToUInt32(tb_SecondPersonal.Text);
        //        newHelicopter.Speed = Convert.ToDouble(tb_ThirdPersonal.Text);
        //        newVehicle = newHelicopter;
        //        newVehicle.TypeVehicle = "Helicopter";
        //    }
        //    newVehicle.Name = tb_Name.Text;
        //    newVehicle.Cost = Convert.ToDouble(tb_Cost.Text);
        //    newVehicle.ManufacturesYear = dtp_Date.Value;
        //    newVehicle.SerialNumber = tb_SerialNumber.Text;    
        //    return newVehicle;
        //}
        ///// <summary>
        ///// Adding a value to a field from outside
        ///// </summary>
        ///// <param name="data"></param>
        //public void SetVehicle(IVehicle data)
        //{           
        //    if (data is Car dataCar)
        //    {
        //        rbtn_Car.Checked = true;
        //        cb_FirstPersonal.Text = dataCar.Type;
        //        tb_SecondPersonal.Text = Convert.ToString(dataCar.Power);
        //        tb_ThirdPersonal.Text = Convert.ToString(dataCar.Consumption);
        //    }
        //    else if (data is Boat dataBoat)
        //    {
        //        rbtn_Boat.Checked = true;
        //        tb_FirstPersonal.Text = Convert.ToString(dataBoat.Speed);
        //        tb_SecondPersonal.Text = Convert.ToString(dataBoat.Draft);
        //        tb_ThirdPersonal.Text = Convert.ToString(dataBoat.BoatCapacity);
        //    }
        //    else 
        //    {
        //        Helicopter dataHelicopter = (Helicopter) data;
        //        rbtn_Helicopter.Checked = true;
        //        tb_FirstPersonal.Text = Convert.ToString(dataHelicopter.Range);
        //        tb_SecondPersonal.Text = Convert.ToString(dataHelicopter.Capacity);
        //        tb_ThirdPersonal.Text = Convert.ToString(dataHelicopter.Speed);
        //    }
        //    tb_Name.Text = data.Name;
        //    tb_Cost.Text = Convert.ToString(data.Cost);
        //    tb_SerialNumber.Text = data.SerialNumber;
        //    dtp_Date.Value = data.ManufacturesYear;
        //}
        #endregion Get and Set Value

        #region Button

        ///// <summary>
        ///// OK button
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Btn_OK_Click(object sender, EventArgs e)
        //{                        
        //    if (IsBlankSheet())
        //    {
        //        this.DialogResult = DialogResult.Cancel;
        //        MessageBox.Show("Blank Sheet !");
        //    }
        //    else
        //    {           
        //        this.DialogResult = DialogResult.OK;
        //    }            
        //    this.Close();
        //}
        /// <summary>
        ///// Cancel button
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Btn_Cancel_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.Cancel;
        //    this.Close();
        //}


        #endregion Button

        #region RadioButton
        ///// <summary>
        ///// The current type of transport
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Rbtn_CheckedChange(object sender, EventArgs e)
        //{
        //    RadioButton radioButton = (RadioButton)sender;
        //    if (rbtn_Car.Checked)
        //    {   
        //        ClearFields();
        //        tb_FirstPersonal.Visible = false;
        //        cb_FirstPersonal.Visible = true;
        //        tb_SerialNumber.MaxLength = 17;
        //        l_FirstPersonal.Text = "Car interior ";
        //        l_SecondPersonal.Text = "Car power";
        //        tb_SecondPersonal.MaxLength = 3;
        //        l_ThirdPersonal.Text = "Fuel consumption";
        //        tb_ThirdPersonal.MaxLength = 2;
        //    }
        //    else if (rbtn_Boat.Checked)
        //    {
        //        ClearFields();
        //        cb_FirstPersonal.Visible = false;
        //        tb_FirstPersonal.Visible = true;
        //        tb_SerialNumber.MaxLength = 12;
        //        l_FirstPersonal.Text = "Boat speed ";
        //        tb_FirstPersonal.MaxLength = 2;
        //        l_SecondPersonal.Text = "Boat Draft";
        //        tb_SecondPersonal.MaxLength = 2;
        //        l_ThirdPersonal.Text = "Boat capacity";
        //        tb_ThirdPersonal.MaxLength = 2;
        //    }
        //    else if (rbtn_Helicopter.Checked)
        //    {
        //        ClearFields();
        //        cb_FirstPersonal.Visible = false;
        //        tb_FirstPersonal.Visible = true;
        //        tb_SerialNumber.MaxLength = 10;
        //        l_FirstPersonal.Text = "Practical range ";
        //        tb_FirstPersonal.MaxLength = 4;
        //        l_SecondPersonal.Text = "Helicopter capacity";
        //        tb_SecondPersonal.MaxLength = 4;
        //        l_ThirdPersonal.Text = "Helicopter speed";
        //        tb_ThirdPersonal.MaxLength = 3;
        //    }
        //}
        #endregion RadioButton

        #region TextBox

        ///// <summary>
        ///// Action by pressing a key in the field 'SerialNumber'
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.KeyChar = char.ToUpper(e.KeyChar);
        //    if (rbtn_Car.Checked)
        //    {
        //        if (!InputValidation.IsEnglishAndNumberSymbol(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    else if (rbtn_Boat.Checked)
        //    {
        //        if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }    
        //    }
        //    else if (rbtn_Helicopter.Checked)
        //    {
        //        int lengthText = tb_SerialNumber.TextLength;
        //        if (lengthText < 4)
        //        {
        //            if (!InputValidation.IsOnlyEnglishSymbol(e.KeyChar)) 
        //            {
        //                e.Handled = true;
        //            }           
        //        }
        //        else
        //        {
        //            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
        //            {
        //                e.Handled = true;
        //            }
        //        }
        //    }
        //}
        ///// <summary>
        ///// Action on leaving the field 'SerialNumber'
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_SerialNumber_Leave(object sender, EventArgs e)
        //{
        //    if (tb_SerialNumber.Text != "")
        //    {                
        //        int lengthText = tb_SerialNumber.TextLength;
        //        if (rbtn_Car.Checked)
        //        {
        //            const int constLength=17;
        //            if (lengthText != constLength)
        //            {
        //                MessageBox.Show("The length of the serial number must be 17 characters !");
        //            }
        //        }
        //        else if (rbtn_Boat.Checked)
        //        {
        //            const int maxConstLength = 12;
        //            const int minConstLength = 8;
        //            if (lengthText != minConstLength && lengthText != maxConstLength)
        //            {
        //                MessageBox.Show("The length of the serial number must be 8 or 12 characters !");
        //            }
        //        }
        //        else if (rbtn_Helicopter.Checked)
        //        {
        //            const int constLength = 10;
        //            if (lengthText != constLength)
        //            {
        //                MessageBox.Show("The length of the serial number must be 10 characters !");
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// Action by pressing a key in the field 'Cost'
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!InputValidation.IsCorrectLine(e.KeyChar, tb_Cost.Text))
        //    {
        //        e.Handled = true;
        //    }
        //    if (tb_Cost.Text == "" && (e.KeyChar == ',' || e.KeyChar == '.') || !InputValidation.IsNumberSymbol(e.KeyChar) && !InputValidation.IsSpecialSymbols(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //    else if (e.KeyChar == ',' || e.KeyChar == '.')
        //    {                
        //        e.KeyChar = '.';
        //    }
        //}            

        ///// <summary>
        ///// Action on leaving the field 'FirstPersonal' 
        ///// (Boat - Speed / Helicopter - Range )
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_FirstPersonal_Leave(object sender, EventArgs e)
        //{
        //    if (tb_FirstPersonal.Text != "")
        //    {
        //        double number;
        //        number = Convert.ToDouble(tb_FirstPersonal.Text);                
        //        if (rbtn_Boat.Checked)
        //        {
        //            const uint maxValue = 80;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("Entered speed greater than maximum speed !( 80 km/h )");
        //                tb_FirstPersonal.Text = "";
        //            }
        //        }
        //        else if (rbtn_Helicopter.Checked)
        //        {
        //            const uint maxValue = 1200;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("The entered value is greater than the maximum value (1200 km) !");
        //                tb_FirstPersonal.Text = "";
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        /////  Action on leaving the field 'SecondPersonal'
        ///// ( Car - Power / Boat - Draft / Helicopter - Capacity)
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_SecondPersonal_Leave(object sender, EventArgs e)
        //{            
        //    if (tb_SecondPersonal.Text != "")
        //    {
        //        double number;
        //        number = Convert.ToDouble(tb_SecondPersonal.Text);
        //        if (rbtn_Car.Checked)
        //        {
        //            const uint maxValue = 600;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("Engine power must be less than 600 !");
        //                tb_SecondPersonal.Text = "";
        //            }
        //        }
        //        else if (rbtn_Boat.Checked)
        //        {
        //            const uint maxValue = 80;
        //            if (number > maxValue) 
        //            {
        //                MessageBox.Show("The entered value of the boat draught is greater than the maximum value ! ( 80 cm )");
        //                tb_SecondPersonal.Text = "";
        //            }
        //        }
        //        else if (rbtn_Helicopter.Checked)
        //        {
        //            const uint maxValue = 8000;
        //            if (number > maxValue) 
        //            {
        //                MessageBox.Show("The entered value is greater than the maximum value(8000 kg) !");
        //                tb_SecondPersonal.Text = "";
        //            }
        //        }
        //    }
        //}

        //private void Tb_ThirdPersonal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void Tb_SecondPersonal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void Tb_FirstPersonal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void Tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!InputValidation.IsEnglishAndNumberSymbol(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        ///// <summary>
        ///// Action on leaving the field 'ThirdPersonal'
        ///// ( Car - Consumption / Boat - Capacity / Helicopter - Speed )
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Tb_ThirdPersonal_Leave(object sender, EventArgs e)
        //{
        //    if (tb_ThirdPersonal.Text != "")
        //    {
        //        double number;
        //        number = Convert.ToDouble(tb_ThirdPersonal.Text);
        //        if (rbtn_Car.Checked)
        //        {
        //            const uint maxValue = 20;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("Fuel consumption more than 20 (liters / 100 km) !");
        //                tb_ThirdPersonal.Text = "";
        //            }
        //        }
        //        else if (rbtn_Boat.Checked)
        //        {
        //            const uint maxValue=18;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("The entered boat capacity value is greater than the maximum value ! ( 18 )");
        //                tb_ThirdPersonal.Text = "";
        //            }
        //        }
        //        else if (rbtn_Helicopter.Checked)
        //        {
        //            const uint maxValue = 200;
        //            if (number > maxValue)
        //            {
        //                MessageBox.Show("The entered value is greater than the maximum value (200 km / h ) !");
        //                tb_ThirdPersonal.Text = "";
        //            }
        //        }
        //    }
        //}
        #endregion TextBox

        #region GeneralKeyPress

        ///// <summary>
        ///// Checking for at least one blank field
        ///// </summary>
        ///// <returns></returns>
        //private bool IsBlankSheet()
        //{
        //    return (String.IsNullOrWhiteSpace(tb_Name.Text) || String.IsNullOrWhiteSpace(tb_Cost.Text) ||
        //            String.IsNullOrWhiteSpace(tb_SerialNumber.Text) ||
        //            String.IsNullOrWhiteSpace(tb_SecondPersonal.Text) ||
        //            String.IsNullOrWhiteSpace(tb_ThirdPersonal.Text));
        //}
        ///// <summary>
        ///// Clearing fields
        ///// </summary>
        //private void ClearFields()
        //{
        //    tb_Name.Text = "";
        //    tb_SerialNumber.Text = "";
        //    tb_Cost.Text = "";
        //    dtp_Date.Value = dtp_Date.MaxDate;
        //    tb_FirstPersonal.Text = "";
        //    tb_SecondPersonal.Text = "";
        //    tb_ThirdPersonal.Text = "";
        //}

        #endregion GeneralKeyPress

        #region CheckKeyPress

        ///// <summary>
        ///// Checking whether the symbol is a decimal digit
        ///// </summary>
        ///// <param name="e"></param>
        ///// <returns></returns>
        //private bool IsNumberSymbol(KeyPressEventArgs e)
        //{            
        //    return (char.IsDigit((e.KeyChar)));
        //}

        ///// <summary>
        ///// Checking whether a character is an English alphabet character
        ///// </summary>
        ///// <param name="e"></param>
        ///// <returns></returns>
        //private bool IsEnglishSymbol(KeyPressEventArgs e)
        //{            
        //    return (e.KeyChar >= 'A' && e.KeyChar <= 'Z');
        //}
        ///// <summary>
        ///// Check whether the key pressed is a Backspace or Delete button
        ///// </summary>
        ///// <param name="e"></param>
        ///// <returns></returns>
        //private bool IsSpecialSymbols(KeyPressEventArgs e)
        //{           
        //    return ((e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Delete));
        //}
        ///// <summary>
        ///// Checks the string for more than one comma in the field 'Cost'
        ///// </summary>
        ///// <param name="semder"></param>
        ///// <param name="e"></param>
        ///// <returns></returns>
        //private bool IsCorrectLine(object semder, KeyPressEventArgs e)
        //{
        //    char[] text = tb_Cost.Text.ToCharArray();
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == '.')
        //        {
        //            if (e.KeyChar == ',' || e.KeyChar == '.' || (text.Length - i) > 2)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        #endregion CheckKeyPress
    }
}
