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
            private string name = "Tanjiro Kamado";
            public static int TanjiroHP = 250;
            public new string[] attackDescrip = {"Total Concentration: \nFirst Form: Water Surface Slash. \nDescription: The user generates enough momentum to create a powerful single concentrated slash.",
                "Total Concentration: \nWater Breathing Second Form: Water Wheel. \nDescription: The user leaps and vertically spins forward in the air while releasing a flowing attack in a circular motion.",
                    "Total Concentration: \nWater Breathing Third Form: Flowing Dance. \nDescription: The user leaps and vertically spins forward in the air while releasing a flowing attack in a circular motion."};
            public new int[] damagePoints = { 30, 40, 60 };
            public int Tanjiroinput;


            //constructor with parameter
            public TanjiroKamado(int input)
            {
                this.Tanjiroinput = input;
            }
            public TanjiroKamado(string name, string[] attacks, int[] damage, int input)
            {
                this.Tanjiroinput = input;
                this.attackDescrip = attacks;
                this.damagePoints = damage;
                this.name = name;
            }


            public int ComboAttack(int num)
            {
                int rnum = r.Next(3);

                //User attacks opponent and returns back Self HP.
                Console.WriteLine($"\n\nTanjiro charges at you...");
                Console.WriteLine($"Tanjiro damages you for - {damagePoints[num] + damagePoints[rnum]}.");
                Console.WriteLine($"Tanjiro strikes you with {attackDescrip[num]}.");
                Self.SelfHP = Self.SelfHP - (damagePoints[num] + damagePoints[rnum]);

                if (Self.SelfHP <= 0)
                {
                    Scenario.Final();
                }
                return Self.SelfHP;


            }
        }
    }
}