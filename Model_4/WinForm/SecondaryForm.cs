using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm
{
    public partial class SecondaryForm : Form
    {
        #region Private Value

        private string _name;
        private string _serialNumber;
        private DateTime _manufacturesYear;
        private string _cost;
        private string _firstPersonal;
        private string _secondPersonal;
        private string _thirdPersonal;
        private char _typeVehicle;

        #endregion Private Value
 
        #region Enter Value

        public string EnterName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string EnterSerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }
        public string EnterCost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public DateTime EnterDateTime
        {
            get { return Convert.ToDateTime(_manufacturesYear.Date); }
            set { _manufacturesYear = Convert.ToDateTime(value); }
        }

        public string EnterFirstPersonal
        {
            get { return _firstPersonal; }
            set { _firstPersonal = value; }
        }

        public string EnterSecondPersonal
        {
            get { return _secondPersonal; }
            set { _secondPersonal = value; }
        }

        public string EnterThirdPersonal
        {
            get { return _thirdPersonal; }
            set { _thirdPersonal = value; }
        }

        public char EnterTypeVehicle
        {
            get { return _typeVehicle; }
            set { _typeVehicle = value; }
        }

        private void EnterAllValue()
        {
            EnterName = tb_Name.Text;
            EnterCost = tb_Cost.Text;
            EnterDateTime = dtp_Date.Value;
            EnterSerialNumber = tb_SerialNumber.Text;
            if (rbtn_Car.Checked)
            {
                EnterFirstPersonal = cb_FirstPersonal.Text;
            }
            else
            {
                EnterFirstPersonal = tb_FirstPersonal.Text;
            }
            EnterSecondPersonal = tb_SecondPersonal.Text;
            EnterThirdPersonal = tb_ThirdPersonal.Text;
        }

        #endregion Enter Value

        #region Initial Setting 

        public SecondaryForm()
        {
            InitializeComponent();
            DefaultSetting();            
        }

        private void DefaultSetting()
        {
            rbtn_Car.Checked = true;
            tb_Name.MaxLength = 25;
            dtp_Date.MaxDate = DateTime.Today;
            tb_Cost.MaxLength = 12;
            cb_FirstPersonal.Text = "NULL";
            cb_FirstPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cb_FirstPersonal.Size = tb_FirstPersonal.Size;
            cb_FirstPersonal.Location = tb_FirstPersonal.Location;
        }

        #endregion Initial Setting 

        #region Button

        private void btn_OK_Click(object sender, EventArgs e)
        {            
            EnterAllValue();
            if (isBlankSheet())
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Blank Sheet !");
            }
            else
            {

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion Button

        #region RadioButton

        private void rbtn_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (rbtn_Car.Checked)
            {
                EnterTypeVehicle = 'C';
                tb_FirstPersonal.Visible = false;
                cb_FirstPersonal.Visible = true;

                tb_SerialNumber.MaxLength = 17;
                l_FirstPersonal.Text = "Car interior ";
                l_SecondPersonal.Text = "Car power";
                tb_SecondPersonal.MaxLength = 3;
                l_ThirdPersonal.Text = "Fuel consumption";
                tb_ThirdPersonal.MaxLength = 2;
            }
            else if (rbtn_Boat.Checked)
            {
                EnterTypeVehicle = 'B';
                cb_FirstPersonal.Visible = false;
                tb_FirstPersonal.Visible = true;

                tb_SerialNumber.MaxLength = 12;
                l_FirstPersonal.Text = "Boat speed ";
                tb_FirstPersonal.MaxLength = 2;
                l_SecondPersonal.Text = "Boat Draft";
                tb_SecondPersonal.MaxLength = 2;
                l_ThirdPersonal.Text = "Boat capacity";
                tb_ThirdPersonal.MaxLength = 2;
            }
            else if (rbtn_Helicopter.Checked)
            {
                EnterTypeVehicle = 'H';
                cb_FirstPersonal.Visible = false;
                tb_FirstPersonal.Visible = true;

                tb_SerialNumber.MaxLength = 10;
                l_FirstPersonal.Text = "Practical range ";
                tb_FirstPersonal.MaxLength = 4;
                l_SecondPersonal.Text = "Helicopter capacity";
                tb_SecondPersonal.MaxLength = 4;
                l_ThirdPersonal.Text = "Helicopter speed";
                tb_ThirdPersonal.MaxLength = 3;
            }
        }

        #endregion RadioButton

        #region TextBox

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                KeyPress_EnglishAndNumberSymbol(e);
            }

        }

        private void tb_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }
            if (rbtn_Car.Checked)
            {
                KeyPress_EnglishAndNumberSymbol(e);
            }
            else if (rbtn_Boat.Checked)
            {
                KeyPress_OnlyNumberSymbol(e);
            }
            else if (rbtn_Helicopter.Checked)
            {
                int lengthText = tb_SerialNumber.TextLength;
                if (lengthText < 4)
                {
                    KeyPress_OnlyEnglishSymbol(e);
                }
                else
                {
                    KeyPress_OnlyNumberSymbol(e);
                }
            }
        }

        private void tb_SerialNumber_Leave(object sender, EventArgs e)
        {
            if (tb_SerialNumber.Text != "")
            {
                int lengthText = tb_SerialNumber.TextLength;
                if (rbtn_Car.Checked)
                {
                    if (lengthText != 17)
                    {
                        MessageBox.Show("The length of the serial number must be 17 characters !");
                    }
                }
                else if (rbtn_Boat.Checked)
                {
                    if (lengthText != 8 || lengthText != 12)
                    {
                        MessageBox.Show("The length of the serial number must be 8 or 12 characters !");
                    }
                }
                else if (rbtn_Helicopter.Checked)
                {
                    if (lengthText != 10)
                    {
                        MessageBox.Show("The length of the serial number must be 10 characters !");
                    }
                }
            }

        }

        private void tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsCorrectLine(sender, e))
            {
                e.Handled = true;
            }
            if (tb_Cost.Text == "" && (e.KeyChar == ',' || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {                
                e.KeyChar = '.';
            }
            else if (!IsNumberSymbol(e) && !IsSpecialSymbols(e))
            {
                e.Handled = true;
            }
        }

       
        private void tb_FirstPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;

            }
            else
            {
                KeyPress_OnlyNumberSymbol(e);
            }

        }

        private void tb_FirstPersonal_Leave(object sender, EventArgs e)
        {
            if (tb_FirstPersonal.Text != "")
            {
                double number;
                number = Convert.ToDouble(tb_FirstPersonal.Text);                
                if (rbtn_Boat.Checked)
                {
                    if (number > 80)
                    {
                        MessageBox.Show("Entered speed greater than maximum speed !( 80 km/h )");
                        tb_FirstPersonal.Text = "";
                    }
                }
                else if (rbtn_Helicopter.Checked)
                {
                    if (number > 1200)
                    {
                        MessageBox.Show("The entered value is greater than the maximum value (1200 km) !");
                        tb_FirstPersonal.Text = "";
                    }
                }
            }
        }
        private void tb_SecondPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;

            }
            else
            {
                KeyPress_OnlyNumberSymbol(e);
            }
        }

        
        private void tb_SecondPersonal_Leave(object sender, EventArgs e)
        {            
            if (tb_SecondPersonal.Text != "")
            {
                double number;
                number = Convert.ToDouble(tb_SecondPersonal.Text);
                if (rbtn_Car.Checked)
                {
                    if (number > 600)
                    {
                        MessageBox.Show("Engine power must be less than 600 !");
                        tb_SecondPersonal.Text = "";
                    }
                }
                else if (rbtn_Boat.Checked)
                {
                    if (number > 80) 
                    {
                        MessageBox.Show("The entered value of the boat draught is greater than the maximum value ! ( 80 cm )");
                        tb_SecondPersonal.Text = "";
                    }
                }
                else if (rbtn_Helicopter.Checked)
                {
                    if (number > 8000) 
                    {
                        MessageBox.Show("The entered value is greater than the maximum value(8000 kg) !");
                        tb_SecondPersonal.Text = "";
                    }
                }
            }
        }

        private void tb_ThirdPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = true;
            }
            else
            {
                KeyPress_OnlyNumberSymbol(e);
            }
        }

        private void tb_ThirdPersonal_Leave(object sender, EventArgs e)
        {
            if (tb_ThirdPersonal.Text != "")
            {
                double number;
                number = Convert.ToDouble(tb_ThirdPersonal.Text);
                if (rbtn_Car.Checked)
                {
                    if (number > 20)
                    {
                        MessageBox.Show("Fuel consumption more than 20 (liters / 100 km) !");
                        tb_ThirdPersonal.Text = "";
                    }
                }
                else if (rbtn_Boat.Checked)
                {
                    if (number > 18)
                    {
                        MessageBox.Show("The entered boat capacity value is greater than the maximum value ! ( 18 )");
                        tb_ThirdPersonal.Text = "";
                    }
                }
                else if (rbtn_Helicopter.Checked)
                {
                    if (number > 200)
                    {
                        MessageBox.Show("The entered value is greater than the maximum value (200 km / h ) !");
                        tb_ThirdPersonal.Text = "";
                    }
                }
            }
        }
        #endregion TextBox

        #region GeneralKeyPress

        private void KeyPress_EnglishAndNumberSymbol(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!IsEnglishSymbol(e) && !IsNumberSymbol(e) && !IsSpecialSymbols(e))
            {
                e.Handled = true;
            }
        }
        private void KeyPress_OnlyNumberSymbol(KeyPressEventArgs e)
        {
            if (!IsNumberSymbol(e) && !IsSpecialSymbols(e))
            {
                e.Handled = true;
            }
        }
        private void KeyPress_OnlyEnglishSymbol(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!IsEnglishSymbol(e) && !IsSpecialSymbols(e))
            {
                e.Handled = true;
            }
        }

        #endregion GeneralKeyPress

        #region CheckKeyPress

        private bool IsNumberSymbol(KeyPressEventArgs e)
        {            
            return (Char.IsDigit((e.KeyChar))) ? true : false;
        }

        private bool IsEnglishSymbol(KeyPressEventArgs e)
        {
            return (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ? true : false;
        }
        private bool IsSpecialSymbols(KeyPressEventArgs e)
        {
            return ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete)) ? false : true;
        }

        private bool IsCorrectLine(object semder, KeyPressEventArgs e)
        {
            char[] text = tb_Cost.Text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    if (e.KeyChar == ',' || e.KeyChar == '.' || (text.Length - i) > 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isBlankSheet()
        {
            return (String.IsNullOrWhiteSpace(EnterName) || String.IsNullOrWhiteSpace(EnterCost) ||
                    String.IsNullOrEmpty(EnterFirstPersonal) || String.IsNullOrWhiteSpace(EnterSecondPersonal) ||
                    String.IsNullOrWhiteSpace(EnterThirdPersonal))
                ? true
                : false;
        }
        #endregion CheckKeyPress

    }
}
