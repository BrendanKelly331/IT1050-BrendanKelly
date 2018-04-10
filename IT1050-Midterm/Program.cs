using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //1. Infinite While Loop
            /*
            bool keepLooping = true;

            while (keepLooping == true)
            {
                Console.WriteLine("It'll never end.");
            }


            //2. While Loop that Doubles Up to 128

            int control = 2;

            while (control <= 128)
            {
                Console.WriteLine(control);

                control = control * 2;
            }


            //3. For Loop that Prints 49-1 separated by Commas

            for (int i = 49; i > 0; i--)
            {
                Console.Write(i);
                
                if (i > 1)
                {
                    Console.Write(",");
                }
            }

            Console.Write("\n");
            


            //4. While Loop that Prints Odd Numbers 1-21

            int i = 1;

            while (i <= 21)
            {
                Console.Write(i + "   ");
                i = i + 2;
            }

            Console.Write("\n");
            


            //5. Difference Between While and Do-While

            //The do-while loop ensures that the loop runs through at least once. This is the "do" part of the loop.
            int n = 8;
            int i = 10;
            do
            {
                Console.Write("*");
                i++; // i is not equal to 11
            } while (i < n); // because i is greater than n and the condition is not met, the loop stops after the "do" portion.
            

            //6. If statement that outputs "Let's go outside!" when boolean values are false

            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain ||! tornadoWarning) Console.WriteLine("Let's go outside!");



        123454321
         1234321
          12321
           121
            1

            */


            //7. Extra Credit: Nested Loops

            int i = 1;
            int o = 5;
            while (i < o)
            {
                while (i <= o)
                {
                    Console.Write(i);
                    i++;
                }

                i--;

                while (i > 1)
                {
                    i--;
                    Console.Write(i);
                }

                Console.Write("\n");
                o--;
            }

            Console.WriteLine(i);


        }
    }
}
