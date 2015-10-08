using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNum = Console.ReadLine();
        Console.Write("Fax Number: ");
        string faxNum = Console.ReadLine();
        Console.Write("Web Site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager First Name: ");
        string managerFstName = Console.ReadLine();
        Console.Write("Manager Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager Phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAddress, phoneNum, faxNum, webSite, managerFstName, managerLastName, managerAge, managerPhone);
    }
}

