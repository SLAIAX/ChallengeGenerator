using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    /*
     * class DisplayBlock
     * Contains all methods relevant for Display Block related challenge segment generation
     */
    public class DisplayBlock : Block
    {
        /*
         * Constructor to initialize name
         */
        public DisplayBlock()
        {
            Name = "Display";
        }

        /*
         * Overriden generateSegment function to generate a display related challenge segment
         * @return string - generated segment
         */
        public override string generateSegment()
        {
            string toReturn = "";
            int num = randomNumber(1, 3);
            switch (num)
            {
                case 1:
                    timedPic(ref toReturn);
                    break;
                case 2:
                    counter(ref toReturn);
                    break;
            }
            return toReturn;
        }

        /*
         * Function to generate a picture related challenge segment
         * @param[in] toReturn - A string reference, the generated challenge segment is assigned to it
         */
        public void timedPic(ref string toReturn)
        {
            int num = randomNumber(1, 31);          //Choose a picture
            if (num == 30)                          //If 30, ask for a random picture
            {
                toReturn = "display a random picture for ";
            } else
            {
                toReturn = "display picture number " + num + " for ";
            }
            num = randomNumber(2, 6);               //Choose number of seconds
            toReturn += num + " seconds";
        }

        /*
         * Function to generate a counter related challenge segment
         * @param[in] toReturn - A string reference, the generated challenge segment is assigned to it
         */
        public void counter(ref string toReturn)
        {
            int num = randomNumber(0, 10);          //Choose starting number
            toReturn = "create a display that counts from " + num + " to ";
            num = randomNumber((num + 5), 31);      //Choose final number
            toReturn += num;
        }
    }
}