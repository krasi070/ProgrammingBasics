using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager second name: ");
            string secondName = Console.ReadLine();
            Console.Write("Manager age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("{0}\nAdress{1}\nTell.{2}\nFax:{3}\nWeb Site:{4}\nManager: {5} {6},(age:{7}, tell:{8})",
                companyName, companyAdress, phoneNumber, faxNumber, webSite, firstName, secondName, age, managerPhone);

        }
    }
}
