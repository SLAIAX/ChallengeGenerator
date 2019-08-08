using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    public class StartBlock : Block
    {
        public override string generateLine()
        {
            int num = randomNumber(1, 3);
            string toReturn = "";
            switch (num)
            {
                case 1:
                    toReturn += "When the Start Block is pressed, ";
                    break;
                case 2:
                    num = randomNumber(0, 26);
                    num += 65;
                    char letter = Convert.ToChar(num);
                    toReturn += "When the '" + letter + "' key is pressed, ";
                    break;
            }
            return toReturn;
        }
    }
}