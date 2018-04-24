using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            
            Console.WriteLine(names[2]);
            Console.WriteLine(names[4]);



            //2. 
            string[] months = new string[12];

            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";


            int i;
            for (i = 0; i <= 11; i++)
            {
                Console.WriteLine(months[i]);
            }





            //3. 
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string value in seasons)
                Console.WriteLine("{0}", value);




            //4. 
            int[] integers = new int[1000];

            Random random = new Random();
            int randomNumber = 0;

            for (i = 0; i < 1000; i++)
            {
                randomNumber = random.Next(0, 100);

                integers[i] = randomNumber;
            }

            foreach (int value in integers)
                Console.WriteLine("{0}", value);

            Console.ReadKey();
        }
    }
}
