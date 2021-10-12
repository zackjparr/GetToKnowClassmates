using System;
using System.Collections.Generic;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Andy, Berkley, French Fries
            //Cassly, Detroit, Steak
            //Phillip, Canton, Fried Chicken
            //Cortez, Detroit, Chicken Fettucini Alfredo
            //Erin, Troy, Tacos
            //Richard, Canton, Sushi
            //Cullin, Fowlerville, Pad Thai
            //Cordero, Berkley, BBQ
            //Huy, Lansing, Korean BBQ
            //Tommy, Raleigh NC, Curry

            List<string> names = new List<string>();
            names.Add("Andy");
            names.Add("Cassly");
            names.Add("Phillip");
            names.Add("Cortez");
            names.Add("Erin");
            names.Add("Richard");
            names.Add("Cullin");
            names.Add("Cordero");
            names.Add("Huy");
            names.Add("Tommy");

            List<string> hometowns = new List<string>();
            hometowns.Add("Berkley");
            hometowns.Add("Detroit");
            hometowns.Add("Canton");
            hometowns.Add("Detroit");
            hometowns.Add("Troy");
            hometowns.Add("Canton");
            hometowns.Add("Fowlerville");
            hometowns.Add("Berkley");
            hometowns.Add("Lansing");
            hometowns.Add("Raleigh");

            List<string> foods = new List<string>();
            foods.Add("French Fries");
            foods.Add("Steak");
            foods.Add("Fried Chicken");
            foods.Add("Chicken Fettucini Alfredo");
            foods.Add("Tacos");
            foods.Add("Sushi");
            foods.Add("Pad Thai");
            foods.Add("BBQ");
            foods.Add("Korean BBQ");
            foods.Add("Curry");


            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1 - 10): ");
                int num = int.Parse(Console.ReadLine()) - 1;

                if (num >= 0 && num < 10)
                {
                    Console.WriteLine($"Student {num + 1} is {names[num]}! What would you like to know about {names[num]}? (enter 'hometown' or 'food')");
                    string selectedOption = Console.ReadLine().ToLower();

                    if (selectedOption == "hometown")
                    {
                        Console.WriteLine($"{names[num]}'s hometown is {hometowns[num]}. Cool beans!");
                        goOn = Continue();
                    }
                    else if (selectedOption == "food")
                    {
                        Console.WriteLine($"{names[num]}'s favorite food is {foods[num]}. Yum!");
                        goOn = Continue();
                    }
                    else
                    {
                        Console.WriteLine($"Please select a valid input.");
                    }
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }

                goOn = Continue();
            }
        }

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand.");
                Console.WriteLine("Let's try again!");
                return Continue();
                //this is recursion, calling a method inside itself
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

    }
}
