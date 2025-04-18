using System;
using System.Threading;
using System.Collections.Generic;


namespace ProblematicProblem;

public static class UserInput
{
    public static string GetUserInput()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.CursorTop);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        return Console.ReadLine();
    }
    
    public static string GetUserInputYN()
    {
        do
        {
            string input = GetUserInput().ToLower();
            if (input == "yes" || input == "no")
                return input;
            Text.Print("I'm sorry, I didn't understand that. Please type 'yes' or 'no'");
        } while (true);
    }

    

    public static int GetInt()
    {
        do
        {
            string input = GetUserInput();
            if (int.TryParse(input, out int number))
                return number;
            Text.Print("I'm sorry, that is not a valid integer. Please enter an integer.");
        } while (true);
    }
}