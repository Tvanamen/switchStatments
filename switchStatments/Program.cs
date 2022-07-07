using System;

namespace switchStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = Console.ReadLine();
            Console.WriteLine("What is your favorite school subject");
            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is cool im really good at it");
                    break;
                case "English":
                    Console.WriteLine("English i was never very good at writing it");
                    break;
                case "Gym":
                    Console.WriteLine("Gym was cool i was just too competitve");
                    break;
                case "Science":
                    Console.WriteLine("Science is cool but too complicated");
                    break;
                case "History":
                    Console.WriteLine("History was fun to learn about WW2");
                    break;

                default: Console.WriteLine("Never heard of it but just be fun");
                    break ;


            }


        }
    }
}
