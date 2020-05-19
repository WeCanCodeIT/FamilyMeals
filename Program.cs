using System;
using System.Collections.Generic;

namespace FamilyMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FamilyMeals App! We Make DinnerTime Easier!\n\n");

            // puts two line breaks in 
            //Console.WriteLine();
            //Console.WriteLine();

            // Arrays

            // Initialize and Assign #1

            string[] dinnersForWeek = new string[7];

            dinnersForWeek[0] = "Meatloaf";
            dinnersForWeek[1] = "Lasagna";
            dinnersForWeek[2] = "Hot Dogs";
            dinnersForWeek[3] = "Meatloaf";
            dinnersForWeek[4] = "Chips";
            dinnersForWeek[5] = "Meatloaf";
            dinnersForWeek[6] = "Sourdough Bread";

            // Prints single item

            Console.WriteLine("I just want " + dinnersForWeek[4] + "!!");
            Console.WriteLine();
            Console.WriteLine($"I just want {dinnersForWeek[4]}!!");
            Console.WriteLine("(Push any key to clear the console)");

            // pause - listens for keystroke
            Console.ReadKey();

            // clears console
            Console.Clear();
            Console.WriteLine("Push enter to continue!");
            Console.ReadLine();

            foreach (var item in dinnersForWeek)
            {
                Console.WriteLine("\nI just want " + item);
            }

            Console.WriteLine("\nPush enter to continue!");
            Console.ReadKey();
            Console.Clear();

            // Initialize and Assign #2

            string[] dinnerForWeek = { "Meatloaf", "Lasagna", "Hot Dogs", "Tacos", "Chips", "Beans", "Sourdough Bread" };

            foreach (var item in dinnersForWeek)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to see how long this array is!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("This array is " + dinnerForWeek.Length + " items long.");


            Console.WriteLine("\nPush enter to print the new shorter array!\n");
            Console.ReadKey();

            dinnerForWeek = new string[2];
            dinnerForWeek[0] = "wings";
            dinnerForWeek[1] = "pizza";

            foreach (var item in dinnerForWeek)
            {
                Console.WriteLine("When all else fails, there's always " + item);
            }

            Console.WriteLine("\nPush enter to jump to Lists!\n");
            Console.ReadKey();

            // Lists

            List<int> listOfInts = new List<int>
            {
                100,
                200,
                300
            };

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to insert 150!\n");
            Console.ReadKey();

            listOfInts.Insert(1, 150);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }



            //for (var i = 0; i <= 7; i++)
            //{
            //    Console.WriteLine();

            //}

            // Lists






            // Dictionaries







        }
    }
}
