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
        public class HashibiraInosuke : DemonSlayer
        {
            //creating properties and fields
            public static int InosukeHP = 250;
            public new string[] attackDescrip = {"",
                "Beast Breathing... \nFirst Fang: Pierce. The user stabs the target's neck with both blades.",
                "Beast Breathing... \nSecond Fang: Slice. The user unleashes a double slash with his two blades in an X-shaped cut.",
                "Beast Breathing... \nFThird Fang: Devour. The user releases simultaneous horizontal slashes towards the target's throat."};
            public new int[] damagePoints = { 0,30, 40, 60 };
            public int Inosukeinput;

            public HashibiraInosuke()
            {
            }

            public int ComboAttack(int num)
            {
                Console.Clear();
                int rnum = r.Next(3);

                //User attacks opponent and returns back Self HP.
                Console.WriteLine("\t\t\t\t\t\tStarting combat...");
                Console.WriteLine($"\n\nInosuke launches at you...");
                Console.WriteLine($"Inosuke damages you for - {Scenario.UserInput0 * (damagePoints[Scenario.UserInput0] + damagePoints[rnum])}.");
                Console.WriteLine($"Inosuke strikes you with {attackDescrip[Scenario.UserInput0]}.");
                Self.SelfHP = Self.SelfHP - (Scenario.UserInput0 * (damagePoints[Scenario.UserInput0] + damagePoints[rnum]));

                if (Self.SelfHP <= 0)
                {
                    Scenario.Final();
                }
                return Self.SelfHP;
            }
        }
    }
}