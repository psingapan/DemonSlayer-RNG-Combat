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
            private string name = "Zenitsu Agatsuma";
            public static int ZenitsuHP = 250;
            public new string[] attackDescrip = {
                "Thunder Breathing: First Form: Thunderclap and Flash. The user unsheathes their blade, dashes forward at blinding speeds and decapitates the opponent faster than they can react", 
                "Thunder Breathing: Second Form: Rice Spirit. Kaigaku unleashes five electrified arching slashes all in a single moment.", 
                "Third Form: Thunder Swarm: Kaigaku surrounds the enemy with powerful waves of electricity and sword slashes that slice up the enemy in all directions."};
            public new int[] damagePoints = { 30, 40, 60 };
            public int Zenitsuinput;


            //constructor with parameter
            public ZenitsuAgatsuma(int input)
            {
                this.Zenitsuinput = input;
            }
            public ZenitsuAgatsuma(string name, string[] attacks, int[] damage, int input)
            {
                this.Zenitsuinput = input;
                this.attackDescrip = attacks;
                this.damagePoints = damage;
                this.name = name;
            }


            public int ComboAttack(int num)
            {
                int rnum = r.Next(3);

                //User attacks opponent and returns back Self HP.
                Console.WriteLine($"\n\nZenitsu charges at you...");
                Console.WriteLine($"Zenitsu damages you for - {damagePoints[num] + damagePoints[rnum]}.");
                Console.WriteLine($"Zenitsu strikes you with {attackDescrip[num]}.");
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