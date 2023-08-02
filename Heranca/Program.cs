using Heranca.Entities;
using System;
using System.Globalization;


namespace Heranca
{

    class Program
    {
        static void Main(string[] args)
        {
            // Criando a lista para os produtos
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char PayerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                if ( PayerType == 'i') 
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine());
                    list.Add(new NaturalPerson(name, annualIncome, healthExpenses));

                }
                else if (PayerType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees= int.Parse(Console.ReadLine());
                    list.Add(new JuridicalPerson(name, annualIncome, numberEmployees));
                }


            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("PAID TAXES:");
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.GetTaxValue();
                Console.WriteLine($"{taxPayer.Name}: ${taxPayer.GetTaxValue().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES:");
            Console.WriteLine($"${sum.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }














}
