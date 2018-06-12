using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WinForm
{
    public partial class MainForm : Form
    {
        #region Private Fields
        private SecondaryForm _secondaryForm;
        private DialogResult _dialogResult;
        private bool _isNeedSave = false;
        private bool _isFileCreated = false;
        private List<IVehicle> _vehicles;
        private DataContractJsonSerializer _serialized;
        private RandomVehicle _randomVehicle;
        #endregion Private Fields   

        #region Default Setting
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DefaultSetting();
            List<Type> typeList = new List<Type>
            {
                typeof(Car),
                typeof(Boat),
                typeof(Helicopter)
            };           
            _serialized = new DataContractJsonSerializer(typeof(List<IVehicle>),typeList);
        }
        /// <summary>
        /// Default Setting
        /// </summary>
        private void DefaultSetting()
        {
            btn_CreateRandomData.Visible = System.Diagnostics.Debugger.IsAttached;
            _vehicles = new List<IVehicle>();
            bs_Main.DataSource = _vehicles;
            dgv_Main.DataSource = bs_Main;
            dgv_Main.RowHeadersVisible = false;
            dgv_Main.Columns[0].Width = 80;
            dgv_Main.MultiSelect = false;
            tb_Search.MaxLength = 20;
            ms_SaveTool.ShortcutKeys = Keys.Control | Keys.S;
            ms_SaveAsTool.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ms_OpenTool.ShortcutKeys = Keys.Control | Keys.O;
            ms_NewFileTool.ShortcutKeys = Keys.Control | Keys.N;
        }
        #endregion Default Setting

        #region Action with Form Main and DataGridView

        /// <summary>
        /// Action on closing the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosingForm();
        }
        /// <summary>
        /// Checking if you need to save data when closing the program
        /// </summary>
        private void ClosingForm()
        {
            if (IsNeedSaveData())
            {
                DialogResult result = MessageBox.Show("Data not saved ! Save it?", "Attention", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    SaveAsData();
                }
                _isNeedSave = false;
            }
        }

        /// <summary>
        /// Call the change function when you double-click the selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dgv_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }
        #endregion Action with Form Main and DataGridView
    
        #region Buttons

        /// <summary>
        /// Button to add data
        /// </summary>        
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            _secondaryForm = new SecondaryForm();
            _dialogResult = _secondaryForm.ShowDialog();
            if (_dialogResult == DialogResult.OK)
            {
                _isNeedSave = true;
                try
                {
                    IVehicle newVehicle = _secondaryForm.GetVehicle();
                    bs_Main.Add(newVehicle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Warning Error " + ex.Message);
                }                
            }
        }

        /// <summary>
        /// Adding rows with random values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CreateRandomData_Click(object sender, EventArgs e)
        {
            _randomVehicle= new RandomVehicle();
            IVehicle newVehicle = _randomVehicle.GetRandomVehicle();
            bs_Main.Add(newVehicle);
            _isNeedSave = true;
        }

        /// <summary>
        /// Call function edit row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_EditData_Click(object sender, EventArgs e)
        {
            if (!_vehicles.Any())
            {
                return;
            }
            EditData();
        }

        /// <summary>
        /// Delete the selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            int rowToDelete = dgv_Main.Rows.GetFirstRow(
                DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                _isNeedSave = true;
                bs_Main.RemoveAt(rowToDelete);                
            }
        }

        #endregion Buttons

        #region Search

        /// <summary>
        /// Checking the entered character
        /// </summary>        
        private void Tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || (char.ToUpper(e.KeyChar) >= 'А' && char.ToUpper(e.KeyChar) <= 'Я'))
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }

        }
        /// <summary>
        /// Checking the entered string for a match in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_Search.Text!="")
            {
                var founded = new List<IVehicle>();
                foreach (var vehicle in _vehicles)
                {
                    if (vehicle.Name.Contains(tb_Search.Text) || vehicle.SerialNumber.Contains(tb_Search.Text))
                    {
                        founded.Add(vehicle);
                    }
                }
                bs_Main.DataSource = founded;                  
            }
            else
            {
                bs_Main.DataSource = _vehicles;
            }
        }

        #endregion Search

        #region MenuStrip
        /// <summary>
        /// Saving data
        /// </summary>        
        private void Ms_SaveTools_Click(object sender, EventArgs e)
        {
            if (_isFileCreated)
            { 
                FileStream fStream = new FileStream(sfd_Main.FileName, FileMode.OpenOrCreate);
                _serialized.WriteObject(fStream, _vehicles);
                fStream.Dispose();                
                _isNeedSave = false;
            }
            else
            {
                SaveAsData();               
            }
        }
        /// <summary>
        /// To upload the data
        /// </summary>   
        private void Ms_LoadTools_Click(object sender, EventArgs e)
        {
            ofd_Main.AddExtension = true;
            ofd_Main.Filter = "Vehicle|*.vehicle";
            DialogResult result = ofd_Main.ShowDialog();
            if (result == DialogResult.OK)
            {
                bs_Main.Clear();
                FileStream fStream= new FileStream(ofd_Main.FileName, FileMode.OpenOrCreate);
                List<IVehicle> deserialized = (List<IVehicle>)_serialized.ReadObject(fStream);
                fStream.Dispose();
                foreach (IVehicle vehicle in deserialized)
                {
                    bs_Main.Add(vehicle);
                }                
                _isNeedSave = false;
            }
        }
        /// <summary>
        /// Saving 'as' data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ms_SaveAsTool_Click(object sender, EventArgs e)
        {
            SaveAsData();
        }
        /// <summary>
        /// Saving 'as' file
        /// </summary>
        private void SaveAsData()
        {
            if (!IsNeedSaveData())
            {
                MessageBox.Show("List is empty. Nothing to save");
            }
            else
            {
                sfd_Main.AddExtension = true;
                sfd_Main.Filter = "Vehicle|*.vehicle";
                DialogResult result = sfd_Main.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream fStream = new FileStream(sfd_Main.FileName, FileMode.OpenOrCreate);
                    _serialized.WriteObject(fStream, _vehicles);
                    fStream.Dispose();
                    _isNeedSave = false;
                    _isFileCreated = true;
                }
            }
        }
        /// <summary>
        /// Close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ms_ExitTools_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Creating an empty table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ms_NewFileTool_Click(object sender, EventArgs e)
        {
            bs_Main.Clear();
            _isNeedSave = true;
        }            

        /// <summary>
        /// Row editing function
        /// </summary>
        private void EditData()
        {
            _secondaryForm = new SecondaryForm();
            IVehicle current = (IVehicle)bs_Main.Current;
            _secondaryForm.SetVehicleData(current);
            _dialogResult = _secondaryForm.ShowDialog();
            if (_dialogResult == DialogResult.OK)
            {
                IVehicle newVehicle = _secondaryForm.GetVehicle();
                int index = bs_Main.CurrencyManager.Position;
                bs_Main.RemoveAt(index);
                bs_Main.Insert(index, newVehicle);
                _isNeedSave = true;
            }
        }
        /// <summary>
        /// Condition for saving data
        /// </summary>
        /// <returns></returns>
        private bool IsNeedSaveData()
        {
            return (_vehicles.Any() && _isNeedSave);
        }
        #endregion MenuStrip        
    }
}
