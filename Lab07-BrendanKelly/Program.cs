using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_BrendanKelly
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 

            int count = 1;  //loop control variable 

            while (count <= 9)  //loop terminates when the count is greater than 9 
            {
                Console.WriteLine(count);

                count = count + 2;  //loop control variable is modified: increase of 2 
            }



            //2. 

            int i = 30;

            while (i <= 45)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("It's even.");
                }
                else
                {
                    Console.WriteLine("It's odd.");
                }
                i++;
            }



            //3. 

            int time = 0;

            while (time >= 0 && time <= 2400)
            {
                Console.WriteLine("Do you have the time? (Please omit special characters)");
                time = Convert.ToInt32(Console.ReadLine());

                if (time >= 1600)
                {
                    Console.WriteLine("Good Evening.");
                }
                else if (time >= 1200)
                {
                    Console.WriteLine("Good Afternoon.");
                }
                else
                { 
                    Console.WriteLine("Good morning.");
                }
            }



            //4. 

            i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;    //a method to increment the integer was not included
            }



            //5.

            for (i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            //the console methods were not included in the for loop via { and }



            //6. (a.)

            int line;
            int star;

            for (line = 1; line <= 10; line++)
            {
                for (star = 1; star <= line; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
