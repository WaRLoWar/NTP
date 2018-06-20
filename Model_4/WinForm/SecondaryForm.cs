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

        /// <summary>
        /// Default Setting
        /// </summary>
        private void DefaultSetting()
        {
            vehicleControl_SecondForm.ReadOnly = false;
        }

        /// <summary>
        /// Interacting with data Vehicle
        /// </summary>
        public IVehicle Vehicle
        {
            get => vehicleControl_SecondForm.Vehicle;
            set => vehicleControl_SecondForm.Vehicle = value;
        }   
       
    }
}
