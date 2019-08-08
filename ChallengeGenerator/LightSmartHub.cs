using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * class LightSmartHub
     * Contains all methods relevant for Light Block related challenge segment generation
     */
    public class LightSmartHub : Block
    {
        /*
         * Constructor to initialize the name
         */
        public LightSmartHub()
        {
            Name = "Colour";
        }

        /*
         * Overriden generateSegment function to generate a light related challenge segment
         * @return string - generated segment
         */
        public override string generateSegment()
        {
            string toReturn = "change the colour on the Smart-Hub to ";
            int num = randomNumber(1, 12);
            //Possible colours: pink, purple, blue, sky blue, teal, green, yellow, orange, red, and white.
            switch (num)
            {
                case 1:
                    toReturn += "pink";
                    break;
                case 2:
                    toReturn += "purple";
                    break;
                case 3:
                    toReturn += "blue";
                    break;
                case 4:
                    toReturn += "blue";
                    break;
                case 5:
                    toReturn += "sky blue";
                    break;
                case 6:
                    toReturn += "teal";
                    break;
                case 7:
                    toReturn += "green";
                    break;
                case 8:
                    toReturn += "yellow";
                    break;
                case 9:
                    toReturn += "orange";
                    break;
                case 10:
                    toReturn += "red";
                    break;
                case 11:
                    toReturn += "a random colour";
                    break;
            }
            return toReturn;
        }
    }
}