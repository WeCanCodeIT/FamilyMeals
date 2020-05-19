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
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Console cleared. Push Enter to print dinner for the week!\n");

            // pause - listens for keystroke
            Console.ReadKey();

            // Console.WriteLine("Push enter to print dinner for the week!");
            // Console.ReadLine();

            //foreach (var item in dinnersForWeek)
            //{
            //    Console.WriteLine("\nI just want " + item);
            //}

            // Same as above foreach loop
            for (int i = 0; i < dinnersForWeek.Length; i++)
            {
                string dinner = dinnersForWeek[i];
                Console.WriteLine(dinner);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Console cleared. Push Enter to do it in reverse!\n");
            Console.ReadLine();

            // Go through it backwards
            for (int i = dinnersForWeek.Length - 1; i >= 0; i--)
            {
                string dinner = dinnersForWeek[i];
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nPush enter to print the same array!");
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

            Console.WriteLine("This array is " + dinnerForWeek.Length + " items long. Push Enter!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nPush enter to print the new shorter array!\n");
            Console.ReadKey();
            Console.Clear();

            dinnerForWeek = new string[2];
            dinnerForWeek[0] = "wings";
            dinnerForWeek[1] = "pizza";

            foreach (var item in dinnerForWeek)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to print a List!\n");
            Console.ReadKey();
            Console.Clear();

            // Initialize and assign new List

            List<int> listOfInts = new List<int>
            {
                100,
                200,
                300
            };

            // Prints list
            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to insert 150!\n");
            Console.ReadKey();
            Console.Clear();

            // Inserts 150 in element 1 position
            listOfInts.Insert(1, 150);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to add 400 to end of list!\n");
            Console.ReadKey();
            Console.Clear();

            // Adds 400 to end of list
            listOfInts.Add(400);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPush enter to remove element 3!\n");
            Console.ReadKey();
            Console.Clear();

            // removes element 3
            listOfInts.RemoveAt(3);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            // removes value from list
            Console.WriteLine("\nPush enter to remove the value of 400!\n");
            Console.ReadKey();
            Console.Clear();

            listOfInts.Remove(400);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n400 gone! Push enter!\n");
            Console.ReadKey();
            Console.Clear();

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nErase this whole list - push enter!");
            Console.ReadKey();
            Console.Clear();

            // erases list elements
            listOfInts.Clear();

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nList empty! Press Enter to put 400 back.");
            Console.ReadKey();
            Console.Clear();

            // 400 added to list
            listOfInts.Add(400);

            foreach (var item in listOfInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n400 back. Press Enter to print our Dictionary contents!\n");
            Console.ReadKey();
            Console.Clear();
            // Initialize and assign elements in a Dictionary

            Console.WriteLine("\nHere's our phonebook!\n");

            Dictionary<string, int> phoneBook = new Dictionary<string, int>
            {
                { "Bill Gates", 5551212 },
                { "Mark Zuckerberg", 8651212 }
            };

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();


        }
    }
}
