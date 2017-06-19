using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_qiymet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your midterm grade: ");
            double midterm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your grade from final exam: ");
            double final = Convert.ToInt32(Console.ReadLine());

            double final_gr = midterm * 0.4 + final * 0.6;

            if (final_gr>=45)
            {
                Console.WriteLine("You passed the course,your average grade is: " + final_gr);
            }
            else
            {
                Console.WriteLine("You failed the course, your average grade is: " + final_gr);
            }
        }
    }
}
