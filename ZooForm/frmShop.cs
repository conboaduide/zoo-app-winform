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
    public partial class frmShop : Form
    {
        ITicketRepository ticketRepo = new TicketRepository();
        IOrderRepository orderRepo = new OrderRepository();
        List<OrderDetailDTO> orderDetails = new List<OrderDetailDTO>();
        private User user;
        public frmShop(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        public void loadTicket()
        {
            var aList = ticketRepo.GetTickets();
            BindingSource source = new BindingSource();
            source.DataSource = aList;
            txtCustomer.Text = user.Email;
            txtItem.DataBindings.Clear();
            txtItem.DataBindings.Add("Text", source, "Type");
            dgvShop.DataSource = null;
            dgvShop.DataSource = source;
        }

        public void loadOrder()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = orderDetails;
        }
        private void frmShop_Load(object sender, EventArgs e)
        {
            loadTicket();
        }
        void StyleDatatGridView()
        {

            dgvShop.BorderStyle = BorderStyle.None;
            dgvShop.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvShop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvShop.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvShop.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            dgvShop.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvShop.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvShop.EnableHeadersVisualStyles = false;
            dgvShop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvShop.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Serif", 10);
            dgvShop.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 37);
            dgvShop.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvShop.SelectedRows)
            {
                bool existed = false;
                foreach (OrderDetailDTO orderDetailDTO in orderDetails)
                {
                    if (orderDetailDTO.TicketId == int.Parse(selectedRow.Cells["Id"].Value.ToString()))
                    {
                        orderDetailDTO.Quantity += 1;
                        existed = true;
                        break;
                    }
                }
                if (!existed)
                {
                    OrderDetailDTO orderDetail = new OrderDetailDTO
                    {
                        Id = orderDetails.Count + 1,
                        TicketId = int.Parse(selectedRow.Cells["Id"].Value.ToString()),
                        Price = decimal.Parse(selectedRow.Cells["Price"].Value.ToString()),
                        Status = true,
                        Quantity = 1
                    };
                    orderDetails.Add(orderDetail);
                }
            }
            loadOrder();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            Order order = new Order
            {
                CustomerId = user.Id,
                CreatedDate = DateTime.Now,
            };
            orderRepo.SaveOrder(order);

            var tmp = orderRepo.GetOrder().Last();
            foreach (OrderDetailDTO order1 in orderDetails)
            {
                for (int i = 0; i < order1.Quantity; i++)
                {
                    total += order1.Price;
                    OrderDetail order2 = new OrderDetail
                    {
                        OrderId = tmp.Id,
                        Price = order1.Price,
                        Status = false,
                        TicketId = order1.TicketId
                    };
                    orderRepo.SaveOrderDetail(order2);
                }
            }
            tmp.Total = total;
            orderRepo.UpdateOrder(tmp);

            Hide();
        }
    }
}
