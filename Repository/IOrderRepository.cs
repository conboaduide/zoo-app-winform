using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderRepository
    {
        public void SaveOrderDetail(OrderDetail order);
        public void DeleteOrderDetail(int id);
        public void UpdateOrderDetail(OrderDetail order);
        public List<OrderDetail> GetOrderDetail();



        public void SaveOrder(Order order);
        public void DeleteOrder(int id);
        public void UpdateOrder(Order order);
        public List<Order> GetOrder();
    }
}
