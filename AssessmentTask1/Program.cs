using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainMenu = true;
            bool continuePlaying = true;

            int rollCount = 0;
            List<int> history = new List<int>();


            int diceRoll;
            int rollsRemaining;

            Console.WriteLine("Welcome to Swinburne's Caves & Lizards Club:");
            while (mainMenu == true)
            {
                Console.WriteLine();
                Console.WriteLine("This is the Main Menu");
                Console.WriteLine("Would you like to (Roll) dice, (View) your statistics, or (End) the program? ");
                string menu = Console.ReadLine();
                menu = menu.ToLower();

                if (menu == "roll")
                {
                    while (continuePlaying == true)
                    {
                        bool choice = false;

                        Console.WriteLine();
                        Console.WriteLine("You have chosen to roll the dice of fate, good luck adventurer");
                        Console.WriteLine("Would you like to roll (1)d6, (2)d6, or (other)? ");
                        string input = Console.ReadLine();
                        input = input.ToLower();


                        if (input == "1")
                        {
                            rollsRemaining = 1;
                            Console.WriteLine();
                            Console.WriteLine("Rolling 1d6... ");

                            while (rollsRemaining > 0)
                            {
                                Random Dice = new Random();
                                diceRoll = Dice.Next(1, 7);

                                Console.WriteLine(diceRoll);
                                history.Add(diceRoll);

                                rollCount++;
                                rollsRemaining--;
                                Console.ReadKey();
                            }
                        }

                        else if (input == "2")
                        {
                            rollsRemaining = 2;
                            Console.WriteLine();
                            Console.WriteLine("Rolling 2d6... ");

                            while (rollsRemaining > 0)
                            {

                                Random Dice = new Random();
                                diceRoll = Dice.Next(1, 7);

                                Console.WriteLine(diceRoll);
                                history.Add(diceRoll);

                                rollCount++;
                                rollsRemaining--;
                                Console.ReadKey();
                            }
                        }

                        else if (input == "other")
                        {
                            Console.WriteLine();
                            Console.WriteLine("How many sides on the dice would you like? ");
                            int rollSides = int.Parse(Console.ReadLine());

                            Console.WriteLine("How many times would you like to roll your d" + rollSides + "? ");
                            rollsRemaining = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                            Console.WriteLine("Rolling " + rollsRemaining + "d" + rollSides + "... ");

                            while (rollsRemaining > 0)
                            {
                                Random Dice = new Random();
                                diceRoll = Dice.Next(1, (rollSides + 1));

                                Console.WriteLine(diceRoll);
                                history.Add(diceRoll);

                                rollCount++;
                                rollsRemaining--;
                                Console.ReadKey();
                            }
                        }
                        while (choice == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Would you like to roll again? (Y)es or (N)o? ");
                            string rollAgain = Console.ReadLine();
                            rollAgain = rollAgain.ToUpper();

                            if (rollAgain == "Y")
                            {
                                continuePlaying = true;
                                choice = true;
                            }
                            else if (rollAgain == "N")
                            {
                                continuePlaying = false;
                                choice = true;
                            }
                            else
                            {
                                choice = false;
                                Console.WriteLine();
                                Console.WriteLine("Please choose either Y for Yes, or N for No");
                            }
                        }
                    }
                }
                else if (menu == "view")
                {
                    if (rollCount == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("It appears as though you haven't rolled anything yet, go have some fun and roll some dice before you check back here!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Would you like to check a (S)pecific number of rolls, or (A)ll statistics?");
                        string statChoice = Console.ReadLine();
                        statChoice = statChoice.ToLower();

                        if (statChoice == "s")
                        {
                            Console.WriteLine();
                            Console.WriteLine("How many rolls do yo want to see? ");
                            int amount = int.Parse(Console.ReadLine());

                            for (int i = 0; i < amount; i++)
                            {
                                int num = history[i];
                                Console.Write(num + " ");
                            }
                        }
                        else if (statChoice == "a")
                        {
                            int total = history.Sum();
                            int average = total / rollCount;

                            Console.WriteLine();
                            Console.WriteLine("Here are all the stats: ");
                            Console.WriteLine("You have rolled a total of " + rollCount + " dice! Nice man.");
                            Console.WriteLine();
                            Console.WriteLine("Your total for all the dice is equal to " + total);
                            Console.WriteLine();
                            Console.WriteLine("Your average is " + average);
                            Console.WriteLine();
                            Console.WriteLine("Rolls: ");
                            foreach(int i in history)
                            {
                                Console.Write(i + " ");
                            }



                        }
                        else
                        {
                            Console.WriteLine("Lets go back to the menu then? Yeah? ");
                        }
                    }
                }
                else if (menu == "end")
                {
                    mainMenu = false;
                }
                Console.WriteLine();
            }
            /*Random Dice = new Random();
            int r = Dice.Next(1,6);
            Console.WriteLine(r);
            */


            Console.ReadKey();
        }
    }
}
