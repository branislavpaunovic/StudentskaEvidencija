using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;  // ako koristiš connection string iz App.config
using StudentskaEvidencija.Services;
using StudentskaEvidencija.Auth;

namespace StudentskaEvidencija
{
    public partial class frm_Login : Form
    {
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;


        private readonly LoginService _loginService;

        public frm_Login()
        {
            InitializeComponent();

            // Uzimamo konekcioni string iz App.config fajla
            string connString = ConfigurationManager.ConnectionStrings["StudentskaEvidencija"].ConnectionString;
            _loginService = new LoginService(connString);

            // Omogućavamo da Enter aktivira dugme
            this.AcceptButton = btnOK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            bool success = _loginService.TryLogin(username, password);

            if (success)
            {
                var currentUser = LoginManager.Instance.CurrentUser;
                MessageBox.Show(
                    $"Dobrodošao {currentUser.Ime} {currentUser.Prezime}\nUloga: {currentUser.Role}",
                    "Uspešna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                frm_MainForm main = new frm_MainForm();
                this.Hide();
                main.Show();
            }
            else
            {
                _loginService.HandleInvalidLogin(this);
            }
        }

        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // Dugme OK
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(115, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // Labela za Username
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name :";

            // Labela za Password
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";

            // Tekstualno polje za Username
            this.txtUsername.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(131, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 31);
            this.txtUsername.TabIndex = 3;

            // Tekstualno polje za Password
            this.txtPassword.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(131, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 31);
            this.txtPassword.TabIndex = 4;

            // Login forma
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // Trenutno prazno — ovde možeš dodati logiku pri učitavanju forme
            txtUsername.Focus();
        }
    }
}