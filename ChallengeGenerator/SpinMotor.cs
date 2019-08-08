using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeGenerator
{
    public class SpinMotor : Block
    {
        public SpinMotor()
        {
            Name = "Spin";
        }

        public override string generateLine()
        {
            string toReturn = "spin the motor ";
            int num = randomNumber(1, 3);
            switch (num)
            {
                case 1:
                    toReturn += "Clockwise for ";
                    break;
                case 2:
                    toReturn += "Anti-Clockwise for ";
                    break;
            }
            System.Threading.Thread.Sleep(20);
            num = randomNumber(1, 11);
            toReturn += num + " seconds";
            return toReturn;
            //throw new NotImplementedException();
        }
    }
}