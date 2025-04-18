using System;
using System.Threading;
using System.Collections.Generic;

namespace ProblematicProblem;

public class Animate
{
    public static void WaitTime()
    {
        Text.Print("Connecting to the database");
        Animation();

        Console.WriteLine("\n");
        Text.Print("Choosing your random activity");
        Animation();
        Console.WriteLine("\n");
        Thread.Sleep(400);
    }

    public static void Animation()
    {
        var animation = new List<string>() { "(O_O)", "(O_o)", "(o_o)", "(o_O)" };
        var animationExt = new List<string>() { "(O_O)", "(O_*)", "(*_*)", "(*_O)" };
        // "(^_^)", "(*_^)", 
        int cursorTop = Console.CursorTop;
        int padding = (Console.WindowWidth - 5) / 2;
        for (int i = 0; i < 10; i++)
        {
            Animate(animation);
            Animate(animationExt);
            i++;
        }

        Console.SetCursorPosition(padding - 1, cursorTop);
        Console.Write("\\(^o^)/");

        void Animate(List<string> listToAnimate)
        {
            foreach (var a in listToAnimate)
            {
                Console.SetCursorPosition(padding, cursorTop);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(a);
                Thread.Sleep(80);
            }
        }
    }


    public static void FireWorks(string name)
    {
        Console.CursorVisible = false;
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        var screenHeight = Console.WindowHeight - 1;
        var centerX = Console.WindowWidth / 2;
        var X = centerX + 5;
        var Y = screenHeight;
        
        # region FireworkTail
        Console.ForegroundColor = ConsoleColor.White;
        List<string> fireworkTail = new List<string>()
        {
            "/", "  /", "   |", "   /", "     /", "      | ", "       /", "       |", "        / ", "         | ",
            "          / ", "            /",
        };

        for (int i = 0; i < fireworkTail.Count; i++)
        {
            if (i > 4)
                PrintFirework(X, Y - i, fireworkTail[i], 25, Y - i + 5);
            else
                PrintFirework(X, Y - i, fireworkTail[i], 25);
        }
        for (int i = Y - 7; i > Y - 12; i--)
        {
            ClearLine(25, X, i);
        }

        Thread.Sleep(200);

        #endregion

        //firework center
        Console.ForegroundColor = ConsoleColor.Yellow;
        PrintFirework(X, Y - 12, "             o", 450);
        Console.SetCursorPosition(centerX, Y - 12);
        Console.Write(new string(' ', Console.WindowWidth));
        Thread.Sleep(350);

        # region FireworkExplosion

        Console.ForegroundColor = ConsoleColor.Red;
        PrintFirework(X, Y - 12, "           :   :", 100);
        PrintWithNoSleep(X, Y - 13, "           \\   /");
        PrintWithNoSleep(X, Y - 12, "         = :   : =");
        PrintWithNoSleep(X, Y - 11, "           /   \\");
        Thread.Sleep(100);
        PrintWithNoSleep(X, Y - 13, "         . \\ ' / .");
        PrintWithNoSleep(X, Y - 11, "         ' / . \\ '");
        Thread.Sleep(100);
        PrintWithNoSleep(X, Y - 14, "             :");
        PrintWithNoSleep(X, Y - 13, "        '. \\ ' / .'");
        PrintWithNoSleep(X, Y - 12, "       - = :   : = -");
        PrintWithNoSleep(X, Y - 11, "        .' / . \\ '.");
        PrintWithNoSleep(X, Y - 10, "             :");
        Thread.Sleep(600);

        #endregion
        Console.ForegroundColor = ConsoleColor.Magenta;
        PrintFirework(X-60, Y - 10, $"{name}, I hope you enjoy your activity!",0);

        //firework sparkles and firework disappear
        // sparkles
        
        PrintFirework(X + 20, Y - 14, "*", 100);
        ClearCharacter(X + 20, Y - 14);

        PrintWithNoSleep(X + 10, Y - 13, "*");
        PrintFirework(X + 1, Y - 10, "*", 100);
        ClearCharacter(X + 10, Y - 13);

        Console.ForegroundColor = ConsoleColor.Red;
        PrintWithNoSleep(X, Y - 14, "             :");
        PrintWithNoSleep(X, Y - 13, "        '. \\ ' / .'");
        PrintWithNoSleep(X, Y - 12, "       - =       = -");
        PrintWithNoSleep(X, Y - 11, "        .' / . \\ '.");
        PrintWithNoSleep(X, Y - 10, "             :");
        Thread.Sleep(50);

        PrintWithNoSleep(X, Y - 14, "             :");
        PrintWithNoSleep(X, Y - 13, "        '.   '   .'");
        PrintWithNoSleep(X, Y - 12, "       - =       = -");
        PrintWithNoSleep(X, Y - 11, "        .'   .   '.");
        PrintWithNoSleep(X, Y - 10, "             :");
        Thread.Sleep(50);

        Console.ForegroundColor = ConsoleColor.Magenta;
        PrintWithNoSleep(X + 2, Y - 13, "*");
        PrintFirework(X + 16, Y - 11, "*", 100);
        ClearCharacter(X + 1, Y - 10);

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        PrintWithNoSleep(X, Y - 14, "             :");
        PrintWithNoSleep(X, Y - 13, "        '         '");
        PrintWithNoSleep(X, Y - 12, "       -           -");
        PrintWithNoSleep(X, Y - 11, "        .         .");
        PrintWithNoSleep(X, Y - 10, "             :");
        Thread.Sleep(50);
        ClearCharacter(X + 16, Y - 11);

        Console.ForegroundColor = ConsoleColor.Magenta;
        PrintFirework(X + 12, Y - 12, "*", 100);
        PrintFirework(X + 18, Y - 9, "*", 100);

        PrintWithNoSleep(X, Y - 14, "                ");
        PrintWithNoSleep(X, Y - 13, "                    ");
        PrintWithNoSleep(X, Y - 12, "                     ");
        PrintWithNoSleep(X, Y - 11, "                    ");
        PrintWithNoSleep(X, Y - 10, "                ");
        Thread.Sleep(50);
        ClearCharacter(X + 18, Y - 9);

        PrintFirework(X + 10, Y - 10, "*", 100);
        PrintFirework(X + 18, Y - 9, "*", 100);
        ClearCharacter(X + 10, Y - 10);
        PrintFirework(X + 15, Y - 12, "*", 100);
        Thread.Sleep(50);
        ClearCharacter(X + 18, Y - 9);
        PrintFirework(X + 12, Y - 13, "*", 100);
        ClearCharacter(X + 12, Y - 13);
        Thread.Sleep(150);
        ClearCharacter(X + 15, Y - 12);
    }

    public static void PrintFirework(int pX, int pY, string message, int sleep, int LineToClear = 0)
    {
        Console.SetCursorPosition(pX, pY);
        Console.WriteLine(message);
        Thread.Sleep(sleep);
        if (LineToClear != 0)
        {
            Console.SetCursorPosition(0, LineToClear);
            Console.Write(new string(' ', Console.WindowWidth));
        }
    }


    public static void PrintWithNoSleep(int pX, int pY, string message)
    {
        Console.SetCursorPosition(pX, pY);
        Console.WriteLine(message);
    }

    public static void ClearLine(int sleepTime, int pX, int pY)
    {
        Thread.Sleep(sleepTime);
        Console.SetCursorPosition(pX, pY);
        Console.Write(new string(' ', Console.WindowWidth));
    }

    public static void ClearCharacter(int pX, int pY)
    {
        Console.SetCursorPosition(pX, pY);
        Console.Write(" ");
    }
}