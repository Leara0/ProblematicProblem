using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            var validResponse = false;

            List<string> activities = new List<string>()
            {
                "Movies", "Paintball", "Bowling", "Laser Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"
            };

            Text.Print("Hello, welcome to the random activity generator!");
            Text.Print("Would you like to generate a random activity? yes/no:");
            
            string answer = UserInput.GetUserInputYN();
            
            if (answer == "no")
                Text.EndGame("Thanks for stopping by! Goodbye!");
            Console.WriteLine();

            Text.Print("We are going to need your information first! What is your name?");
            string userName = UserInput.GetUserInput();
            userName = char.ToUpper(userName[0]) + userName.Substring(1);
            Console.WriteLine();

            Text.Print("What is your age? ");
            int userAge = UserInput.GetInt();
            Console.WriteLine();

            Text.Print("Would you like to see the current list of activities? yes/no:");
            answer = UserInput.GetUserInputYN();

            if (answer == "yes")
            {
                foreach (string activity in activities)
                {
                    Text.Print($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Text.Print("Would you like to add any activities before we generate one? yes/no: ");
                answer = UserInput.GetUserInputYN();
                Console.WriteLine();
                while (answer == "yes")
                {
                    Text.Print("What would you like to add? ");
                    activities.Add(UserInput.GetUserInput());
                    Console.WriteLine();
                    Text.Print($"{activities[activities.Count - 1]} has been added to the list");

                    Console.WriteLine();
                    Text.Print("Would you like to add more? yes/no: ");
                    answer = UserInput.GetUserInputYN();
                    Console.WriteLine();
                }
            }


            do // while cont was original
            {
                Console.WriteLine();
                Animate.WaitTime();


                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];

                Text.Print($"Ah got it! {userName}, your random activity is: {randomActivity}!");
                Console.WriteLine();
                Thread.Sleep(2000);

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Text.Print($"Oh no! Looks like you are too young to do wine tasting");
                    Text.Print("Let's try something else!");
                    Console.WriteLine();
                    activities.Remove(randomActivity);
                    Animate.WaitTime();

                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                    Text.Print($"Your new random activity is: {randomActivity}!");
                }

                Text.Print(
                    $"Is this ok or do you want to grab another activity?");
                Text.Print(
                    "Please type 'yes' to do this activity and 'no' to generate a new random activity suggestion.");
                answer = UserInput.GetUserInputYN();
                if (answer == "no")
                    activities.Remove(randomActivity);
            } while (answer == "no");

            Console.WriteLine();
            Animate.FireWorks(userName);
            
            Text.EndGame("Thanks for stopping by! Goodbye!");
        }
    }
}