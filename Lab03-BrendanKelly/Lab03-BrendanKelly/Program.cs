using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_BrendanKelly
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dAmount1;
            decimal dAmount2;
            decimal dSum;

            Console.WriteLine("Enter first number: ");
            dAmount1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            dAmount2 = decimal.Parse(Console.ReadLine());

            dSum = dAmount1 + dAmount2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", dAmount1, dAmount2, dSum);


            Console.ReadKey();
 
            
            int x = 10;
            int y = 7;
            int z = 4;

            int r = (x + y) * (z + 10);

            Console.WriteLine("The result of (10 + 7) * (4 + 10) is {0}", r);

            Console.ReadKey();

            Console.WriteLine("HelloWorld!");
            Console.WriteLine("Hello\n\tWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine(@"Hello\World!");



        }
    }
}
