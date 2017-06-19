using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your daily income: ");
            int daily = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of working days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int income = daily * days;

            if (income>=1000)
            {
                Console.WriteLine("Your tax is 18% and you earn: " + (income * 0.82) + ", you paid " + (income*0.18)+" manats as a tax");
            }
            else
            {
                Console.WriteLine("Your tax is 4% and you earn: " + (income * 0.96) + ", you paid " + (income*0.04) + " manats as a tax");
            }
        }
    }
}
