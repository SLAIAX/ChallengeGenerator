using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * class StartBlock
     * Contains all methods relevant for generating the start segment for challenges
     */
    public class StartBlock : Block
    {
        /*
         * Overriden generateSegment function to generate a start segment
         * @return string - generated segment
         */
        public override string generateSegment()
        {
            int num = randomNumber(1, 3);           // 50/50 chance as to whether it will be a Letter key or start block
            string toReturn = "";
            switch (num)
            {
                case 1:
                    toReturn += "When the Start Block is pressed, ";
                    break;
                case 2:
                    num = randomNumber(0, 26);      // Generates a random letter
                    num += 65;
                    char letter = Convert.ToChar(num);
                    toReturn += "When the '" + letter + "' key is pressed, ";
                    break;
            }
            return toReturn;
        }
    }
}