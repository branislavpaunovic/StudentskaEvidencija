namespace StudentskaEvidencija
{
    partial class frm_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student));
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.addNewButton1 = new StudentskaEvidencija.Controls.AddNewButton();
            this.exitButton1 = new StudentskaEvidencija.Controls.ExitButton();
            this.saveButton1 = new StudentskaEvidencija.Controls.SaveButton();
            this.editButton1 = new StudentskaEvidencija.EditButton();
            this.deleteButton1 = new StudentskaEvidencija.Controls.DeleteButton();
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.btnFirst = new StudentskaEvidencija.Controls.AddNewButton();
            this.btnPrevious = new StudentskaEvidencija.Controls.AddNewButton();
            this.btnNext = new StudentskaEvidencija.Controls.AddNewButton();
            this.btnLast = new StudentskaEvidencija.Controls.AddNewButton();
            this.tlpStudentNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblBrojIndeksa = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.lblBrojKuce = new System.Windows.Forms.Label();
            this.lblPtt = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.lblSmer = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpActions.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.tlpStudentNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpActions
            // 
            this.tlpActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpActions.ColumnCount = 5;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.Controls.Add(this.addNewButton1, 0, 0);
            this.tlpActions.Controls.Add(this.exitButton1, 4, 0);
            this.tlpActions.Controls.Add(this.saveButton1, 3, 0);
            this.tlpActions.Controls.Add(this.editButton1, 1, 0);
            this.tlpActions.Controls.Add(this.deleteButton1, 2, 0);
            this.tlpActions.Location = new System.Drawing.Point(2, 740);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.Size = new System.Drawing.Size(1020, 60);
            this.tlpActions.TabIndex = 0;
            // 
            // addNewButton1
            // 
            this.addNewButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewButton1.Location = new System.Drawing.Point(3, 3);
            this.addNewButton1.Name = "addNewButton1";
            this.addNewButton1.Size = new System.Drawing.Size(198, 54);
            this.addNewButton1.TabIndex = 0;
            this.addNewButton1.Text = "NEW";
            this.addNewButton1.UseVisualStyleBackColor = true;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(819, 3);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(198, 54);
            this.exitButton1.TabIndex = 2;
            this.exitButton1.Text = "EXIT";
            this.exitButton1.UseVisualStyleBackColor = true;
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(615, 3);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(198, 54);
            this.saveButton1.TabIndex = 4;
            this.saveButton1.Text = "SAVE";
            this.saveButton1.UseVisualStyleBackColor = true;
            // 
            // editButton1
            // 
            this.editButton1.Location = new System.Drawing.Point(207, 3);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(198, 54);
            this.editButton1.TabIndex = 5;
            this.editButton1.Text = "EDIT";
            this.editButton1.UseVisualStyleBackColor = true;
            // 
            // deleteButton1
            // 
            this.deleteButton1.Location = new System.Drawing.Point(411, 3);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(198, 54);
            this.deleteButton1.TabIndex = 6;
            this.deleteButton1.Text = "DELETE";
            this.deleteButton1.UseVisualStyleBackColor = true;
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpNavigation.ColumnCount = 4;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNavigation.Controls.Add(this.btnLast, 3, 0);
            this.tlpNavigation.Controls.Add(this.btnNext, 2, 0);
            this.tlpNavigation.Controls.Add(this.btnPrevious, 1, 0);
            this.tlpNavigation.Controls.Add(this.btnFirst, 0, 0);
            this.tlpNavigation.Font = new System.Drawing.Font("Poppins Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpNavigation.Location = new System.Drawing.Point(2, 680);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 1;
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Size = new System.Drawing.Size(1020, 60);
            this.tlpNavigation.TabIndex = 1;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(249, 54);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.Location = new System.Drawing.Point(258, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(249, 54);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Location = new System.Drawing.Point(513, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(249, 54);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.Location = new System.Drawing.Point(768, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(249, 54);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // tlpStudentNavigation
            // 
            this.tlpStudentNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tlpStudentNavigation.BackColor = System.Drawing.Color.Transparent;
            this.tlpStudentNavigation.ColumnCount = 2;
            this.tlpStudentNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStudentNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStudentNavigation.Controls.Add(this.lblIme, 0, 0);
            this.tlpStudentNavigation.Controls.Add(this.lblPrezime, 0, 1);
            this.tlpStudentNavigation.Controls.Add(this.lblDatumRodjenja, 0, 2);
            this.tlpStudentNavigation.Controls.Add(this.lblBrojIndeksa, 0, 3);
            this.tlpStudentNavigation.Controls.Add(this.lblTelefon, 0, 4);
            this.tlpStudentNavigation.Controls.Add(this.lblEmail, 0, 5);
            this.tlpStudentNavigation.Controls.Add(this.lblUlica, 0, 6);
            this.tlpStudentNavigation.Controls.Add(this.lblBrojKuce, 0, 7);
            this.tlpStudentNavigation.Controls.Add(this.lblPtt, 0, 8);
            this.tlpStudentNavigation.Controls.Add(this.lblGrad, 0, 9);
            this.tlpStudentNavigation.Controls.Add(this.lblZemlja, 0, 10);
            this.tlpStudentNavigation.Controls.Add(this.lblSmer, 0, 11);
            this.tlpStudentNavigation.Controls.Add(this.lblPol, 0, 12);
            this.tlpStudentNavigation.Controls.Add(this.lblAdministrator, 0, 13);
            this.tlpStudentNavigation.Controls.Add(this.textBox1, 1, 0);
            this.tlpStudentNavigation.Location = new System.Drawing.Point(2, 5);
            this.tlpStudentNavigation.Name = "tlpStudentNavigation";
            this.tlpStudentNavigation.RowCount = 14;
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142858F));
            this.tlpStudentNavigation.Size = new System.Drawing.Size(1020, 675);
            this.tlpStudentNavigation.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIme.AutoSize = true;
            this.lblIme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIme.Location = new System.Drawing.Point(5, 10);
            this.lblIme.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(130, 33);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime studenta :";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrezime.Location = new System.Drawing.Point(5, 58);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(164, 33);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "Prezime studenta :";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(5, 106);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(143, 33);
            this.lblDatumRodjenja.TabIndex = 5;
            this.lblDatumRodjenja.Text = "Datum rođenja :";
            this.lblDatumRodjenja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojIndeksa
            // 
            this.lblBrojIndeksa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojIndeksa.AutoSize = true;
            this.lblBrojIndeksa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBrojIndeksa.Location = new System.Drawing.Point(5, 154);
            this.lblBrojIndeksa.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBrojIndeksa.Name = "lblBrojIndeksa";
            this.lblBrojIndeksa.Size = new System.Drawing.Size(119, 33);
            this.lblBrojIndeksa.TabIndex = 7;
            this.lblBrojIndeksa.Text = "Broj indeksa :";
            this.lblBrojIndeksa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefon.Location = new System.Drawing.Point(5, 202);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(80, 33);
            this.lblTelefon.TabIndex = 9;
            this.lblTelefon.Text = "Telefon :";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Location = new System.Drawing.Point(5, 250);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 33);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUlica
            // 
            this.lblUlica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUlica.AutoSize = true;
            this.lblUlica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUlica.Location = new System.Drawing.Point(5, 298);
            this.lblUlica.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(60, 33);
            this.lblUlica.TabIndex = 13;
            this.lblUlica.Text = "Ulica :";
            this.lblUlica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojKuce
            // 
            this.lblBrojKuce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojKuce.AutoSize = true;
            this.lblBrojKuce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBrojKuce.Location = new System.Drawing.Point(5, 346);
            this.lblBrojKuce.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBrojKuce.Name = "lblBrojKuce";
            this.lblBrojKuce.Size = new System.Drawing.Size(102, 33);
            this.lblBrojKuce.TabIndex = 15;
            this.lblBrojKuce.Text = "Kućni broj :";
            this.lblBrojKuce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPtt
            // 
            this.lblPtt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPtt.AutoSize = true;
            this.lblPtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPtt.Location = new System.Drawing.Point(5, 394);
            this.lblPtt.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblPtt.Name = "lblPtt";
            this.lblPtt.Size = new System.Drawing.Size(48, 33);
            this.lblPtt.TabIndex = 17;
            this.lblPtt.Text = "PTT :";
            this.lblPtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            this.lblGrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrad.AutoSize = true;
            this.lblGrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrad.Location = new System.Drawing.Point(5, 442);
            this.lblGrad.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(60, 33);
            this.lblGrad.TabIndex = 19;
            this.lblGrad.Text = "Grad :";
            this.lblGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZemlja
            // 
            this.lblZemlja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblZemlja.Location = new System.Drawing.Point(5, 490);
            this.lblZemlja.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(75, 33);
            this.lblZemlja.TabIndex = 21;
            this.lblZemlja.Text = "Zemlja :";
            this.lblZemlja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmer
            // 
            this.lblSmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSmer.AutoSize = true;
            this.lblSmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSmer.Location = new System.Drawing.Point(5, 538);
            this.lblSmer.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblSmer.Name = "lblSmer";
            this.lblSmer.Size = new System.Drawing.Size(63, 33);
            this.lblSmer.TabIndex = 23;
            this.lblSmer.Text = "Smer :";
            this.lblSmer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPol
            // 
            this.lblPol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPol.AutoSize = true;
            this.lblPol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPol.Location = new System.Drawing.Point(5, 586);
            this.lblPol.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(44, 33);
            this.lblPol.TabIndex = 25;
            this.lblPol.Text = "Pol :";
            this.lblPol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdministrator.Location = new System.Drawing.Point(5, 634);
            this.lblAdministrator.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(132, 36);
            this.lblAdministrator.TabIndex = 27;
            this.lblAdministrator.Text = "Administrator :";
            this.lblAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(515, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 31);
            this.textBox1.TabIndex = 2;
            // 
            // frm_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 801);
            this.Controls.Add(this.tlpStudentNavigation);
            this.Controls.Add(this.tlpNavigation);
            this.Controls.Add(this.tlpActions);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student";
            this.Text = "Evidencija studenata";
            this.tlpActions.ResumeLayout(false);
            this.tlpNavigation.ResumeLayout(false);
            this.tlpStudentNavigation.ResumeLayout(false);
            this.tlpStudentNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private Controls.AddNewButton addNewButton1;
        private Controls.ExitButton exitButton1;
        private Controls.SaveButton saveButton1;
        private EditButton editButton1;
        private Controls.DeleteButton deleteButton1;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private Controls.AddNewButton btnLast;
        private Controls.AddNewButton btnNext;
        private Controls.AddNewButton btnPrevious;
        private Controls.AddNewButton btnFirst;
        private System.Windows.Forms.TableLayoutPanel tlpStudentNavigation;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblBrojIndeksa;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label lblBrojKuce;
        private System.Windows.Forms.Label lblPtt;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Label lblSmer;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.TextBox textBox1;
    }
}