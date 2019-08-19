using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * class PowerMotor
     * Contains all methods relevant for power block related challenge segment generation
     */
    public class PowerMotor : Block
    {
        /*
         * Constructor to initialize name
         */
        public PowerMotor() : base()
        {
            Name = "Power";
        }

        /*
         * Overriden generateSegment function to generate a motor power related challenge segment
         * @return string - generated segment
         */
        public override string generateSegment()
        {
            string toReturn = "change the power to ";
            int num = randomNumber(1, 12);
            if(num == 11)                               // If the generated number is 11, ask for a random power
            {
                toReturn += "a random number";
            } else
            {
                toReturn += num;                        // Specify a value between 1 and 10
            }
            num = randomNumber(2, 11);                  // Specify a value between 2 and 10 seconds
            toReturn += " for " + num + " seconds";
            return toReturn;
        }
    }
}