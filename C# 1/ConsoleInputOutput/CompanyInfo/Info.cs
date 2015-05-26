//  Problem 2. Print Company Information
//  A company has name, address, phone number, fax number, web site and manager. The manager has
// first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class Program
{
    static void Main()
    {

        Console.Write("Company name ");
        string companyName = Console.ReadLine();
        Console.Write("Compay address ");
        string address = Console.ReadLine();
        Console.Write("Company fax number ");
        int faxNum = int.Parse(Console.ReadLine());
        Console.Write("Company website");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Manager phone");
        int phone = int.Parse(Console.ReadLine());

        Console.WriteLine(companyName);
        Console.Write("Address: ");
        Console.WriteLine(address);
        Console.Write("fax: ");
        Console.WriteLine(faxNum);
        Console.Write("website ");
        Console.WriteLine(webSite);
        Console.Write("Manager: ");
        Console.WriteLine(managerFirstName);
        Console.WriteLine(managerLastName);
        Console.Write("Age: ");
        Console.WriteLine(age);
        Console.Write("Phone: ");
        Console.WriteLine(phone);



            
    }
}

