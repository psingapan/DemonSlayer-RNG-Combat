using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingproject
{
    public partial class DemonSlayer
    {
        int userInput;
        public int randomNum;
        public static int dsHP = 300;
        Random r = new Random();


        public DemonSlayer()
        {
        }
        //Class Constructor. Requires user input
        public DemonSlayer(int input)
        {
            this.userInput = input;
        }

    }
}