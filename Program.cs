using TicketSystem;
using System.Collections.Generic;

int menu = 0;
List<Ticket> ticket_list = new List<Ticket>();
Console.WriteLine("Welcome to the Ticketing system prototype");
while (menu == 0)
{

    Console.WriteLine("To create a new ticket please press 1, to change the status of a ticket press 2, to display all tickets press 3");
    menu = Convert.ToInt16(Console.ReadLine());


    while (menu == 1)
    {
        Ticket ticket;
        Console.WriteLine("Please enter your staff ID");
        string staff_id = Console.ReadLine();
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        if(name == String.Empty )
        {
            Console.WriteLine("Please describe your issue");
            string issue = Console.ReadLine();
            ticket = new Ticket(staff_id, issue);
        }
        else
        {
            Console.WriteLine("Please enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Please describe your issue");
            string issue = Console.ReadLine();
            ticket = new Ticket(staff_id, name, email, issue);
        }
        ticket_list.Add(ticket);
        menu = 0;
    }
    while (menu == 3)
    {
        int ticket_count = ticket_list.Count;
        for (int i = 0; i < ticket_count; i++)
        {
            ticket_list[i].info();
        }
        menu = 0;
    }
    while (menu == 2)
    {

    }
}

