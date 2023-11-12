using BusinessObject.Models;
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
    public partial class frmMain : Form
    {
        private User user;

        public frmMain(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (user.UserRoles.Where(role => role.RoleId == 1) != null)
            {// user is admin
                
            }
            else if (user.UserRoles.Where(role => role.RoleId == 2) != null)
            {// user is staff
                shopToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                animalToolStripMenuItem.Visible = false;
            }
            else if (user.UserRoles.Where(role => role.RoleId == 3) != null)
            {// user is zoo trainer
                userToolStripMenuItem.Visible = false;
                shopToolStripMenuItem.Visible = false;
                ticketToolStripMenuItem.Visible = false;
            }
            else
            {// user is customer
                userToolStripMenuItem.Visible = false;
                animalToolStripMenuItem.Visible = false;
                ticketToolStripMenuItem.Visible = false;
            }
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
