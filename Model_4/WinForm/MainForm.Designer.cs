namespace WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_BoxMain = new System.Windows.Forms.GroupBox();
            this.dgv_Main = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.gb_BoxSubMain1 = new System.Windows.Forms.GroupBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_EditData = new System.Windows.Forms.Button();
            this.btn_CreateRandomData = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_NewFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_SaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_SaveAsTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_OpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bs_Main = new System.Windows.Forms.BindingSource(this.components);
            this.ofd_Main = new System.Windows.Forms.OpenFileDialog();
            this.sfd_Main = new System.Windows.Forms.SaveFileDialog();
            this.vehicleControl_MainForm = new WinForm.VehicleControl();
            this.gb_BoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).BeginInit();
            this.gb_BoxSubMain1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_BoxMain
            // 
            this.gb_BoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_BoxMain.Controls.Add(this.vehicleControl_MainForm);
            this.gb_BoxMain.Controls.Add(this.dgv_Main);
            this.gb_BoxMain.Controls.Add(this.btn_Remove);
            this.gb_BoxMain.Controls.Add(this.gb_BoxSubMain1);
            this.gb_BoxMain.Controls.Add(this.btn_EditData);
            this.gb_BoxMain.Controls.Add(this.btn_CreateRandomData);
            this.gb_BoxMain.Controls.Add(this.btn_Add);
            this.gb_BoxMain.Location = new System.Drawing.Point(12, 27);
            this.gb_BoxMain.Name = "gb_BoxMain";
            this.gb_BoxMain.Size = new System.Drawing.Size(788, 340);
            this.gb_BoxMain.TabIndex = 0;
            this.gb_BoxMain.TabStop = false;
            this.gb_BoxMain.Text = "Main";
            // 
            // dgv_Main
            // 
            this.dgv_Main.AllowUserToAddRows = false;
            this.dgv_Main.AllowUserToDeleteRows = false;
            this.dgv_Main.AllowUserToResizeColumns = false;
            this.dgv_Main.AllowUserToResizeRows = false;
            this.dgv_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Main.Location = new System.Drawing.Point(6, 73);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.ReadOnly = true;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(485, 181);
            this.dgv_Main.StandardTab = true;
            this.dgv_Main.TabIndex = 2;
            this.dgv_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Main_CellClick);
            this.dgv_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Main_CellDoubleClick);
            this.dgv_Main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Main_KeyDown);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(351, 260);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(140, 30);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // gb_BoxSubMain1
            // 
            this.gb_BoxSubMain1.Controls.Add(this.tb_Search);
            this.gb_BoxSubMain1.Location = new System.Drawing.Point(6, 19);
            this.gb_BoxSubMain1.Name = "gb_BoxSubMain1";
            this.gb_BoxSubMain1.Size = new System.Drawing.Size(168, 48);
            this.gb_BoxSubMain1.TabIndex = 1;
            this.gb_BoxSubMain1.TabStop = false;
            this.gb_BoxSubMain1.Text = "Search";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(6, 19);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(156, 20);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Search_KeyPress);
            this.tb_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tb_Search_KeyUp);
            // 
            // btn_EditData
            // 
            this.btn_EditData.Location = new System.Drawing.Point(176, 260);
            this.btn_EditData.Name = "btn_EditData";
            this.btn_EditData.Size = new System.Drawing.Size(140, 30);
            this.btn_EditData.TabIndex = 5;
            this.btn_EditData.Text = "Edit";
            this.btn_EditData.UseVisualStyleBackColor = true;
            this.btn_EditData.Click += new System.EventHandler(this.Btn_EditData_Click);
            // 
            // btn_CreateRandomData
            // 
            this.btn_CreateRandomData.Location = new System.Drawing.Point(176, 296);
            this.btn_CreateRandomData.Name = "btn_CreateRandomData";
            this.btn_CreateRandomData.Size = new System.Drawing.Size(140, 30);
            this.btn_CreateRandomData.TabIndex = 7;
            this.btn_CreateRandomData.Text = "Create Random Data";
            this.btn_CreateRandomData.UseVisualStyleBackColor = true;
            this.btn_CreateRandomData.Click += new System.EventHandler(this.Btn_CreateRandomData_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 260);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(140, 30);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add Vehicle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_NewFileTool,
            this.ms_SaveTool,
            this.ms_SaveAsTool,
            this.ms_OpenTool,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ms_NewFileTool
            // 
            this.ms_NewFileTool.Name = "ms_NewFileTool";
            this.ms_NewFileTool.Size = new System.Drawing.Size(152, 22);
            this.ms_NewFileTool.Text = "New";
            this.ms_NewFileTool.Click += new System.EventHandler(this.Ms_NewFileTool_Click);
            // 
            // ms_SaveTool
            // 
            this.ms_SaveTool.Name = "ms_SaveTool";
            this.ms_SaveTool.Size = new System.Drawing.Size(152, 22);
            this.ms_SaveTool.Text = "Save";
            this.ms_SaveTool.Click += new System.EventHandler(this.Ms_SaveTools_Click);
            // 
            // ms_SaveAsTool
            // 
            this.ms_SaveAsTool.Name = "ms_SaveAsTool";
            this.ms_SaveAsTool.Size = new System.Drawing.Size(152, 22);
            this.ms_SaveAsTool.Text = "Save as";
            this.ms_SaveAsTool.Click += new System.EventHandler(this.Ms_SaveAsTool_Click);
            // 
            // ms_OpenTool
            // 
            this.ms_OpenTool.Name = "ms_OpenTool";
            this.ms_OpenTool.Size = new System.Drawing.Size(152, 22);
            this.ms_OpenTool.Text = "Open";
            this.ms_OpenTool.Click += new System.EventHandler(this.Ms_LoadTools_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Ms_ExitTools_Click);
            // 
            // ofd_Main
            // 
            this.ofd_Main.FileName = "openFileDialog1";
            // 
            // vehicleControl_MainForm
            // 
            this.vehicleControl_MainForm.Location = new System.Drawing.Point(497, 10);
            this.vehicleControl_MainForm.Name = "vehicleControl_MainForm";
            this.vehicleControl_MainForm.Size = new System.Drawing.Size(280, 317);
            this.vehicleControl_MainForm.TabIndex = 3;
            this.vehicleControl_MainForm.Vehicle = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 379);
            this.Controls.Add(this.gb_BoxMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ModelLoader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.gb_BoxMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Main)).EndInit();
            this.gb_BoxSubMain1.ResumeLayout(false);
            this.gb_BoxSubMain1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_BoxMain;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_CreateRandomData;
        private System.Windows.Forms.Button btn_EditData;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.GroupBox gb_BoxSubMain1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_SaveTool;
        private System.Windows.Forms.ToolStripMenuItem ms_OpenTool;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_SaveAsTool;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource bs_Main;
        private System.Windows.Forms.DataGridView dgv_Main;
        private System.Windows.Forms.OpenFileDialog ofd_Main;
        private System.Windows.Forms.SaveFileDialog sfd_Main;
        private System.Windows.Forms.ToolStripMenuItem ms_NewFileTool;
        private VehicleControl vehicleControl_MainForm;
    }
}
