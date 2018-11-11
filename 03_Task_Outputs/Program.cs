using System;

namespace _03_Task_Outputs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт 
             * и мениджър. Мениджърът има име, фамилия и телефонен номер. */
            Console.WriteLine("Enter firm's name:");
            string firm_name = Console.ReadLine();

            Console.WriteLine("Address:");
            string address=Console.ReadLine();

            Console.WriteLine("Phone number:");
            string phone_number = Console.ReadLine();

            Console.WriteLine("Fax:");
            string fax = Console.ReadLine();

            Console.WriteLine("Web site:");
            string web_site = Console.ReadLine();

            Console.WriteLine("Manager:");
            string manager = Console.ReadLine();

            Console.WriteLine("Manager's name:");
            string managerName = Console.ReadLine();

            Console.WriteLine("Manager's last name:");
            string managerLast = Console.ReadLine();

            Console.WriteLine("Manager's phone:");
            string manPhone = Console.ReadLine();

            Console.WriteLine("\nFirm's:\n Name {0}\n Address: {1}\n Phone number: {2}\n Fax: {3}\n Web Site: {4}\n Manager: {5}",firm_name,address,phone_number,fax, web_site,manager);
            Console.WriteLine("\n\n Manager's:\n First name {0}\n Last name: {1}\n Phone number: {2}",managerName,managerLast,manPhone);
        }
    }
}
