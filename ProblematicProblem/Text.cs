using System;
using System.Threading;
using System.Collections.Generic;

namespace ProblematicProblem;

public static class Text
{
    public static void Print(string text)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        int padding = (Console.WindowWidth + text.Length) / 2;
        Console.WriteLine(text.PadLeft(padding));
    }
    public static void EndGame(string text)
    {
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        int padding = (Console.WindowWidth + text.Length) / 2;
        Console.WriteLine(text.PadLeft(padding));
        
        Console.WriteLine(text);
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

}