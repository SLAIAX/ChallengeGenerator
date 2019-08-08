using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * Abstract Block class used as a template for all 'action blocks' supplied by the WeDo 2.0 language
     */
    public abstract class Block
    {
        private string zName;                               //< The name of the block
        private static Random _random = new Random();       //< The Static random object used to only seed once. 
        private static int _totalBlocks = 5;                //< The total number of action blocks

        /*
         * Accessor for the Blocks names
         */
        public string Name
        {
            get => zName;
            set
            {
                zName = value;
            }
        }

        /*
         * Accessor for the total amount of action blocks
         */
        public static int TotalBlocks
        {
            get => _totalBlocks;
        }

        /*
         * Function to generate a random number given a range. Inclusive of the
         * min number but not of the max
         * @param[In] min - The minimum number that can be generated
         * @param[In] max - The maximum number that can be generated
         * @return int - the generated number
         */
        public static int randomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        /*
         *Function to generate a section of a challenge which in itself can exist on it's own
         * @return string - the generated challenge string
         */
        public abstract string generateSegment();
    }
}