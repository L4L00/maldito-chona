using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    internal class Ticket
    {
        public string staff_id;       
        public static int ticket_number = 2000;
        public string ticket_creator_name;
        public string ticket_creator_email;
        public string ticket_issue;
        public int real_number;
        public string status = "OPEN";
        public string response = "Not provided";


        public Ticket(string f_staff_id, string f_ticket_issue)
        {
            staff_id = f_staff_id;
            ticket_creator_name = "Not specified";
            ticket_creator_email = "Not specified";
            ticket_issue = f_ticket_issue;
            ticket_number++;
            real_number = ticket_number;

        }
        public Ticket(string f_staff_id, string f_ticket_creator_name, string f_ticket_creator_email, string f_ticket_issue)
        {
            staff_id = f_staff_id;
            ticket_creator_name = f_ticket_creator_name;
            ticket_creator_email = f_ticket_creator_email;
            ticket_issue = f_ticket_issue;
            ticket_number++;
            real_number = ticket_number;
        }
       
        
        public void info()
        {
            Console.WriteLine("Ticket number: " + real_number);
            Console.WriteLine("Staff ID: " + staff_id);
            Console.WriteLine("Name: " + ticket_creator_name);
            Console.WriteLine("Email: " + ticket_creator_email);   
            Console.WriteLine("Description: " + ticket_issue);
            if (ticket_issue.Contains("Password Change") || ticket_issue.Contains("password change") || ticket_issue.Contains("PASSWORD CHANGE"))
            {
                string password = Passwordgenerator.new_password(staff_id);
                status = ("CLOSED");
                response = ("New password generated: " + password);
                Console.WriteLine(response);
            }
            Console.WriteLine("Status: " + status);
            Console.WriteLine("-------------------------------");
        }
            
    }
}
