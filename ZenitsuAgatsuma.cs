using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace testingproject
{

    partial class DemonSlayer
    {
        public class ZenitsuAgatsuma : DemonSlayer
        {
            //creating properties and fields
            public static int ZenitsuHP = 250;
            public new string[] attackDescrip = {"",
                "Thunder Breathing... \nFirst Form: Thunderclap and Flash. The user unsheathes their blade, dashes forward at blinding speeds and decapitates the opponent faster than they can react", 
                "Thunder Breathing...\nSecond Form: Rice Spirit. Kaigaku unleashes five electrified arching slashes all in a single moment.", 
                "Thunder Breathing...\nThird Form: Thunder Swarm. Kaigaku surrounds the enemy with powerful waves of electricity and sword slashes that slice up the enemy in all directions."};
            public new int[] damagePoints = { 0,30, 40, 60 };
            public int Zenitsuinput;

            public ZenitsuAgatsuma(int input)
            {
                this.Zenitsuinput = input;
            }
            public int ComboAttack(int num)
            {
                Console.Clear();
                int rnum = r.Next(3);

                Console.WriteLine("\t\t\t\t\t\tStarting combat...");
                //User attacks opponent and returns back Self HP.
                Console.WriteLine($"\n\nZenitsu dashes towards you...");
                Console.WriteLine($"Zenitsu damages you for - {Scenario.UserInput0 * (damagePoints[Scenario.UserInput0] + damagePoints[rnum])}.");
                Console.WriteLine($"Zenitsu strikes you with {attackDescrip[Scenario.UserInput0]}.");
                Self.SelfHP = Self.SelfHP - (Scenario.UserInput0*(damagePoints[Scenario.UserInput0] + damagePoints[rnum]));

                if (Self.SelfHP <= 0)
                {
                    Scenario.Final();
                }
                return Self.SelfHP;
            }
        }
    }
}