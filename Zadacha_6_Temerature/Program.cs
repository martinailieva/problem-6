using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_6_Temerature
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * (9.0 / 5.0) + 32;

            Console.WriteLine(fahrenheit);

            /* Values 0, 20 and 30 are excluded 
               because nothing is mentioned about them in the problem */
           

            if (celsius < 0)
            {
                Console.WriteLine("Твърде студено");
            }
            else if (celsius > 0 && celsius < 20)
            {
                Console.WriteLine("Стаа, ше се живее");
            }
            else if (celsius > 20 && celsius < 30)
            {
                Console.WriteLine("Вече е жега");
            }
            else if (celsius > 30)
            {
                Console.WriteLine("Ще се мре...");
            }
            Console.ReadKey(true);
        }
        
    }
}
