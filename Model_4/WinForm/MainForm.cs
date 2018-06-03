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
        private EditForm editForm;
        private AddForm addForm;
        
        FileStream fstream = null;
        List<IVehicle> list;

        public MainForm()
        {               
            InitializeComponent();
            list = new List<IVehicle>();
            Car newCar = new Car();
            newCar.Name = "AAA";
            newCar.SerialNumber = "12345678901234567";
            newCar.Consumption = 18;
            newCar.Power = 23;
            newCar.Type = 2;
            newCar.Cost = 2321;
            newCar.ManufacturesYear = new DateTime(2018, 02, 12);
            list.Add(newCar);
            bindingSource1.DataSource = list;
            dgv_Main.DataSource = bindingSource1;            
        }   

        private void SaveData()
        {
            if (!(list.Any()))
            {
                MessageBox.Show("List is empty. Nothing to save");
            }
            else
            {
                string serialized = JsonConvert.SerializeObject(list);
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

       

        #region Buttons


        /// <summary>
        /// Button to add data
        /// </summary>        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Car newCar=new Car();
            newCar.Name = "AAA";
            newCar.SerialNumber = "12345678901234567";
            newCar.Consumption = 18;
            newCar.Power = 23;
            newCar.Type = 2;
            newCar.Cost = 2321;
            newCar.ManufacturesYear = new DateTime(2018,02,12);            
            list.Add(newCar);
            bindingSource1.DataSource = list;            
            //dgv_Main.DataSource = bindingSource1;
            //dgv_Main.Rows.Add(bindingSource1);

            addForm = new AddForm();
            addForm.ShowDialog();
        }        

        private void btn_CreateRandomData_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditData_Click(object sender, EventArgs e)
        {
            EditForm fEdit = new EditForm(list);
            fEdit.ShowDialog();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

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
            foreach (var vehicle in list)
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
