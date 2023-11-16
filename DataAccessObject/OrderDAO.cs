using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static object lockObject = new object();

        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> GetOrderDetail()
        {
            using var db = new ZooManagementContext();
            return db.OrderDetails.ToList();
        }
        public void SaveOrderDetail(OrderDetail order)
        {
            using var db = new ZooManagementContext();
            db.OrderDetails.Add(order);
            db.SaveChanges();
        }
        public void UpdateOrderDetail(OrderDetail order)
        {
            using var db = new ZooManagementContext();
            db.OrderDetails.Update(order);
            db.SaveChanges();
        }

        public void DeleteOrderDetail(int id)
        {
            using var db = new ZooManagementContext();
            OrderDetail order = db.OrderDetails.Find(id);
            if (order != null)
            {
                db.OrderDetails.Remove(order);
                db.SaveChanges();
            }
        }




        public List<Order> GetOrder()
        {
            using var db = new ZooManagementContext();
            return db.Orders.ToList();
        }
        public void SaveOrder(Order order)
        {
            using var db = new ZooManagementContext();
            db.Orders.Add(order);
            db.SaveChanges();
        }
        public void UpdateOrder(Order order)
        {
            using var db = new ZooManagementContext();
            db.Orders.Update(order);
            db.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            using var db = new ZooManagementContext();
            Order order = db.Orders.Find(id);
            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }

        public List<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            using var db = new ZooManagementContext();
            return db.OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }
    }
}
