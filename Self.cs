using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace testingproject
{
    public class Self
    {
        public static int SelfHP = 250;
        public new string[] attackDescrip = { "", "Blood Demon Art: Fire Blood Enragement. Snapping flames. The user generates", "Blood Demon Art: Fire Blood Enragement: Ignition", "Blood Demon Art: Spewing Lava" };
        public new int[] damagePoints = { 0,30, 40, 60 };
        Random r = new Random();


        public Self(int hp)
        {
            Self.SelfHP = hp;
        }

        public int sComboAttack(int num)
        {
            
            int rnum = r.Next(3);

            Console.WriteLine($"\nYou snarl and leap towards the demon slayer...");
            Console.WriteLine($"You damage Tanjiro for - {Scenario.UserInput0*(damagePoints[Scenario.UserInput0] + damagePoints[rnum])}.");
            Console.WriteLine($"You strike Tanjiro with {attackDescrip[Scenario.UserInput0]} + {attackDescrip[rnum]}.");

            DemonSlayer.dsHP = DemonSlayer.dsHP - (Scenario.UserInput0 * (damagePoints[Scenario.UserInput0] + damagePoints[rnum]));

            //add if statement to end game if hp is 0. switch to final scene then end game.

            if (DemonSlayer.dsHP <= 0)
            {
                Scenario.Final();
            }
            Console.WriteLine($"\n\n\t\t\t\t\t\tYour opponent's HP: {DemonSlayer.dsHP}");
            Console.WriteLine($"\t\t\t\t\t\tYour HP: {SelfHP}");

            Console.WriteLine("\n\n\t\t\t\t\t\tEnd of Combat ");
            Console.WriteLine("\n\nNext round.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();


            return DemonSlayer.dsHP;
        }

    }
}