using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerfQiymet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter you midterm grade: ");
            double midterm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter you final grade: ");
            double final = Convert.ToInt32(Console.ReadLine());

            double final_gr = midterm *0.4 + final * 0.6;

            if (final_gr<=45)
            {
                Console.WriteLine("You failed the course");
            }
            else if (final_gr>=46 && final_gr<=60){
                Console.WriteLine("You got D");
            }
            else if (final_gr >= 61 && final_gr <= 75)
            {
                Console.WriteLine("You got C");
            }
            else if (final_gr >= 76 && final_gr <= 90)
            {
                Console.WriteLine("You got B");
            }
            else
            {
                Console.WriteLine("You got A");
            }
        }
    }
}
