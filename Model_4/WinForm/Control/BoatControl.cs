using System;
using System.Windows.Forms;
using Model;

namespace WinForm
{
    public partial class BoatControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BoatControl()
        {
            InitializeComponent();
            DefaultSettingBoat();
        }

        /// <summary>
        /// Default Setting
        /// </summary>
        private void DefaultSettingBoat()
        {
            tb_Name.MaxLength = 25;
            tb_Cost.MaxLength = 12;
            tb_SerialNumber.MaxLength = 12;
            dtp_Date.MaxDate = DateTime.Today;
            dtp_Date.Value = DateTime.Today;
            dtp_Date.MinDate = new DateTime(1900, 01, 01);
            tb_Speed.MaxLength = 2;            
            tb_Draft.MaxLength = 2;
            tb_BoatCapacity.MaxLength = 2;
            SettingTab();
        }

        /// <summary>
        /// Prohibition of interaction via 'Tab'
        /// </summary>
        private void SettingTab()
        {
            l_Name.TabStop = false;
            l_BoatCapacity.TabStop = false;
            l_Cost.TabStop = false;
            l_Draft.TabStop = false;
            l_ManufacturesYear.TabStop = false;
            l_Speed.TabStop = false;
            l_SerialNumber.TabStop = false;
        }
        /// <summary>
        /// Interaction with the class 'Boat'
        /// </summary>
        public Boat BoatVehicle
        {
            get
            {
                if (IsBlankSheet())
                {
                    return null;
                }
                Boat dataBoat = new Boat();
                dataBoat.TypeVehicle = "Boat";
                dataBoat.Name = tb_Name.Text;
                dataBoat.SerialNumber = tb_SerialNumber.Text;
                dataBoat.Cost = Convert.ToDouble(tb_Cost.Text);
                dataBoat.ManufacturesYear = InputValidation.CheckDateTime(dtp_Date.Value);
                dataBoat.Speed = Convert.ToDouble(tb_Speed.Text);
                dataBoat.Draft = Convert.ToDouble(tb_Draft.Text);
                dataBoat.BoatCapacity = Convert.ToUInt32(tb_BoatCapacity.Text);
                return dataBoat;                            
            }
            set
            {
                if (value == null) return;
                tb_Name.Text = value.Name;
                tb_Cost.Text = Convert.ToString(value.Cost);
                tb_SerialNumber.Text = value.SerialNumber;
                dtp_Date.Value = value.ManufacturesYear;
                tb_Speed.Text = Convert.ToString(value.Speed);
                tb_Draft.Text = Convert.ToString(value.Draft);
                tb_BoatCapacity.Text = Convert.ToString(value.BoatCapacity);
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
                tb_Speed.ReadOnly = value;
                tb_Draft.ReadOnly = value;
                tb_BoatCapacity.ReadOnly = value;
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
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
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
                const int maxConstLength = 12;
                const int minConstLength = 8;
                if (lengthText != minConstLength && lengthText != maxConstLength)
                {
                    MessageBox.Show("The length of the serial number must be 8 or 12 characters !");
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
        /// Action by pressing a key in the field 'Speed'
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
                double number;
                number = Convert.ToDouble(tb_Speed.Text);
                const uint maxValue = 80;
                if (number > maxValue)
                {
                    MessageBox.Show("Entered speed greater than maximum speed !( 80 km/h )");
                    tb_Speed.Text = "";
                }
            }
        }

        /// <summary>
        /// Action by pressing a key in the field 'Draft'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Draft_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'Draft'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Draft_Leave(object sender, EventArgs e)
        {
            if (tb_Draft.Text != "")
            {
                const uint maxValue = 80;
                double number = Convert.ToDouble(tb_Draft.Text);
                if (!(number > maxValue)) return;
                MessageBox.Show("The entered value of the boat draught is greater than the maximum value ! ( 80 cm )");
                tb_Draft.Text = "";
            }
        }

        /// <summary>
        /// Action on leaving the field 'BoatCapacity'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_BoatCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!InputValidation.IsOnlyNumberSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Action on leaving the field 'BoatCapacity'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_BoatCapacity_Leave(object sender, EventArgs e)
        {
            if (tb_BoatCapacity.Text != "")
            {                
                double number = Convert.ToDouble(tb_BoatCapacity.Text);
                const uint maxValue = 200;
                if (!(number > maxValue)) return;
                MessageBox.Show("The entered value is greater than the maximum value (200 km / h ) !");
                tb_BoatCapacity.Text = "";
            }
        }

        #endregion TextBox        

        private bool IsBlankSheet()
        {
            return (string.IsNullOrWhiteSpace(tb_Name.Text) || string.IsNullOrWhiteSpace(tb_Cost.Text) ||
                    string.IsNullOrWhiteSpace(tb_SerialNumber.Text) ||
                    string.IsNullOrWhiteSpace(tb_Speed.Text) || string.IsNullOrWhiteSpace(tb_Draft.Text) ||
                    string.IsNullOrWhiteSpace(tb_BoatCapacity.Text));
        }
    }
}
