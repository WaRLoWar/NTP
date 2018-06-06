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
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;


namespace WinForm
{
    public partial class MainForm : Form
    {        
        private SecondaryForm secondaryForm;
        private DialogResult dialogResult;
        private bool isNeedSave = false;
        private List<IVehicle> _vehicles;


        public MainForm()
        {               
            InitializeComponent();
            DefaultSetting();
           
        }

        private void DefaultSetting()
        {
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
        }
        private void SaveData()
        {
            if (!IsNeedSaveData())
            {
                MessageBox.Show("List is empty. Nothing to save");
            }
            else
            {
                isNeedSave = false;
                sfd_Main.AddExtension = true;
                sfd_Main.Filter = "Vehicle|*.vehicle";
                DialogResult result = sfd_Main.ShowDialog();
                if (result == DialogResult.OK)
                {                  
                    string json = JsonConvert.SerializeObject(_vehicles);
                    File.WriteAllText(sfd_Main.FileName, json);                    
                }
            }
            //if (!(_vehicles.Any()))
            //{
            //    MessageBox.Show("List is empty. Nothing to save");
            //}
            //else
            //{
            //    string serialized = JsonConvert.SerializeObject(_vehicles);
            //    MessageBox.Show(serialized);

            //    DirectoryInfo dirInfo = CreateDirectory();
            //    fstream = CreateFile(dirInfo, serialized);
            //    FileInfo fileInfo = CreateFile(dirInfo);
            //}
        }

        private DirectoryInfo CreateDirectory()
        {
            string path = @"C:\Users\WarLo\Documents\TestLab";
            string subpath = @"SaveInfo";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            return dirInfo;
        }

        private FileInfo CreateFile(DirectoryInfo dir)
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\WarLo\Documents\TestLab\text.json");
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            return fileInfo;
        }
        private FileStream CreateFile(DirectoryInfo dir,string text)
        {
            FileStream fstream = new FileStream((dir.FullName + "note.json"),FileMode.Append);
            byte[] array = System.Text.Encoding.Default.GetBytes(text);
            fstream.Write(array, 0, array.Length);
            MessageBox.Show("Text saved");
            return fstream;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosingForm();
        }
        #region Add New Vehicle

        private Car AddCar(Car newVehicle)
        {
            newVehicle.TypeVehicle = secondaryForm.EnterTypeVehicle;
            newVehicle.Name = secondaryForm.EnterName;
            newVehicle.SerialNumber = secondaryForm.EnterSerialNumber;
            newVehicle.Cost = Convert.ToDouble(secondaryForm.EnterCost);
            newVehicle.ManufacturesYear = secondaryForm.EnterDateTime;
            newVehicle.Type = Convert.ToString(secondaryForm.EnterFirstPersonal);
            newVehicle.Power = Convert.ToDouble(secondaryForm.EnterSecondPersonal);
            newVehicle.Consumption = Convert.ToDouble(secondaryForm.EnterThirdPersonal);
            return newVehicle;
        }

        private Boat AddBoat(Boat newVehicle)
        {
            newVehicle.TypeVehicle = secondaryForm.EnterTypeVehicle;
            newVehicle.Name = secondaryForm.EnterName;
            newVehicle.SerialNumber = secondaryForm.EnterSerialNumber;
            newVehicle.Cost = Convert.ToDouble(secondaryForm.EnterCost);
            newVehicle.ManufacturesYear = secondaryForm.EnterDateTime;
            newVehicle.Speed = Convert.ToDouble(secondaryForm.EnterFirstPersonal);
            newVehicle.Draft = Convert.ToDouble(secondaryForm.EnterSecondPersonal);
            newVehicle.BoatCapacity = Convert.ToInt32(secondaryForm.EnterThirdPersonal);
            return newVehicle;
        }

        private Helicopter AddHelicopter(Helicopter newVehicle)
        {
            newVehicle.TypeVehicle = secondaryForm.EnterTypeVehicle;
            newVehicle.Name = secondaryForm.EnterName;
            newVehicle.SerialNumber = secondaryForm.EnterSerialNumber;
            newVehicle.Cost = Convert.ToInt32(secondaryForm.EnterCost);
            newVehicle.ManufacturesYear = secondaryForm.EnterDateTime;
            newVehicle.Range = Convert.ToInt32(secondaryForm.EnterFirstPersonal);
            newVehicle.Capacity = Convert.ToInt32(secondaryForm.EnterSecondPersonal);
            newVehicle.Speed = Convert.ToDouble(secondaryForm.EnterThirdPersonal);
            return newVehicle;
        }

        #endregion Add New Vehicle

        #region Buttons


