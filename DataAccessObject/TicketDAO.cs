using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class TicketDAO
    {
        private static TicketDAO instance = null;
        private static object lockObject = new object();

        private TicketDAO() { }

        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketDAO();
                }
                return instance;
            }
        }
        public Ticket GetTicketById(int Id)
        {
            using var db = new ZooManagementContext();
            var ticket = db.Tickets.Where(t => t.Id == Id).FirstOrDefault();
            return ticket;
        }
        public List<Ticket> GetTickets()
        {
            using var db = new ZooManagementContext();
            return db.Tickets.ToList();
        }
        public void SaveTicket(Ticket ticket)
        {
            using var db = new ZooManagementContext();
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }
        public void UpdateTicket(Ticket ticket)
        {
            using var db = new ZooManagementContext();
            db.Tickets.Update(ticket);
            db.SaveChanges();
        }

        public void DeleteTicket(int id)
        {
            using var db = new ZooManagementContext();
            Ticket ticket = db.Tickets.Find(id);
            if (ticket != null)
            {
                db.Tickets.Remove(ticket);
                db.SaveChanges();
            }
        }
    }
}
