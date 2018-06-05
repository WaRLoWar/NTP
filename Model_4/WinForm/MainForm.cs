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


namespace WinForm
{
    public partial class MainForm : Form
    {        
        private SecondaryForm secondaryForm;
        private DialogResult dialogResult;
        FileStream fstream = null;
        private List<IVehicle> _vehicles;        

        public MainForm()
        {               
            InitializeComponent();
            _vehicles = new List<IVehicle>();
            bs_Main.DataSource = _vehicles;
            dgv_Main.DataSource = bs_Main;            

            //Car newCar = new Car();
            //newCar.Name = "AAA";
            //newCar.SerialNumber = "12345678901234567";
            //newCar.Consumption = 18;
            //newCar.Power = 23;
            //newCar.Type = "NULL";
            //newCar.Cost = 2321;
            //newCar.ManufacturesYear = new DateTime(2018, 02, 12);            
            //_vehicles.Add(newCar);
            //bs_Main.DataSource= _vehicles;
            //dgv_Main.DataSource = bs_Main;            
            ////dgv_Main.DataSource = bs_Main;

            //Car car = new Car();
            //car.Name = "BBB";
            //car.SerialNumber = "12345678901234567";
            //car.Consumption = 18;
            //car.Power = 23;
            //car.Type = "NULL";
            //car.Cost = 2321;
            //car.ManufacturesYear = DateTime.Today;
            //_vehicles.Add(car);
            //dgv_Main.DataSource = _vehicles;
            //bs_Main.DataSource = _vehicles;
            //dgv_Main.DataSource = bs_Main;

        }

        private void SaveData()
        {
            if (!(_vehicles.Any()))
            {
                MessageBox.Show("List is empty. Nothing to save");
            }
            else
            {
                string serialized = JsonConvert.SerializeObject(_vehicles);
                MessageBox.Show(serialized);

                DirectoryInfo dirInfo = CreateDirectory();
                fstream = CreateFile(dirInfo, serialized);
                FileInfo fileInfo = CreateFile(dirInfo);

            }
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
            FileInfo fileInfo = new FileInfo(dir.FullName + "text.json");
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

               
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (JsonConvert.DeserializeObject<IVehicle>  
        }

        #region Add New Vehicle

        private Car AddCar(Car newVehicle)
        {
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
            Car newCar= new Car();
            newCar.Name = "CCC";
            newCar.SerialNumber = "12345678901234567";
            newCar.Consumption = 18;
            newCar.Power = 23;
            newCar.Type = "NULL";
            newCar.Cost = 11;            
            newCar.ManufacturesYear = DateTime.Today;            
            //_vehicles.Add(newCar);
            bs_Main.Add(newCar);

            Boat newBoat = new Boat();
            newBoat.Name = "EEE";
            newBoat.SerialNumber = "12345678";
            newBoat.ManufacturesYear = DateTime.Today;
            bs_Main.Add(newBoat);
            //addForm = new AddForm();
            //dialogResult = addForm.ShowDialog();
            //if (dialogResult == DialogResult.OK)
            //{
            //    IVehicle newVehicle = null;
            //    switch (addForm.EnterTypeVehicle)
            //    {
            //        case 'C':
            //            {
            //                newVehicle = AddCar(new Car());
            //                break;
            //            }
            //        case 'B':
            //            {
            //                newVehicle = AddBoat(new Boat());
            //                break;
            //            }
            //        case 'H':
            //            {
            //                newVehicle = AddHelicopter(new Helicopter());
            //                break;
            //            }
            //    };
            //    _vehicles.Add(newVehicle);
            //    dgv_Main.DataSource = _vehicles;
            //}

        }

        private void btn_CreateRandomData_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditData_Click(object sender, EventArgs e)
        {
            secondaryForm = new SecondaryForm();
            secondaryForm.ShowDialog();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int rowToDelete = dgv_Main.Rows.GetFirstRow(
                DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {                
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

        }

        private void ms_ExitTools_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion MenuStrip        

        #region  DataGrivView Menu


        #endregion DataGrivView Menu
     
    }
}
