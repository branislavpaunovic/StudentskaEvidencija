using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentskaEvidencija
{
    public partial class frm_Login : Form
    {
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnOK;

        public frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = btnOK; // Enter taster aktivira dugme
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Uzimanje korisničkog imena i lozinke iz tekstualnih polja
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Provera da li su kredencijali za administratora
            if (username == "administrator" && password == "password")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // Provera da li postoji korisnik u bazi
            if (ProveriKorisnikaUBazi(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // Ako ni jedna provera nije prošla — prikazujemo poruku sa opcijom DA/NE
            DialogResult odgovor = MessageBox.Show(
                "Pogrešili ste korisničko ime! Da li želite da pokušate ponovo?",
                "Greška",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (odgovor == DialogResult.Yes)
            {
                // Fokusiramo korisnika nazad na korisničko ime
                txtUsername.Focus();
                txtUsername.SelectAll();
            }
            else
            {
                // Izlazak iz aplikacije
                Application.Exit();
            }
        }

        private bool ProveriKorisnikaUBazi(string username, string password)
        {
            // Uzimamo konekcioni string iz App.config fajla
            string connStr = ConfigurationManager.ConnectionStrings["StudentskaEvidencija"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                // Otvaramo konekciju
                conn = new SqlConnection(connStr);
                conn.Open();

                // Upit koji proverava da li postoji korisnik sa datim podacima
                string query = "SELECT COUNT(*) FROM dbo.Korisnik WHERE Username = @username AND Lozinka = @password";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Prikaz poruke o grešci
                MessageBox.Show("Greška pri proveri korisničkih podataka:\n" + ex.Message,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Osiguravamo da se konekcija zatvori
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
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
        }
    }
}