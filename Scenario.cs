using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject
{
    class Scenario
    {
        // This class holds all the rounds for the game. Consists of 3 rounds, with each round recording and storing user input.
        public static int Round1(int userinput)
        {
            string dslayername = "";
            string dslayer2 = "";
            string dslayer3 = "";
            // Round 1. User is asked to select a random number that will generate two random attacks towards opponent. How do you utilize this method for a specific object and pass those object's parameters into it.

            Console.Clear();

            if (userinput == 1)
            {
                dslayername = "Tanjiro Kamado";
                dslayer2 = "Hashibira Inosuke";
                dslayer3 = "Zenitsu Agatsuma";
            }
            else if (userinput == 2)
            {
                dslayername = "Hashibira Inosuke";
                dslayer2 = "Tanjiro Kamado";
                dslayer3 = "Zenitsu Agatsuma";
            }
            else
            {
                dslayername = "Zenitsu Agatsuma";
                dslayer2 = "Tanjiro Kamado";
                dslayer3 = "Hashibira Inosuke";
            }
            Console.WriteLine("\t\t\t\t\t\tRound 1");
            Console.WriteLine($"\nAll three are mid-air charging down at you. \nYour reflexes are quick and you toss two fire bombs at {dslayer2} and {dslayer3}. " +
             $"\nThey both take a hit to the chest and fall to the floor. The damage isn't crippling and will only stun them for a couple minutes, leaving you enough time to face {dslayername} alone." +
             $"\n\n'Come at me little one!'you taunt. {dslayername} charges at you. You were prepared for this." +
             $"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");


            //Error handling
            userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput < 1 || userinput > 3)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 3, then press enter: ");
                userinput = Convert.ToInt32(Console.ReadLine());
            }
            return userinput;//user input gets returned as what came in if not less than 1 or greater than 3.
        }
        public static int Round2(int userinput)
        {
            string dslayername = "";
            // Round 2. User is asked to select a random number that will generate two random attacks towards opponent. How do you utilize this method for a specific object and pass those object's parameters into it.

            Console.Clear();
            Console.WriteLine("\t\t Round 2");
            Console.WriteLine("\n\nHAR HAR HAR " +
             $"\nThey both take a hit to the chest and fall to the floor. The damage isn't crippling and will only stun them for a couple minutes, leaving you enough time " +
             "\nto face {} alone." +
             $"\n\n'Come at me little one!'you taunt. {dslayername} charges at you. You were prepared for this." +
             $"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");


            //Error handling
            userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput < 1 || userinput > 3)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 3, then press enter: ");
                userinput = Convert.ToInt32(Console.ReadLine());
            }
            return userinput;
        }



        public static int Round3(int userinput)
        {
            string dslayername = "";
            // Round 3. User is asked to select a random number that will generate two random attacks towards opponent. How do you utilize this method for a specific object and pass those object's parameters into it.

            Console.Clear();
            Console.WriteLine("\n\nRound 3 " +
             $"\nThey both take a hit to the chest and fall to the floor. The damage isn't crippling and will only stun them for a couple minutes, leaving you enough time " +
             "\nto face {} alone." +
             $"\n\n'Come at me little one!'you taunt. {dslayername} charges at you. You were prepared for this." +
             $"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");


            //conditional statement to screen the num selection.
            userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput < 1 || userinput > 3)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 3, then press enter: ");
                userinput = Convert.ToInt32(Console.ReadLine());
            }
            return userinput;
        }
        public static void Final()
        {
            // Final scene to end game. You are winning if the demon slayer hp is passed i

            Console.Clear();

            while (true)
                if (DemonSlayer.dsHP <= 0)
                {
                    Console.WriteLine($" YYou laugh cos you won. Your opponent's {DemonSlayer.dsHP} HP is at 0");
                    break;
                }
                else if (Self.SelfHP <= 0)
                {
                    Console.WriteLine($" You lose. Your HP is at {Self.SelfHP}");
                    break;
                }
                else
                    break;

        }
    }
}