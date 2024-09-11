﻿using System.Runtime.CompilerServices;

namespace Topic_4._5___Methods_Tutorial
{
    // Christian Moyes
    internal class Program
    {
        static void Main(string[] args)
        {
            int bugs;
            int choice;
            string exitChoice;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1 - Joke");
                Console.WriteLine("2 - Ascii");

                while (!Int32.TryParse(Console.ReadLine().Trim(), out choice) || choice != 1 && choice != 2)
                {
                    Console.WriteLine("That is not a valid choice, try again.");
                }

                if (choice == 1)
                {
                    Console.WriteLine("What kind of joke would you like?");
                    Console.WriteLine();
                    Console.WriteLine("1 - Computer joke");
                    Console.WriteLine("2 - knock-knock joke");

                    while (!Int32.TryParse(Console.ReadLine().Trim(), out choice) || choice != 1 && choice != 2)
                    {
                        Console.WriteLine("That is not a valid choice, try again");
                    }

                    if (choice == 1)
                    {
                        Console.WriteLine("How many bugs are in the code?");

                        while (!Int32.TryParse(Console.ReadLine().Trim(), out bugs) || bugs < 0)
                        {
                            Console.WriteLine("That doesn't even make sense, try again.");
                        }

                        if (bugs == 0)
                        {
                            Console.WriteLine("Oh, okay... I can't really make a joke about that :(");
                        }
                        else
                        {
                            Joke(bugs);
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("NOT READY YET");
                    }
                }




                Console.WriteLine("Would you like to continue? (y/n)");

                exitChoice = Console.ReadLine().Trim().ToLower();

                while (exitChoice != "y" && exitChoice != "n")
                {
                    Console.WriteLine("That is not a valid choice, try again.");
                    exitChoice = Console.ReadLine().Trim().ToLower();
                }

                if (exitChoice == "y")
                {
                    Console.WriteLine("Okay!");
                    Console.WriteLine();
                }
                else if(exitChoice == "n")
                {
                    Console.WriteLine("Okay, goodbye");
                    done = true;
                }
            }
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine($"{numBugs} little bugs in the code");
            Thread.Sleep(1000);
            Console.WriteLine($"{numBugs} little bugs.");
            Thread.Sleep(1000);
            Console.WriteLine($"Fix a bug, run in again,");
            Thread.Sleep(1000);
            Console.WriteLine($"{numBugs + 1} little bugs in the code");
        }

        public static void DrawSpider()
        {
            Console.WriteLine();
            Console.WriteLine("                   ,,,,");
            Console.WriteLine("             ,;) .';;;;',");
            Console.WriteLine(" ;;,,_,-.-.,;;'_,|(\\;;;/),,_");
            Console.WriteLine("  `';;/:|:);{ ;;;|| \\;/ /;;;\\__");
            Console.WriteLine("      L;/-';/ \\;;\\',/;\\/;;;.') \\");
            Console.WriteLine("      .:`''` - \\;;'.__/;;;/  . _'-._");
            Console.WriteLine("    .'/   \\     \\;;;;;;/.'_7:.  '). \\_");
            Console.WriteLine("  .''/     | '._ );}{;//.'    '-:  '.,\\");
            Console.WriteLine(".'. /       \\  ( |;;;/_/         \\._./;\\   _,");
            Console.WriteLine(" . /        |\\ ( /;;/_/             ';;;\\,;;_,");
            Console.WriteLine(". /         )__(/;;/_/                (;;'''''");
            Console.WriteLine(" /        _;:':;;;;:';-._             );");
            Console.WriteLine("/        /   \\  `'`   --.'-._         \\/");
            Console.WriteLine("       .'     '.  ,'         '-,");
            Console.WriteLine("      /    /   r--,..__       '.\\");
            Console.WriteLine("    .'    '  .'        '--._     ]");
            Console.WriteLine("    (     :.(;>        _ .' '- ;/");
            Console.WriteLine("    |      /:;(    ,_.';(   __.'");
            Console.WriteLine("     '- -'\"|;:/    (;;;;-'--'");
            Console.WriteLine("           |;/      ;;(");
            Console.WriteLine("           ''      /;;|");
            Console.WriteLine("                   \\;;|");
            Console.WriteLine("                    \\/");
            Console.WriteLine();
            Console.WriteLine("Get me more pictures of Spiderman!");
            Console.WriteLine();
        }

