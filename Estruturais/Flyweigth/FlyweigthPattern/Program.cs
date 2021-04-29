using FlyweigthPattern.Factory;
using System;

namespace FlyweigthPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What kind of company do you want a report on?\n");
                Console.WriteLine("1 - Software");
                Console.WriteLine("2 - Food");
                Console.Write("> ");
                int companyKey = int.Parse(Console.ReadLine());

                var company = CompanyFactory.GetCompany(companyKey);
                company.Description();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred: " + ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
