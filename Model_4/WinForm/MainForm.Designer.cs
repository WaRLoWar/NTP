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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.gb_BoxSubMain1 = new System.Windows.Forms.GroupBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_EditData = new System.Windows.Forms.Button();
            this.btn_CreateRandomData = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bs_Main = new System.Windows.Forms.BindingSource(this.components);
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
            this.gb_BoxMain.Controls.Add(this.dgv_Main);
            this.gb_BoxMain.Controls.Add(this.btn_Delete);
            this.gb_BoxMain.Controls.Add(this.gb_BoxSubMain1);
            this.gb_BoxMain.Controls.Add(this.btn_EditData);
            this.gb_BoxMain.Controls.Add(this.btn_CreateRandomData);
            this.gb_BoxMain.Controls.Add(this.btn_Add);
            this.gb_BoxMain.Location = new System.Drawing.Point(12, 27);
            this.gb_BoxMain.Name = "gb_BoxMain";
            this.gb_BoxMain.Size = new System.Drawing.Size(611, 278);
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
            this.dgv_Main.Location = new System.Drawing.Point(6, 19);
            this.dgv_Main.Name = "dgv_Main";
            this.dgv_Main.ReadOnly = true;
            this.dgv_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Main.Size = new System.Drawing.Size(445, 217);
            this.dgv_Main.TabIndex = 11;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(194, 242);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 26);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // gb_BoxSubMain1
            // 
            this.gb_BoxSubMain1.Controls.Add(this.tb_Search);
            this.gb_BoxSubMain1.Controls.Add(this.btn_Search);
            this.gb_BoxSubMain1.Location = new System.Drawing.Point(457, 19);
            this.gb_BoxSubMain1.Name = "gb_BoxSubMain1";
            this.gb_BoxSubMain1.Size = new System.Drawing.Size(143, 82);
            this.gb_BoxSubMain1.TabIndex = 9;
            this.gb_BoxSubMain1.TabStop = false;
            this.gb_BoxSubMain1.Text = "Search";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(6, 19);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(121, 20);
            this.tb_Search.TabIndex = 7;
            this.tb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Search_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 24);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_EditData
            // 
            this.btn_EditData.Location = new System.Drawing.Point(100, 242);
            this.btn_EditData.Name = "btn_EditData";
            this.btn_EditData.Size = new System.Drawing.Size(88, 26);
            this.btn_EditData.TabIndex = 6;
            this.btn_EditData.Text = "Edit";
            this.btn_EditData.UseVisualStyleBackColor = true;
            this.btn_EditData.Click += new System.EventHandler(this.btn_EditData_Click);
            // 
            // btn_CreateRandomData
            // 
            this.btn_CreateRandomData.Location = new System.Drawing.Point(288, 242);
            this.btn_CreateRandomData.Name = "btn_CreateRandomData";
            this.btn_CreateRandomData.Size = new System.Drawing.Size(143, 26);
            this.btn_CreateRandomData.TabIndex = 4;
            this.btn_CreateRandomData.Text = "Create Random Data";
            this.btn_CreateRandomData.UseVisualStyleBackColor = true;
            this.btn_CreateRandomData.Click += new System.EventHandler(this.btn_CreateRandomData_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 242);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 26);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add Vehicle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ms_SaveTools_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.ms_LoadTools_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ms_ExitTools_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 313);
            this.Controls.Add(this.gb_BoxMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ModelLoader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_CreateRandomData;
        private System.Windows.Forms.Button btn_EditData;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.GroupBox gb_BoxSubMain1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource bs_Main;
        private System.Windows.Forms.DataGridView dgv_Main;
    }
}

