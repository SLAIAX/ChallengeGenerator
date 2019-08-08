using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    public abstract class Block
    {
        private string zName;

        public string Name
        {
            get => zName;
            set
            {
                zName = value;
            }
        }
        /*
         * Function to generate a random number given a range. Inclusive of the
         * min number but not of the max
         * @param[In] min - The minimum number that can be generated
         * @param[In] max - The maximum number that can be generated
         * @return int the generated number
         */
        public static int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public abstract string generateLine();
    }
}