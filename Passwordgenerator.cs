using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Passwordgenerator
    {
        public static string new_password(string staff_id)
        {
            string generated_password = staff_id.Substring(0, 2) + Ticket.ticket_number.ToString("X");
            return generated_password;
        }
        
    }
}
