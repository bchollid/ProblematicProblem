using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program 
    {
        //Random rng;
        // bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
           static void Main(string[] args)
            {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            var userInput = Console.ReadLine().ToLower();
            bool cont = true;
            bool seeList = true;
            if (userInput == "yes")
            {
                cont = true;
            }
            else if(userInput =="no")
            {
                cont = false;
            }
            else
            {
                Console.WriteLine("Please enter yes or no");
            }
            //bool cont = bool.Parse(Console.ReadLine());
            if (cont == false)
            {
                Console.WriteLine("Ok. Come back when you're ready for a random activity.");
            }
            else if (cont == true)
            {
                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                int userAge = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? yes/no : ");
                var userInput2 = Console.ReadLine().ToLower();
                if (userInput2 == "yes")
                {
                    seeList = true;
                }
                else if (userInput2 == "no")
                {
                    seeList = false;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no.");
                }
                //bool seeList = bool.Parse(Console.ReadLine());
                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    bool addToList;
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    var userInput3 = Console.ReadLine().ToLower();
                    if (userInput3 == "yes")
                    {
                        addToList = true;
                    }
                    else if (userInput3 == "no")
                    {
                        addToList = false;
                    }
                    else
                    {
                        addToList = false;
                        Console.WriteLine("Please enter yes or no");
                    }
                    //bool addToList = bool.Parse(Console.ReadLine());
                    Console.WriteLine();
                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        var userInput4 = Console.ReadLine().ToLower();
                        if (userInput4 == "yes")
                        {
                            addToList = true;
                        }
                        else if (userInput4 == "no")
                        {
                            addToList = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter yes or no");
                        }
                        //addToList = bool.Parse(Console.ReadLine());
                    }
                }

                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Random rng = new Random();
                    int randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("We'll pick something else for you!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    var userInput5 = Console.ReadLine().ToLower();
                    if (userInput5 == "keep")
                    {
                        cont = false;
                    }
                    else if (userInput5 == "redo")
                    {
                        cont = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter keep or redo");
                    }
                    //cont = bool.Parse(Console.ReadLine());
                }
            }
           }
    }
}