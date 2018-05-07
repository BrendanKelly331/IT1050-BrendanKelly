using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_BrendanKelly
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero("Batman", 28, "Joker", "Human", "Armed and Dangerous", 100, 56);
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
            */

            myHero.ChargePower(5);
            myHero.Investigate();
            myHero.FightCrime("1434 Mulholland Dr");
            myHero.Fly();
            myHero.Climb(8);

            Console.WriteLine(" ");

            myOtherHero.ChargePower(10);
            myOtherHero.Investigate();
            myOtherHero.FightCrime("Apartment 5A, 129 West 81st Street");
            myOtherHero.Fly();
            myOtherHero.Climb(2);

            Console.WriteLine(" ");

            thirdHero.ChargePower(28);
            thirdHero.Investigate();
            thirdHero.FightCrime("875 N Michigan Ave");
            thirdHero.Fly();
            thirdHero.Climb(6);

            Console.ReadKey();

        }
    }
}
