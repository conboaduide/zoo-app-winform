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
            if (user.Role == 1)
            {// user is admin

            }
            else if (user.Role == 2)
            {// user is staff
                shopToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                animalToolStripMenuItem.Visible = false;
            }
            else if (user.Role == 3)
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
            frmShop f = new frmShop();
            f.Show();
            f.MdiParent = this;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderManagement f = new frmOrderManagement();
            f.Show();
            f.MdiParent = this;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement f = new frmUserManagement();
            f.Show();
            f.MdiParent = this;
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicketManagement f = new frmTicketManagement();
            f.Show();
            f.MdiParent = this;
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimalManagement f = new frmAnimalManagement();
            f.Show();
            f.MdiParent = this;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
