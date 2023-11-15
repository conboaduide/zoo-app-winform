using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TicketRepository : ITicketRepository
    {
        public void DeleteTicket(int id)
        => TicketDAO.Instance.DeleteTicket(id);

        public List<Ticket> GetTickets()
        => TicketDAO.Instance.GetTickets();

        public void SaveTicket(Ticket ticket)
        => TicketDAO.Instance.SaveTicket(ticket);

        public void UpdateTicket(Ticket ticket)
        => TicketDAO.Instance.UpdateTicket(ticket);
    }
}
