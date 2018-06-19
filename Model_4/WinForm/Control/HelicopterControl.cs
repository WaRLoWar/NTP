using System;
using System.Windows.Forms;
using Model;

namespace WinForm
{
    public partial class HelicopterControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HelicopterControl()
        {
            InitializeComponent();
            DefaultSettingHelicopter();
        }

        /// <summary>
        /// Default Setting
        /// </summary>
        public void DefaultSettingHelicopter()
        {
            tb_Name.MaxLength = 25;
            tb_Cost.MaxLength = 12;
            tb_SerialNumber.MaxLength = 10;
            dtp_Date.MaxDate = DateTime.Today;
            dtp_Date.Value = DateTime.Today;
            dtp_Date.MinDate = new DateTime(1900, 01, 01);
            tb_Range.MaxLength = 4;
            tb_Capacity.MaxLength = 4;
            tb_Speed.MaxLength = 3;
        }

        /// <summary>
        /// Interaction with the class 'Helicopter'
        /// </summary>
        public Helicopter HelicopterVehicle
        {
            get
            {
                if (IsBlankSheet())
                {
                    return null;
                }
                Helicopter dataHelicopter = new Helicopter();
                dataHelicopter.TypeVehicle = "Helicopter";
                dataHelicopter.Name = tb_Name.Text;
                dataHelicopter.SerialNumber = tb_SerialNumber.Text;
                dataHelicopter.Cost = Convert.ToDouble(tb_Cost.Text);
                dataHelicopter.ManufacturesYear = InputValidation.CheckDateTime(dtp_Date.Value);
                dataHelicopter.Speed = Convert.ToDouble(tb_Speed.Text);
                dataHelicopter.Range = Convert.ToUInt32(tb_Range.Text);
                dataHelicopter.Capacity = Convert.ToUInt32(tb_Capacity.Text);
                return dataHelicopter;
            }
            set
            {
                if (value == null) return;
                tb_Name.Text = value.Name;
                tb_Cost.Text = Convert.ToString(value.Cost);
                tb_SerialNumber.Text = value.SerialNumber;
                dtp_Date.Value = value.ManufacturesYear;
                tb_Speed.Text = Convert.ToString(value.Speed);
                tb_Range.Text = Convert.ToString(value.Range);
                tb_Capacity.Text = Convert.ToString(value.Capacity);
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
                tb_Range.ReadOnly = value;
                tb_Speed.ReadOnly = value;
                tb_Capacity.ReadOnly = value;
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
            int lengthText = tb_SerialNumber.TextLength;
            if (lengthText < 4)
            {
                if (!InputValidation.IsOnlyEnglishSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
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
                const int constLength = 10;
                if (lengthText != constLength)
                {
                    MessageBox.Show("The length of the serial number must be 10 characters !");
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
        /// Action by pressing a key in the field 'Range'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Range_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'Range' 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Range_Leave(object sender, EventArgs e)
        {
            if (tb_Range.Text != "")
            {
                double number;
                number = Convert.ToDouble(tb_Range.Text);
                const uint maxValue = 1200;
                if (number > maxValue)
                {
                    MessageBox.Show("The entered value is greater than the maximum value (1200 km) !");
                    tb_Range.Text = "";
                }
            }
        }

        /// <summary>
        /// Action by pressing a key in the field 'Capacity'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'Capacity'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Capacity_Leave(object sender, EventArgs e)
        {
            if (tb_Capacity.Text != "")
            {
                const uint maxValue = 8000;
                double number = Convert.ToDouble(tb_Capacity.Text);
                if (!(number > maxValue)) return;
                MessageBox.Show("The entered value is greater than the maximum value(8000 kg) !");
                tb_Capacity.Text = "";
            }
        }

        /// <summary>
        /// Action on leaving the field 'Speed'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Speed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'Speed'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Speed_Leave(object sender, EventArgs e)
        {
            if (tb_Speed.Text != "")
            {
                double number = Convert.ToDouble(tb_Speed.Text);
                const uint maxValue = 200;
                if (!(number > maxValue)) return;
                MessageBox.Show("The entered value is greater than the maximum value (200 km / h ) !");
                tb_Speed.Text = "";
            }
        }

        #endregion TextBox        
        private bool IsBlankSheet()
        {
            return (string.IsNullOrWhiteSpace(tb_Name.Text) || string.IsNullOrWhiteSpace(tb_Cost.Text) ||
                    string.IsNullOrWhiteSpace(tb_SerialNumber.Text) ||
                    string.IsNullOrWhiteSpace(tb_Speed.Text) || string.IsNullOrWhiteSpace(tb_Range.Text) ||
                    string.IsNullOrWhiteSpace(tb_Capacity.Text));
        }
    }
}
