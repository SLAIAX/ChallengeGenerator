using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    public class PowerMotor : Block
    {
        public PowerMotor()
        {
            Name = "Power";
        }

        public override string generateLine()
        {
            string toReturn = "change the power to ";
            int num = randomNumber(1, 12);
            if(num == 11)
            {
                toReturn += "a random number ";
            } else
            {
                toReturn += num;
            }
            System.Threading.Thread.Sleep(20);
            num = randomNumber(1, 11);
            toReturn += " for " + num + " seconds";
            return toReturn;
        }
    }
}