        /// <summary>
        /// Button to add data
        /// </summary>        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();
            newCar.TypeVehicle = 'C';
            newCar.Name = "CCC";
            newCar.SerialNumber = "12345678901234567";
            newCar.Consumption = 18;
            newCar.Power = 23;
            newCar.Type = "NULL";
            newCar.Cost = 11;
            newCar.ManufacturesYear = DateTime.Today;
            bs_Main.Add(newCar);

            Boat newBoat = new Boat();
            newBoat.TypeVehicle = 'B';
            newBoat.Name = "EEE";
            newBoat.SerialNumber = "12345678";
            newBoat.ManufacturesYear = DateTime.Today;
            isNeedSave = true;
            bs_Main.Add(newBoat);

            secondaryForm = new SecondaryForm();
            dialogResult = secondaryForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IVehicle newVehicle = GetNewVehicle();                                
                bs_Main.Add(newVehicle);
            }

        }        

        private void btn_CreateRandomData_Click(object sender, EventArgs e)
        {
           
        }

       
        private void btn_EditData_Click(object sender, EventArgs e)
        {            
           EditData();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int rowToDelete = dgv_Main.Rows.GetFirstRow(
                DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                isNeedSave = true;
                bs_Main.RemoveAt(rowToDelete);                
            }

        }

        #endregion Buttons

        #region TextBox

        /// <summary>
        /// Checking the entered character
        /// </summary>        
        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tb_Search_KeyUp(object sender, KeyEventArgs e)
        {
            var founded = new List<IVehicle>();
            foreach (var vehicle in _vehicles)
            {
                if (vehicle.Name.Contains(tb_Search.Text) || vehicle.SerialNumber.Contains(tb_Search.Text))
                {
                    founded.Add(vehicle);
                }
            }
            dgv_Main.DataSource = founded;
        }
        #endregion TextBox

        #region MenuStrip

        /// <summary>
        /// Save data
        /// </summary>        
        private void ms_SaveTools_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// To upload the data
        /// </summary>   
        private void ms_LoadTools_Click(object sender, EventArgs e)
        {
            ofd_Main.AddExtension = true;
            ofd_Main.Filter = "Vehicle|*.vehicle";
            DialogResult result = ofd_Main.ShowDialog();
            if (result == DialogResult.OK)
            {
                //FileStream fileStream = new FileStream(ofd_Main.FileName, FileMode.OpenOrCreate);
                

                //List<IVehicle> deserialize = JsonConvert.DeserializeObject<IVehicle>(json);
                //fileStream.Dispose();

                //bs_Main.Clear();
                
                bs_Main.Clear();                
                //string deserialize = File.ReadAllText(ofd_Main.FileName, Encoding.GetEncoding(1251));
                List<IVehicle> list = JsonConvert.DeserializeObject<List<IVehicle>>(File.ReadAllText(ofd_Main.FileName));
                //IVehicle list = JsonConvert.DeserializeObject<IVehicle>(json);
                bs_Main.Add(_vehicles);

                //foreach (IVehicle vehicle in list)
                //{
                //    bs_Main.Add(vehicle);
                //}
            }
        }

        private void ms_SaveAsTool_Click(object sender, EventArgs e)
        {

        }

        private void ms_ExitTools_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion MenuStrip        

        private void EditData()
        {
            secondaryForm = new SecondaryForm();
            if (bs_Main.Current is Car)
            {
                secondaryForm.SetCarValue((Car)bs_Main.Current);
            }
            else if (bs_Main.Current is Boat)
            {
                secondaryForm.SetBoatValue((Boat)bs_Main.Current);
            }
            else if (bs_Main.Current is Helicopter)
            {
                secondaryForm.SetHelicopterValue((Helicopter)bs_Main.Current);
            }
            dialogResult = secondaryForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IVehicle newVehicle = GetNewVehicle();
                int index = bs_Main.CurrencyManager.Position;
                bs_Main.RemoveAt(index);
                bs_Main.Insert(index, newVehicle);
                isNeedSave = true;
            }
        }

        private void dgv_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditData();
        }
        private IVehicle GetNewVehicle()
        {
            IVehicle newVehicle = null;
            switch (secondaryForm.EnterTypeVehicle)
            {
                case 'C':
                {
                    newVehicle = AddCar(new Car());
                    break;
                }
                case 'B':
                {
                    newVehicle = AddBoat(new Boat());
                    break;
                }
                case 'H':
                {
                    newVehicle = AddHelicopter(new Helicopter());
                    break;
                }
            };
            return newVehicle;
        }

        private bool IsNeedSaveData()
        {
            return (_vehicles.Any() || isNeedSave) ? true : false;

        }

        private void ClosingForm()
        {
            if (IsNeedSaveData())
            {               
                DialogResult result = MessageBox.Show("Данные не сохранены ! Сохранить ?", "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    SaveData();
                }                
            }
            isNeedSave = false;
            
        }

       
    }
}
