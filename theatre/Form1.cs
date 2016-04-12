using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using BL;
using BEL;

namespace theatre
{
    public partial class Form1 : Form
    {
        public UserService us = new UserService();
        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string user = tb_user.Text;
            string pass = tb_pass.Text;

            string role = us.login(user, pass);
            if (role == "a")
            {
                this.Hide();
                Admin adm = new Admin();
                adm.idAdmin = us.getIdUser(user, pass);
                adm.Show();
            }
            else
            {
                this.Hide();
                Angajat ang = new Angajat();
                ang.idAngajat = us.getIdUser(user, pass);
                ang.Show();
            }
        }

        private void bForgotPass_Click(object sender, EventArgs e)
        {
            string forgotPass = Guid.NewGuid().ToString().Substring(0, 6);
            MessageBox.Show("Your temporary new password is: " + forgotPass);
            us.updatePass(tb_user.Text, forgotPass);
        }
    }
}
