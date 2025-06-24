namespace StudentskaEvidencija
{
    partial class frm_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainForm));
            this.pic_BAPUSS = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmd_Student = new System.Windows.Forms.Button();
            this.btn_Odsek = new System.Windows.Forms.Button();
            this.cmd_DataGrid = new System.Windows.Forms.Button();
            this.cmd_ListView = new System.Windows.Forms.Button();
            this.cmd_Custom = new System.Windows.Forms.Button();
            this.cmd_Print = new System.Windows.Forms.Button();
            this.cmd_Help = new System.Windows.Forms.Button();
            this.cmd_About = new System.Windows.Forms.Button();
            this.cmd_Admin = new System.Windows.Forms.Button();
            this.exitButton1 = new StudentskaEvidencija.Controls.ExitButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BAPUSS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_BAPUSS
            // 
            this.pic_BAPUSS.BackColor = System.Drawing.Color.Transparent;
            this.pic_BAPUSS.Image = ((System.Drawing.Image)(resources.GetObject("pic_BAPUSS.Image")));
            this.pic_BAPUSS.Location = new System.Drawing.Point(0, 0);
            this.pic_BAPUSS.Name = "pic_BAPUSS";
            this.pic_BAPUSS.Size = new System.Drawing.Size(366, 144);
            this.pic_BAPUSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_BAPUSS.TabIndex = 0;
            this.pic_BAPUSS.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmd_Student, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Odsek, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmd_DataGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmd_ListView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmd_Custom, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmd_Print, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmd_Help, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmd_About, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmd_Admin, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.exitButton1, 0, 9);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cmd_Student
            // 
            this.cmd_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Student.Location = new System.Drawing.Point(5, 5);
            this.cmd_Student.Name = "cmd_Student";
            this.cmd_Student.Size = new System.Drawing.Size(356, 43);
            this.cmd_Student.TabIndex = 11;
            this.cmd_Student.Text = "STUDENT";
            this.cmd_Student.UseVisualStyleBackColor = true;
            this.cmd_Student.Click += new System.EventHandler(this.cmd_Student_Click);
            // 
            // btn_Odsek
            // 
            this.btn_Odsek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odsek.Location = new System.Drawing.Point(5, 62);
            this.btn_Odsek.Name = "btn_Odsek";
            this.btn_Odsek.Size = new System.Drawing.Size(356, 49);
            this.btn_Odsek.TabIndex = 3;
            this.btn_Odsek.Text = "STUDY PROGRAM";
            this.btn_Odsek.UseVisualStyleBackColor = true;
            this.btn_Odsek.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmd_DataGrid
            // 
            this.cmd_DataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_DataGrid.Location = new System.Drawing.Point(5, 119);
            this.cmd_DataGrid.Name = "cmd_DataGrid";
            this.cmd_DataGrid.Size = new System.Drawing.Size(356, 49);
            this.cmd_DataGrid.TabIndex = 4;
            this.cmd_DataGrid.Text = "DATA GRID VIEW";
            this.cmd_DataGrid.UseVisualStyleBackColor = true;
            this.cmd_DataGrid.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmd_ListView
            // 
            this.cmd_ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_ListView.Location = new System.Drawing.Point(5, 176);
            this.cmd_ListView.Name = "cmd_ListView";
            this.cmd_ListView.Size = new System.Drawing.Size(356, 49);
            this.cmd_ListView.TabIndex = 5;
            this.cmd_ListView.Text = "DATA LIST VIEW";
            this.cmd_ListView.UseVisualStyleBackColor = true;
            // 
            // cmd_Custom
            // 
            this.cmd_Custom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Custom.Location = new System.Drawing.Point(5, 233);
            this.cmd_Custom.Name = "cmd_Custom";
            this.cmd_Custom.Size = new System.Drawing.Size(356, 49);
            this.cmd_Custom.TabIndex = 6;
            this.cmd_Custom.Text = "CUSTOM REPORT";
            this.cmd_Custom.UseVisualStyleBackColor = true;
            // 
            // cmd_Print
            // 
            this.cmd_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Print.Location = new System.Drawing.Point(5, 290);
            this.cmd_Print.Name = "cmd_Print";
            this.cmd_Print.Size = new System.Drawing.Size(356, 49);
            this.cmd_Print.TabIndex = 7;
            this.cmd_Print.Text = "PRINT PRIVEW";
            this.cmd_Print.UseVisualStyleBackColor = true;
            // 
            // cmd_Help
            // 
            this.cmd_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Help.Location = new System.Drawing.Point(5, 347);
            this.cmd_Help.Name = "cmd_Help";
            this.cmd_Help.Size = new System.Drawing.Size(356, 49);
            this.cmd_Help.TabIndex = 8;
            this.cmd_Help.Text = "HELP";
            this.cmd_Help.UseVisualStyleBackColor = true;
            // 
            // cmd_About
            // 
            this.cmd_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_About.Location = new System.Drawing.Point(5, 404);
            this.cmd_About.Name = "cmd_About";
            this.cmd_About.Size = new System.Drawing.Size(356, 49);
            this.cmd_About.TabIndex = 9;
            this.cmd_About.Text = "ABOUT";
            this.cmd_About.UseVisualStyleBackColor = true;
            // 
            // cmd_Admin
            // 
            this.cmd_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Admin.Location = new System.Drawing.Point(5, 461);
            this.cmd_Admin.Name = "cmd_Admin";
            this.cmd_Admin.Size = new System.Drawing.Size(356, 49);
            this.cmd_Admin.TabIndex = 10;
            this.cmd_Admin.Text = "ADMIN PANEL";
            this.cmd_Admin.UseVisualStyleBackColor = true;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(5, 518);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(356, 50);
            this.exitButton1.TabIndex = 12;
            this.exitButton1.Text = "EXIT";
            this.exitButton1.UseVisualStyleBackColor = true;
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 857);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pic_BAPUSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentska Evidencija";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BAPUSS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_BAPUSS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmd_Admin;
        private System.Windows.Forms.Button cmd_About;
        private System.Windows.Forms.Button cmd_Help;
        private System.Windows.Forms.Button cmd_Print;
        private System.Windows.Forms.Button cmd_Custom;
        private System.Windows.Forms.Button cmd_ListView;
        private System.Windows.Forms.Button cmd_DataGrid;
        private System.Windows.Forms.Button btn_Odsek;
        private System.Windows.Forms.Button cmd_Student;
        private Controls.ExitButton exitButton1;
    }
}

