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
            Scenario.Round0();

            //Instantiates the opponent based on input from Round 0.
            if (Scenario.UserInput0 == 1)
            {
                DemonSlayer.TanjiroKamado Tanjiro1 = new DemonSlayer.TanjiroKamado();
                Self Self1 = new Self(250);

                //Round 1,2,3
                Self1.sComboAttack(Tanjiro1.ComboAttack(Scenario.Round1(Scenario.UserInput0)));
                Self1.sComboAttack(Tanjiro1.ComboAttack(Scenario.Round2(Scenario.UserInput0)));
                Self1.sComboAttack(Tanjiro1.ComboAttack(Scenario.Round3(Scenario.UserInput0)));
            }

            else if (Scenario.UserInput0 == 2)
            {
                DemonSlayer.HashibiraInosuke Inosuke1 = new DemonSlayer.HashibiraInosuke();
                Self Self1 = new Self(250);

                //Round 1,2,3
                Self1.sComboAttack(Inosuke1.ComboAttack(Scenario.Round1(Scenario.UserInput0)));
                Self1.sComboAttack(Inosuke1.ComboAttack(Scenario.Round2(Scenario.UserInput0)));
                Self1.sComboAttack(Inosuke1.ComboAttack(Scenario.Round3(Scenario.UserInput0)));
            }
            else if (Scenario.UserInput0 == 3)
            {
                DemonSlayer.ZenitsuAgatsuma Zenitsu1 = new DemonSlayer.ZenitsuAgatsuma(Scenario.UserInput0);
                Self Self1 = new Self(250);

                //Round 1,2,3
                Self1.sComboAttack(Zenitsu1.ComboAttack(Scenario.Round1(Scenario.UserInput0)));
                Self1.sComboAttack(Zenitsu1.ComboAttack(Scenario.Round2(Scenario.UserInput0)));
                Self1.sComboAttack(Zenitsu1.ComboAttack(Scenario.Round3(Scenario.UserInput0)));
                Scenario.Final();
            }
                
        }
    }
}
           

            
        
     