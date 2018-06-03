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
    public partial class AddForm : Form
    {
        private TextBox _name;
        private TextBox _serialNumber;
        private DateTimePicker _manufacturesYear;
        private MaskedTextBox _cost;
        private TextBox _firstPersonal;
        private TextBox _secondPersonal;
        private TextBox _thirdPersonal;

        public string EnterName
        {
            get { return _name.Text; }
            set { _name.Text = value; }
        }
        public string EnterSerialNumber
        {
            get { return _serialNumber.Text; }
            set { _serialNumber.Text = value; }
        }
        public string EnterCost
        {
            get { return _cost.Text; }
            set { _cost.Text = value; }
        }
        public DateTime EnterDateTime
        {
            get { return Convert.ToDateTime(_manufacturesYear.Value); }
            set { _manufacturesYear.Value = Convert.ToDateTime(value); }
        }

        public string EnterFirstPersonal
        {
            get { return _firstPersonal.Text; }
            set { _firstPersonal.Text = value; }
        }

        public string EnterSecondPersonal
        {
            get { return _secondPersonal.Text; }
            set { _secondPersonal.Text = value; }
        }

        public string EnterThirdPersonal
        {
            get { return _thirdPersonal.Text; }
            set { _thirdPersonal.Text = value; }
        }



        public AddForm()
        {
            InitializeComponent();
            DefaultSetting();
        }

        private void DefaultSetting()
        {
            rbtn_Car.Checked = true;
            tb_Name.MaxLength = 25;
            dtp_Date.MaxDate = DateTime.Now;        
            tb_Cost.MaxLength = 12;            
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {                     
            this.Close();
        }


        #region RadioButton


        private void rbtn_CheckedChange(object sender, EventArgs e)
        {          
            RadioButton radioButton = (RadioButton) sender;
            if (rbtn_Car.Checked)
            {
                tb_SerialNumber.MaxLength = 17;
                l_FirstPersonal.Text = "Car interior ";               
                l_SecondPersonal.Text = "Car power";
                tb_SecondPersonal.MaxLength = 3;
                l_ThirdPersonal.Text = "Fuel consumption";
                tb_ThirdPersonal.MaxLength = 2;                
            }
            else if (rbtn_Boat.Checked)
            {
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
            KeyPress_EnglishAndNumberSymbol(e);
        }
     
        private void tb_SerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void tb_Cost_KeyPress(object sender, KeyPressEventArgs e)
        {            
            char[] text = tb_Cost.Text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    if (e.KeyChar == ',' || e.KeyChar == '.' || (text.Length - i) > 2)
                    {
                        e.Handled = true;
                    }
                }
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

        private void tb_SecondPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress_OnlyNumberSymbol(e);
        }

        private void tb_SecondPersonal_Leave(object sender, EventArgs e)
        {            
            if (tb_SecondPersonal.Text != "")
            {
                int number;
                number = Convert.ToInt32(tb_SecondPersonal.Text);
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
            KeyPress_OnlyNumberSymbol(e);
        }

        private void tb_ThirdPersonal_Leave(object sender, EventArgs e)
        {
            if (tb_ThirdPersonal.Text != "")
            {
                int number;
                number = Convert.ToInt32(tb_ThirdPersonal.Text);
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

        #endregion CheckKeyPress
        
    }
}
