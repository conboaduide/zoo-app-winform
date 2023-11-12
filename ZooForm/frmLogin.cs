using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooForm
{
    public partial class frmLogin : Form
    {
        IUserRepository _userRepository = new UserRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                frmMain main = new frmMain(user);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
