using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject
{
    class Scenario // This class holds all the rounds for the game. Consists of 3 rounds, with each round recording and storing user input.
    {
        public static int UserInput0;
        private static string dslayername = ""; // I set these private, and static to understand how public vs. private modifiers work.
        private static string dslayer2 = "";
        private static string dslayer3 = "";

        public Scenario()
        {
        }
        public static int Round0()  // Intro to game. Scenario 0. User is asked to select an opponent.
        {
            
            Console.WriteLine("\t\t\t\tJust How Good is the Demon Slayer Corp?\r");
            Console.WriteLine("\t\t\t\t\t------------------------\n");
            Console.WriteLine("You are a class 5 demon being hunted by members of the Demon Slayer Corp, an elite group determined to extinguish" +
                "\nall demons from the face of the earth.You flee the village you've ravaged using your paranormal sprint to escape towards the woods." +
                " You hear shouting behind you and choose to ignore it. Humans are slow and worthless anyway. They won't catch up." +
                "\n\nYou see the forest's neck right over the hill. Once you enter the woods, a territory where other demons reside, you're safe." +
                " You make the final charge towards the first set of trees you see, increasing your speed..." +
                "\n\nSuddenly you feel a swift wind in front and suddenly halt. A fierce slash cuts you off and nearly severs your nose. " +
                " You look up to find a teenager with his sword charged at you. He dives with his sword aimed at your head, but you dodge it." +
                "\n\nYou leap back to gain ground between the teenage boy with earrings and notice that there are two others beside him. To his left is a blonde teenage boy wearing" +
                "\nan orange kimono, and to his right, a shirtless man wearing a boar head." +
                "\n\n\t'HAHAHA', you loudly remark. 'COME AT ME NOOBS!'" +
                "\n\nThe teenager with the earrings yelled to the man-boar, 'Inosuke, get on his flank and Zenitsu will cover the right!'" +
                "\n\n'DON'T TELL ME WHAT TO DO!', the man-boar grunted back. 'AHHHHHHH! WHY DID YOU HAVE TO CALL ON ME LIKE THAT TANJIRO?! THIS DEMON IS SO BIG AND SCARY!!'cried Zenitsu." +
                "\nYou are certain you have enough stamina to stun two of them, leaving a fair fight." +
                "\n\nWhich opponent do you prefer to battle against?");

            Console.WriteLine("\n\n\tMake a selection of your opponent by typing the number and then press Enter: ");
            Console.WriteLine("\n\t\t\t\t1 - Tanjiro Kamado");
            Console.WriteLine("\t\t\t\t2 - Hashibira Inosuke");
            Console.WriteLine("\t\t\t\t3 - Zenitsu Agatsuma\n\n");

            //First User Input with error handling
            try
            {
                Scenario.UserInput0 = Convert.ToInt32(Console.ReadLine());
                if (!(1 <= Scenario.UserInput0 && Scenario.UserInput0 <= 3))
                    Round0();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Round0();
            }
            return Scenario.UserInput0;
        }
        
        public static int Round1(int userinput)
        {
            // Round 1. User is asked to select a random number that will generate two random attacks towards opponent. How do you utilize this method for a specific object and pass those object's parameters into it.

            Console.Clear();

            int input = userinput;
            switch (input)
            {
            
                case 1:
            
                Scenario.dslayername = "Tanjiro Kamado";
                Scenario.dslayer2 = "Hashibira Inosuke";
                Scenario.dslayer3 = "Zenitsu Agatsuma";
                    break;

                case 2: 
            
                Scenario.dslayername = "Hashibira Inosuke";
                Scenario.dslayer2 = "Tanjiro Kamado";
                Scenario.dslayer3 = "Zenitsu Agatsuma";
                    break;
            
                default:
            
                Scenario.dslayername = "Zenitsu Agatsuma";
                Scenario.dslayer2 = "Tanjiro Kamado";
                Scenario.dslayer3 = "Hashibira Inosuke";
                    break;

            }

            Console.WriteLine("\t\t\t\t\t\tRound 1");
            Console.WriteLine($"\n\n...The demon slayers have you surrounded, but you are certain you can escape. Afterall, you have a hefty advantage of being a demon...strength and power..." +
                $"\n\n\t'Inosuke! I see the cut! I'm going now!', Tanjiro exclaimed. You suddenly notice two demon slayers mid-air diving towards you... \n\nYour reflexes are quick and you toss two soundwave stuns bombs at {dslayer2} and {dslayer3}. " +
             $"\nThey both take a hit to the chest and fall to the floor. The damage isn't crippling and will only stun them for a couple minutes, leaving you enough time to face {dslayername} alone." +
             $"\n\n\t'MUAHAHAHA! Come at me little one!'you taunt. {Scenario.dslayername} charges at you. You were prepared for this."); 
            Console.WriteLine($"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");

            //Error handling
            try
            {
                Scenario.UserInput0 = Convert.ToInt32(Console.ReadLine());

                if (!(1 <= Scenario.UserInput0 && Scenario.UserInput0 <= 3))
                    Round1(userinput);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Round1(userinput);

            }
            return userinput;
        }

        public static int Round2(int userinput) // Round 2. User is asked to select a random number that will generate two random attacks towards opponent.
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tRound 2");
            Console.WriteLine($"\n\n...You quickly dodge another one of {Scenario.dslayername}'s strikes. This kid is fast but you know you've got this. He dashes towards you... " +
             $"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");

            //Error handling
            try
            {
                Scenario.UserInput0 = Convert.ToInt32(Console.ReadLine());

                if (!(1 <= Scenario.UserInput0 && Scenario.UserInput0 <= 3))
                    Round2(userinput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Round2(userinput);

            }
            return userinput;
        }

        public static int Round3(int userinput) // Round 3. User is asked to select a random number that will generate two random attacks towards opponent.
        {

            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tRound 3");
            Console.WriteLine("\n\n...You both take a knee to the chest and fall to the floor.This kid is doing way more damage than the speed of my healing! At this rate I'll bleed to death before my head is cut! " +
             $"\nYou collect yourself for this one last fight." +
             $"\n\n\t'Show me what you've got, {Scenario.dslayername}!', you roar." +
             $"\n\n{Scenario.dslayername} charges at you. You were prepared for this." +
             $"\n\n\n\nPick a number 1,2, or 3 that will return back a unique combo attack then press enter: ");

            try
            {
                Scenario.UserInput0 = Convert.ToInt32(Console.ReadLine());

                if (!(1 <= Scenario.UserInput0 && Scenario.UserInput0 <= 3))
                    Round3(userinput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Round3(userinput);

            }
            return userinput;
        }
        public static void Final()
        {
            // Final scene to end game.

            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tFinal Scene");
            while (true)
           
                if (DemonSlayer.dsHP <= 0)
                {
                    Console.WriteLine($"\n\nYou laugh. \nYou finish {Scenario.dslayername} with a blowing strike.\n\n {Scenario.dslayername} HP is at {DemonSlayer.dsHP}.");
                    break;
                }
                else if (Self.SelfHP <= 0)
                {
                    Console.WriteLine($"\n\nYou lose. {Scenario.dslayername} finishes you with a blowing strike.\n\n Your HP is at {Self.SelfHP}");
                    Console.WriteLine("\n\nTo be continued...thanks for playing!");
                    break;
                }
            System.Environment.Exit(0);

        }
    }
}