using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace testingproject
{
    class Program
    {
        static void Main(string[] args)
        {

            

            // Declare variables and set to empty.
            int UserInput0 = 0;


            // Intro to game. Scenario 0. User is asked to select an opponent.
            Console.WriteLine("Just How Good is the Demon Slayer Corp?\r");
            Console.WriteLine("------------------------\n");
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
                "\n\n'DON'T TELL ME WHAT TO DO!', the man-boar yelled back. 'AHHHHHHH! WHY DID YOU HAVE TO CALL ON ME LIKE THAT TANJIRO?! THIS DEMON IS SO BIG AND SCARY!!'cried Zenitsu." +
                "\nYou are certain you have enough stamina to stun two of them, leaving a fair fight." +
                "\n\nWhich opponent do you prefer to battle against?");

            Console.WriteLine("\n\n\tMake a selection of your opponent by typing the number and then press Enter: ");
            //First User Input
            Console.WriteLine("\n\t\t\t\t1 - Tanjiro Kamado");
            Console.WriteLine("\t\t\t\t2 - Hashibira Inosuke");
            Console.WriteLine("\t\t\t\t3 - Zenitsu Agatsuma\n\n");

            UserInput0 = Convert.ToInt32(Console.ReadLine()); //user types number and add conditional statement for error message if they do not pick 1,2, or 3.

            
                //Instantiate the class with user input
                if (UserInput0 == 1)
                {
                    DemonSlayer.TanjiroKamado Tanjiro1 = new DemonSlayer.TanjiroKamado(UserInput0);
                    Self Self1 = new Self(250);


                    //Round 1
                    UserInput0 = Scenario.Round1(UserInput0);
                    Tanjiro1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 2
                    Scenario.Round2(UserInput0);
                    Tanjiro1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 3
                    Scenario.Round3(UserInput0);
                    Tanjiro1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);
                }
                else if (UserInput0 == 2)
                {
                    DemonSlayer.HashibiraInosuke Inosuke1 = new DemonSlayer.HashibiraInosuke(UserInput0);
                    Self Self1 = new Self(250);


                    //Round 1
                    UserInput0 = Scenario.Round1(UserInput0);
                    Inosuke1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 2
                    Scenario.Round2(UserInput0);
                    Inosuke1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 3
                    Scenario.Round3(UserInput0);
                    Inosuke1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);
                }
                else if (UserInput0 == 3)
                {
                    DemonSlayer.ZenitsuAgatsuma Zenitsu1 = new DemonSlayer.ZenitsuAgatsuma(UserInput0);
                    Self Self1 = new Self(250);


                    //Round 1
                    UserInput0 = Scenario.Round1(UserInput0);
                    Zenitsu1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 2
                    Scenario.Round2(UserInput0);
                    Zenitsu1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);

                    //Round 3
                    Scenario.Round3(UserInput0);
                    Zenitsu1.ComboAttack(UserInput0);
                    Self1.sComboAttack(UserInput0);
                }
                else
                    Console.WriteLine("Bruh. That's not a valid input. Enter 1, 2, or 3: ");
                
            
        }
    }
}
           

            
        
     