        public static void DrawChar()
        {
            Console.WriteLine();
            Console.WriteLine("              _.--\"\"`-..");
            Console.WriteLine("            ,'          `.");
            Console.WriteLine("           ,'          __  `.");
            Console.WriteLine("           /|          \" __   \\");
            Console.WriteLine("            , |           / |.   .");
            Console.WriteLine("         |,'          !_.'|   |");
            Console.WriteLine("         ,'             '   |   |");
            Console.WriteLine("      /              |`--'|   |");
            Console.WriteLine("       |                `---'   |");
            Console.WriteLine("       .   ,                   |                       ,\".");
            Console.WriteLine("      ._     '           _'  |                    , ' \\ `");
            Console.WriteLine("  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|");
            Console.WriteLine("    |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\");
            Console.WriteLine("-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .");
            Console.WriteLine("   `,         \"\"\"\"'     `.              ,'         |   |  ',,");
            Console.WriteLine("    `.      '            '            /          '    |'. |/");
            Console.WriteLine("      `.   |              \\       _,-'           |       ''");
            Console.WriteLine("        `._'               \\   '\"\\                .      |");
            Console.WriteLine("            |                '     \\                `._  ,'");
            Console.WriteLine("           |                 '     \\                 .'|");
            Console.WriteLine("           |                 .      \\                | |");
            Console.WriteLine("            |                 |       L              ,' |");
            Console.WriteLine("            `                 |       |             /   '");
            Console.WriteLine("             \\                |       |           ,'   /");
            Console.WriteLine("           ,' \\               |  _.._ ,-..___,..-'    ,'");
            Console.WriteLine("          /     .             .      `!             ,/'");
            Console.WriteLine("         /       `.          /        .           .'/");
            Console.WriteLine("        .          `.       /         |        _.'.'");
            Console.WriteLine("         `.          7`'---'          |------\"'_.'");
            Console.WriteLine("        _,.`,_     _'                ,''-----\"'");
            Console.WriteLine("     _,-_    '       `.     .'      ,\\");
            Console.WriteLine("    -\" /`.         _,'     | _  _  _.|");
            Console.WriteLine("     \"\"--'---\"\"\"\"\"'        `' '! |! /");
            Console.WriteLine("                             `\" \" -'");
            Console.WriteLine();
            Console.WriteLine("Charmander used ember!");
            Console.WriteLine();
        }

        public static void TrollFace()
        {
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⢀⣤⠤⠤⠤⠤⠤⠤⠤⠤⠤⠤⢤⣤⣀⣀⡀⠀⠀⠀⠀⠀⠀");
            Console.WriteLine("⠀⠀⠀⠀⢀⡼⠋⠀⣀⠄⡂⠍⣀⣒⣒⠂⠀⠬⠤⠤⠬⠍⠉⠝⠲⣄⡀⠀⠀");
            Console.WriteLine("⠀⠀⠀⢀⡾⠁⠀⠊⢔⠕⠈⣀⣀⡀⠈⠆⠀⠀⠀⡍⠁⠀⠁⢂⠀⠈⣷⠀⠀");
            Console.WriteLine("⠀⠀⣠⣾⠥⠀⠀⣠⢠⣞⣿⣿⣿⣉⠳⣄⠀⠀⣀⣤⣶⣶⣶⡄⠀⠀⣘⢦⡀");
            Console.WriteLine("⢀⡞⡍⣠⠞⢋⡛⠶⠤⣤⠴⠚⠀⠈⠙⠁⠀⠀⢹⡏⠁⠀⣀⣠⠤⢤⡕⠱⣷");
            Console.WriteLine("⠘⡇⠇⣯⠤⢾⡙⠲⢤⣀⡀⠤⠀⢲⡖⣂⣀⠀⠀⢙⣶⣄⠈⠉⣸⡄⠠⣠⡿");
            Console.WriteLine("⠀⠹⣜⡪⠀⠈⢷⣦⣬⣏⠉⠛⠲⣮⣧⣁⣀⣀⠶⠞⢁⣀⣨⢶⢿⣧⠉⡼⠁");
            Console.WriteLine("⠀⠀⠈⢷⡀⠀⠀⠳⣌⡟⠻⠷⣶⣧⣀⣀⣹⣉⣉⣿⣉⣉⣇⣼⣾⣿⠀⡇⠀");
            Console.WriteLine("⠀⠀⠀⠈⢳⡄⠀⠀⠘⠳⣄⡀⡼⠈⠉⠛⡿⠿⠿⡿⠿⣿⢿⣿⣿⡇⠀⡇⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠙⢦⣕⠠⣒⠌⡙⠓⠶⠤⣤⣧⣀⣸⣇⣴⣧⠾⠾⠋⠀⠀⡇⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠙⠶⣭⣒⠩⠖⢠⣤⠄⠀⠀⠀⠀⠀⠠⠔⠁⡰⠀⣧⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠲⢤⣀⣀⠉⠉⠀⠀⠀⠀⠀⠁⠀⣠⠏⠀");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠛⠒⠲⠶⠤⠴⠒⠚⠁⠀⠀");
            Console.WriteLine();
            Console.WriteLine("You've");
            Thread.Sleep(1000);
            Console.WriteLine("Been");
            Thread.Sleep(1000);
            Console.WriteLine("TROLLED!");
            Console.WriteLine();
        }



    }
}
