using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath result1 = new MyMath();

            result1.Multiply(2, 3);
            Console.WriteLine("The result is: " + result1.getResult());

            result1.Divide(2, 3);
            Console.WriteLine("The result is: " + result1.getResult());

            result1.Add(2, 3);
            Console.WriteLine("The result is: " + result1.getResult());

            result1.Subtract(2, 3);
            Console.WriteLine("The result is: " + result1.getResult());
        }
    }
}
