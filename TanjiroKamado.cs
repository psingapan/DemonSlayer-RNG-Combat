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
        public class TanjiroKamado : DemonSlayer
        {
            //creating properties and fields
            public static int TanjiroHP;
            public new string[] attackDescrip = {"","Total Concentration... \nFirst Form: Water Surface Slash. The user generates enough momentum to create a powerful single concentrated slash.",
                "Total Concentration... \nWater Breathing Second Form: Water Wheel. The user leaps and vertically spins forward in the air while releasing a flowing attack in a circular motion.",
                    "Total Concentration... \nWater Breathing Third Form: Flowing Dance. The user leaps and vertically spins forward in the air while releasing a flowing attack in a circular motion."};
            public new int[] damagePoints = { 0,30, 40, 60 };
            public int Tanjiroinput;

            public TanjiroKamado() 
            {
            }
     
            public int ComboAttack(int num) //AI attacks user and returns back (user)Self HP.
            {

                Console.Clear();
                int rnum= r.Next(3);

                Console.WriteLine("\t\t\t\t\t\tStarting combat...");
                Console.WriteLine($"\n\n\nTanjiro charges at you...");
                Console.WriteLine($"Tanjiro damages you for - {(Scenario.UserInput0*damagePoints[Scenario.UserInput0] + damagePoints[rnum])}.");
                Console.WriteLine($"Tanjiro strikes you with {attackDescrip[Scenario.UserInput0]}.");
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