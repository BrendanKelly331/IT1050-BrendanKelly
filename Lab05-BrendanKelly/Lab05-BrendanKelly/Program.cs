using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_BrendanKelly
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. The if statement runs through the loop once and only if the statement is true.
                  The while statement, on the other hand, runs through the loop continuously, until the statement is false. */

            // 2. Dsiplays message "SLOW NOW" if speed is higher than speed limit
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            // 3. Defines bool as false
            bool isTrue = false;

            // bools fails if statement, then changes to true in else statement
            if (isTrue == true) Console.WriteLine("It is true!");

            else Console.WriteLine("It is false!"); isTrue = true;

            // bool now meets condition of if statement 
            if (isTrue == true) Console.WriteLine("It is true!");


            // 4. Asks user for 

            double fahrenheit;

            Console.WriteLine("What's the temperature in fahrenheit?");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5d / 9d;

            Console.WriteLine(celsius);

            if (celsius < 40) Console.WriteLine("It is cold");
            if (celsius > 90) Console.WriteLine("It is hot");


            // 5. While loop that outputs 1-10

            int i = 0;

            while (i < 10)
            {
                i++;

                Console.WriteLine(i);
            }


            // 6. While loop that outputs 60-20

            int j = 60;

            while (j >= 20)
            {
                Console.WriteLine(j);

                j--;
            }


            // 7. While loop that outputs 10-20

            int l = 10;

            while (l <= 20)
            {
                Console.WriteLine(l);

                l++;
            }

        }
    }
}
