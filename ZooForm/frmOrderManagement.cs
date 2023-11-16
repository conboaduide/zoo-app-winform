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
            LoadOrders();
        }

        private void LoadOrders()
        {
            BindingSource source = new BindingSource();
            source.DataSource = _orderRepository.GetOrder();
            dtgvOrder.DataSource = null;
            dtgvOrder.DataSource = source;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*try
            {
                int id = int.Parse(txtID.Text);
                //context.Database.ExecuteSqlRaw($"update Departments set DepartmentID = null where DepartmentID={id}");
                _orderRepository.DeleteOrder(id);

                var result = _orderRepository.GetOrder();
                dtgvOrder.DataSource = null;    //vip, xoá lưới, lấy danh sách mới
                dtgvOrder.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            txtID.Text = dtgvOrder.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            /*OrderDetail order = new()
            {
                Price = decimal.Parse(txtPrice.ToString()),
                TicketId = int.Parse(cbTicket.SelectedValue.ToString()),
            };
            _orderRepository.SaveOrderDetail(order);
            var result = _orderRepository.GetOrderDetail();
            dtgvOrder.DataSource = null;
            dtgvOrder.DataSource = result;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                
                _orderRepository.DeleteOrder(id);

                var result = _orderRepository.GetOrder();
                dtgvOrder.DataSource = null;    
                dtgvOrder.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(txtID.Text);

                var orderDetails = _orderRepository.GetOrderDetailsByOrderId(orderId);

                StringBuilder messageBuilder = new StringBuilder();
                foreach (var detail in orderDetails)
                {
                    messageBuilder.AppendLine($"Order Id: {detail.OrderId}, Order Detail ID: {detail.Id}, Price: {detail.Price}, Ticket ID: {detail.TicketId}, Status: {detail.Status}");
                    break;
                }

                MessageBox.Show(messageBuilder.ToString(), "Order Details");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
