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
using System.Xml.Linq;

namespace ZooForm
{
    public partial class frmOrderManagement : Form
    {
        private IOrderRepository _orderRepository = new OrderRepository();
        private ITicketRepository _ticketRepository = new TicketRepository();
        private void LoadUserData()
        {
            BindingSource source = new BindingSource();
            source.DataSource = _orderRepository.GetOrder();
        }

        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private bool isAdmin(User user)
        {
            if (user.Email.Equals("admin@fstore.com"))
            {
                return true;
            }
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            cbTicket.DataSource = _ticketRepository.GetTickets();
            cbTicket.DisplayMember = "Type";
            cbTicket.ValueMember = "Id";
            LoadOrders();
        }

        private void LoadOrders()
        {
            BindingSource source2 = new BindingSource();
            source2.DataSource = _orderRepository.GetOrderDetail();
            dtgvOrder.DataSource = null;
            dtgvOrder.DataSource = source2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvOrder.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete selected order(s)?",
                    "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtgvOrder.SelectedRows)
                    {
                        Order order = (Order)row.DataBoundItem;
                    }
                    LoadOrders();
                }
            }
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderDetail order = new()
            {
                Price = decimal.Parse(txtPrice.ToString()),
                TicketId = int.Parse(cbTicket.SelectedValue.ToString()),
            };
            _orderRepository.SaveOrderDetail(order);
            var result = _orderRepository.GetOrderDetail();
            dtgvOrder.DataSource = null;
            dtgvOrder.DataSource = result;
        }
    }
}
