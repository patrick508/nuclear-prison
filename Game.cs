using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Text_Based_App {
    public static class Game {
        public static string CharacterName = "";
        static int Scenarios = 6;

        //Function that writes text to console, wait a random amount of ms inbetween letters for typewrite effect
        //Enter skips typing and Writeline makes sure text is placed on different lines.
        public static void TypeWrite(string message) {
            var rand = new Random();
            int index = 0;
            do {
                while (!Console.KeyAvailable) {
                    Console.Write(message[index]);
                    index++;
                    if (index >= message.Length) break;
                        System.Threading.Thread.Sleep(rand.Next(30, 70));
                }
                if (index >= message.Length) break; // Required not to force enter press.
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            if (index < message.Length)
                Console.Write(message.Substring(index, message.Length - index));
            Console.WriteLine();
        }

        public static void StartGame() {
            HomeScreen();
            NameCharacter();
            Choice();
            EndGame();
        }

        //Game title
        static void TitelArt() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔╗╔┬ ┬┌─┐┬  ┌─┐┌─┐┬─┐  ╔═╗┬─┐┬┌─┐┌─┐┌┐┌ ");
            Console.WriteLine("║║║│ ││  │  ├┤ ├─┤├┬┘  ╠═╝├┬┘│└─┐│ ││││ ");
            Console.WriteLine("╝╚╝└─┘└─┘┴─┘└─┘┴ ┴┴└─  ╩  ┴└─┴└─┘└─┘┘└┘ ");
            Console.ResetColor();
        }

        //End screen settings & text
        public static void EndGame() {
            TitelArt();
            TypeWrite("You finished the game!");
            TypeWrite("Good job " + CharacterName + "!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWrite("\nMade by Patrick Klokgieters");
            Console.ForegroundColor = ConsoleColor.Yellow;
            TypeWrite("\nCopyright © 2018 All Rights Reserved.");
        }

        //Start screen settings & text
        static void HomeScreen() {
            TitelArt();
            Console.ForegroundColor = ConsoleColor.Cyan;
            TypeWrite("Good luck on your journey!");
            Console.ForegroundColor = ConsoleColor.Green;
            TypeWrite("Press Enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.Clear();
        }

        //Ask player for name and save it in CharacterName - if name of less than 1 character is given, call Mr. NoName
        public static void NameCharacter() {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeWrite("Name your character...");
            Console.ResetColor();
            CharacterName = Console.ReadLine();
            if (CharacterName.Length <= 1) {
                TypeWrite("You're not going to give me your name? Very well.... We'll call you Mr. NoName!");
                CharacterName = "Mr. NoName";
                Console.ForegroundColor = ConsoleColor.Green;
                TypeWrite("\nPress Enter to continue...");
                Console.ResetColor();
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            }
            Console.Clear();
        }

        //Write out everything based on choices player made.
        static void Choice() {
            for (int part = 1; part <= Scenarios; part++) {
                string input = "";
                //part = 2;
                switch (part) {
                    #region Case 1
                    case 1:
                        //Story starts
                        TypeWrite(Story.PartOne[0]);


                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();

                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartOne[1]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartOne[2]);
                                break;
                            }
                        }

                        //Story continues.
                        TypeWrite(Story.PartOne[3]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.ResetColor();
                        Console.Clear();

                        //Story continues
                        TypeWrite(Story.PartOne[4]);
                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();
                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartOne[5]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartOne[6]);
                                break;
                            }
                        }

                        //At end of state
                        TypeWrite(Story.PartOne[7]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    #endregion
                    #region Case 2
                    case 2:
                        //Story starts
                        TypeWrite(Story.PartTwo[0]);
                        TypeWrite(Story.PartTwo[1]);

                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();

                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartTwo[2]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartTwo[3]);
                                CharacterName = "Cpt. Douchebag";
                                break;
                            }
                        }

                        //Story continues.
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();

                        //Story continues
                        TypeWrite(Story.PartTwo[4]);
                        TypeWrite(Story.PartTwo[5]);
                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();
                            //Check if Player chooses A or B
                            if (input == "a") {
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartTwo[6]);
                                break;
                            }
                        }

                        //Story continues.
                        TypeWrite(Story.PartTwo[7]);
                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice....");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();
                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartTwo[8]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartTwo[9]);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                TypeWrite(Story.PartTwo[10]);
                                Console.ResetColor();
                                TypeWrite(Story.PartTwo[11]);
                                break;
                            }
                        }

                        //At end of state
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    #endregion 
                    #region Case 3
                    case 3:
                        //Story starts
                        TypeWrite(Story.PartThree[0]);
                        TypeWrite(Story.PartThree[1]);
                        TypeWrite(Story.PartThree[2]);

                        //Enter to continue
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();

                        TypeWrite(Story.PartThree[3]);
                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();

                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartThree[4]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartThree[5]);
                                break;
                            }
                        }
                        //Enter to continue
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();

                        //Story continues.
                        TypeWrite(Story.PartThree[6]);
                        TypeWrite(Story.PartThree[7]);
                        break;
                    #endregion
                    #region Case 4
                    case 4:
                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            //Player chooses.
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();
                            //Check if Player chooses A or B- BIG CHOISE
                            if (input == "a") {
                                Console.Clear();
                                TypeWrite(Story.PartFourA[0]);
                                TypeWrite(Story.PartFourA[1]);
                                TypeWrite(Story.PartFourA[2]);
                               // input = "";
                                while (input != "a" || input != "b") {
                                    //Player chooses.
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TypeWrite("Enter your choice....");
                                    Console.ResetColor();
                                    input = Console.ReadLine();
                                    input = input.ToLower();
                                    if (input == "a") {
                                        TypeWrite(Story.PartFourA[3]);
                                        break;
                                    }
                                    else if (input == "b") {
                                        TypeWrite(Story.PartFourA[4]);
                                        break;
                                    }
                                }
                                TypeWrite(Story.PartFourA[5]);
                                break;
                            }
                            else if (input == "b") {
                                Console.Clear();
                                TypeWrite(Story.PartFourB[0]);
                                TypeWrite(Story.PartFourB[1]);
                                TypeWrite(Story.PartFourB[2]);
                                input = "";
                                //Player chooses.
                                Console.ForegroundColor = ConsoleColor.Green;
                                TypeWrite("Enter your choice...");
                                Console.ResetColor();
                                input = Console.ReadLine();
                                input = input.ToLower();
                                while (input != "a" || input != "b") {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    TypeWrite("Enter your choice....");
                                    Console.ResetColor();
                                    input = Console.ReadLine();
                                    input = input.ToLower();
                                    if (input == "a") {
                                        TypeWrite(Story.PartFourB[3]);
                                        break;
                                    }
                                    else if (input == "b") {
                                        TypeWrite(Story.PartFourB[4]);
                                        break;
                                    }
                                }
                                TypeWrite(Story.PartFourB[5]);
                                break;
                            }
                        }
                        //At end of state
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                    #endregion
                    #region Case 5
                    case 5:
                        //Story starts
                        TypeWrite(Story.PartFive[0]);

                        //Keep running loop until one of if statements breaks it.
                        while (input != "a" || input != "b") {
                            //Player chooses.
                            Console.ForegroundColor = ConsoleColor.Green;
                            TypeWrite("Enter your choice...");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            input = input.ToLower();

                            //Check if Player chooses A or B
                            if (input == "a") {
                                TypeWrite(Story.PartFive[1]);
                                break;
                            }
                            else if (input == "b") {
                                TypeWrite(Story.PartFive[2]);
                                break;
                            }
                        }

                        TypeWrite(Story.PartFive[3]);
                        TypeWrite(Story.PartFive[4]);
                        TypeWrite(Story.PartFive[5]);

                        //Enter to continue
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();

                        TypeWrite(Story.PartFive[6]);
                        TypeWrite(Story.PartFive[7]);
                        break;
                    #endregion

                    //if part number doesnt match any other case
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeWrite("Press Enter to continue...");
                        Console.ResetColor();
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                }
            }
        }
    }
}