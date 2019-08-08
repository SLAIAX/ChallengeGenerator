using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * class SpinMotor
     * Contains all methods relevant for direction block related challenge segment generation
     */
    public class SpinMotor : Block
    {
        /*
         * Constructor to initialize name
         */
        public SpinMotor()
        {
            Name = "Spin";
        }

        /*
         * Overriden generateSegment function to generate a motor direction related challenge segment
         * @return string - generated segment
         */
        public override string generateSegment()
        {
            string toReturn = "spin the motor ";
            int num = randomNumber(1, 3);           // 50/50 chance for it to specify clockwise or anti-clockwise
            switch (num)
            {
                case 1:
                    toReturn += "Clockwise for ";
                    break;
                case 2:
                    toReturn += "Anti-Clockwise for ";
                    break;
            }
            num = randomNumber(1, 11);
            toReturn += num + " seconds";
            return toReturn;
        }
    }
}