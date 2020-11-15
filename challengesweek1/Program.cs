using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challengesweek1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfDates = new List<DateTime>();
            listOfDates.Add(new DateTime(2020, 11, 16));
            listOfDates.Add(new DateTime(2020, 11, 14));
            listOfDates.Add(DateTime.Now);

            for (int i = 0; i < listOfDates.Count; i++)
            {
                Console.WriteLine(listOfDates[i]);
            }

            string[] otherFavorites = new string[4];
            otherFavorites[0] = "Awesome collection";
            otherFavorites[1] = "Is there more?";
            otherFavorites[2] = "Is there more?";
            otherFavorites[3] = "Is there more?";


            foreach (var favorite in otherFavorites)
            {
                Console.WriteLine(favorite);
            }

            for (int i = 0; i < otherFavorites.Length; i++)
            {
                Console.WriteLine(otherFavorites[i]);
            }

            int snumber = 5;

            if (snumber>0)
            {
                if (snumber >= 10)
                {
                    Console.WriteLine("Wow that's a lot of sleep");
                }
                else if (snumber > 8 && snumber < 10)
                {
                    Console.WriteLine("You should be pretty rested");
                }
                else if (snumber > 4 && snumber < 8)
                {
                    Console.WriteLine("Bummer");
                }
                else
                {
                    Console.WriteLine("Oh man, get some sleep!");
                }
            }
            else
            {
                Console.WriteLine("Please input a number greater than zero.");
            }

            Console.WriteLine("How is your day?");
            string emotion = Console.ReadLine();
            switch (emotion)
            {
                case "Great":
                    Console.WriteLine("Wow you must be having a great day");
                    break;

                case "Good":
                    Console.WriteLine("Your having a good day");
                    break;

                case "Okay":
                    Console.WriteLine("It must be an okay day");
                    break;

                case "Bad":
                    Console.WriteLine("Hopefully it gets better");
                    break;

                default:
                    Console.WriteLine("Hope everything went well");
                    break;
            }
            Console.ReadKey();
        }
    }
}
