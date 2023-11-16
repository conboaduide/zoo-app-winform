using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooForm
{
    public partial class frmTicketManagement : Form
    {
        ITicketRepository ticketRepository = new TicketRepository();
        bool CreateOrUpdate = false;
        public frmTicketManagement()
        {
            InitializeComponent();
            cbStatus.Items.Add("True");
            cbStatus.Items.Add("False");
            LoadTickets();
        }

        private void frmTicketManagement_Load(object sender, EventArgs e)
        {

        }
        private void LoadTickets()
        {
            BindingSource source = new BindingSource();
            source.DataSource = ticketRepository.GetTickets();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }
        public void ClearText()
        {
            tbPrice.Text = "";
            tbType.Text = "";
            cbStatus.Text = "";
        }
        public void EnableText(bool status)
        {
            tbPrice.Enabled = status;
            tbType.Enabled = status;
            cbStatus.Enabled = status;
            dateCreated.Enabled = status;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Display a MessageBox with Yes/No buttons
                DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's choice
                if (result == DialogResult.Yes)
                {
                    //lay ra dong dau tien da chon
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    //lay ra ID
                    int ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    //delete
                    ticketRepository.DeleteTicket(ID);
                    LoadTickets();
                    MessageBox.Show("Delete successfully!");

                }
            }
            else MessageBox.Show("Choose item to delete");
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (btCreate.Text == "Create")
            {
                btCreate.Text = "Cancel";
                btSave.Enabled = true;
                EnableText(true);
                CreateOrUpdate = true;
            }
            else
            {
                btCreate.Text = "Create";
                btSave.Enabled = false;
                EnableText(false);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbType.Text.Trim() == ""
                || tbPrice.Text.Trim() == ""
                || cbStatus.Text.Trim() == ""
                )
            {
                MessageBox.Show("All field are required!", "Ticket Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (CreateOrUpdate)
                {
                    var ticket = new Ticket
                    {
                        Type = tbType.Text,
                        Price = Convert.ToDecimal(tbPrice.Text),
                        Status = Convert.ToBoolean(cbStatus.Text),
                        CreatedDate = Convert.ToDateTime(dateCreated.Text)
                    };
                    ticketRepository.SaveTicket(ticket);
                    btCreate.Text = "Create";
                }
                else
                {
                    //lay ra dong dau tien da chon
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    //lay ra ID
                    int ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                    
                    var ticket = new Ticket
                    {
                        Id = ID,
                        Type = tbType.Text,
                        Price = Convert.ToDecimal(tbPrice.Text),
                        Status = Convert.ToBoolean(cbStatus.Text),
                        CreatedDate = Convert.ToDateTime(dateCreated.Text)
                    };
                    ticketRepository.UpdateTicket(ticket);
                    btUpdate.Text = "Update";
                }
                EnableText(false);
                ClearText();
                btSave.Enabled = false;
                LoadTickets();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            EnableText(true);
            if (btUpdate.Text == "Update")
            {
                btUpdate.Text = "Cancel";
                btSave.Enabled = true;
                CreateOrUpdate = false;
                //lay ra dong dau tien da chon
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                //lay ra ID
                int ID = Convert.ToInt32(selectedRow.Cells[0].Value);
                //getTicket
                Ticket t = ticketRepository.GetTicketById(ID);
                tbType.Text = t.Type.ToString();
                tbPrice.Text = t.Price.ToString();
                cbStatus.Text = t.Status.ToString();
                dateCreated.Text = t.CreatedDate.ToString();
            }
            else
            {
                btUpdate.Text = "Update";
                btSave.Enabled = false;
                EnableText(false);
                LoadTickets();
            }
        }
    }
}
