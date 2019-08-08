using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    public class SoundsBlock : Block
    {
        public SoundsBlock()
        {
            Name = "Sound";
        }

        public override string generateLine()
        {
            string toReturn;
            int num = randomNumber(0, 30);
            if(num == 0)
            {
                toReturn = "play a custom sound";
            }
            else if(num == 29){
                toReturn = "play a random sound";
            }
            else
            {
                toReturn = "play sound number " + num;
            }
            return toReturn;
        }
    }
}