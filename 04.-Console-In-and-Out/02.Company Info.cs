/*A company has name, address, phone number, 
fax number, web site and manager. The manager 
has first name, last name, age and a phone number.
Write a program that reads the information about 
a company and its manager and prints it back on the console.
You will each piece of information about the company on a
separate line, in the same order as in the example
    Company name
    Company address
    Phone number
    Fax number
    Web site
    Manager first name
    Manager last name
    Manager age
    Manager phone
1.The input will always be in the described format
Only the fax number field can be empty, all other 
fields will have be least one symbol
Time limit: 0.1s
Memory limit: 16MB
*/
using System;

class CompanyInfo
{
    static void Main(string[] args)
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string website = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\n{0}\nAddress: {1}", companyName, companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        if (faxNumber.CompareTo(string.Empty) == 0)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
