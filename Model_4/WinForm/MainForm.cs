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
    public partial class MainForm : Form
    {
        List<IVehicle> list;
        
        public MainForm()
        {               
            InitializeComponent();                 
        }

        private void SaveAll_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {

        }
    }
}
