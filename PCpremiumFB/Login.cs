using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PCpremiumFB.Data;

namespace PCpremiumFB
{
    public partial class Login : Form
    {
        public static List<LoginItems> loginList;
        Thread th;
        private string login;
        private string password;

        public Login()
        {
            InitializeComponent();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnEnter_Click(object sender, EventArgs e)
        {
            string pass = "";
            loginList = new List<LoginItems>();
            Conn conn = new Conn();
            Task.Run(() => conn.LoginGet(txtLogin.Text)).Wait();
            foreach (var item in loginList) {
                if (item.UserLogin == txtLogin.Text && item.UserPassword == txtPassword.Text)
                {
                    pass = "live";
                    AccessCheck.User = txtLogin.Text;
                }
            }
            userPass(pass);
        }

        private void openMainWind() {
            Application.Run(new Form1());
            
        }

        private void txtLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Login") {
                txtLogin.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
                login = txtLogin.Text;
                txtLogin.Clear();
            }
        }

        private void txtLogin_MouseLeave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "") {
                txtLogin.ForeColor = SystemColors.ScrollBar;
                txtLogin.Text = login;
            }
        }

        private void textPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password") {
                txtPassword.ForeColor = Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
                password = txtPassword.Text;
                txtPassword.Clear();
            }
        }

        private void textPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = SystemColors.ScrollBar;
                txtPassword.Text = password;
            }
        }

        private void userPass(string needle) {
            if (needle == "live")
            {
                this.Close();
                th = new Thread(openMainWind);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else {
                MessageBox.Show("Nie, nie, nie! Nie oszukasz mnie... " + "Nie masz dostępu do tej bazy!" + "You should no pass!...");
            }
        }
    }
}
