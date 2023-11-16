using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
using DataAccessObject;


namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<OrderDetail> GetOrderDetail()
        => OrderDAO.Instance.GetOrderDetail();

        public void SaveOrderDetail(OrderDetail order)
        => OrderDAO.Instance.SaveOrderDetail(order);

        public void UpdateOrderDetail(OrderDetail order)
        => OrderDAO.Instance.UpdateOrderDetail(order);

        public void DeleteOrderDetail(int id)
        => OrderDAO.Instance.DeleteOrderDetail(id);



        public List<Order> GetOrder()
        => OrderDAO.Instance.GetOrder();

        public void SaveOrder(Order order)
        => OrderDAO.Instance.SaveOrder(order);

        public void UpdateOrder(Order order)
        => OrderDAO.Instance.UpdateOrder(order);

        public void DeleteOrder(int id)
        => OrderDAO.Instance.DeleteOrder(id);


    }
}
