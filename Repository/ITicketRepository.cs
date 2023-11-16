using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace Repository
{
    public interface ITicketRepository
    {
        public void SaveTicket(Ticket ticket);
        public void DeleteTicket(int id);
        public void UpdateTicket(Ticket ticket);
        public List<Ticket> GetTickets();
        public Ticket GetTicketById(int Id);
    }
}
