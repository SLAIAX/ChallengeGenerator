using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /*
         * Function to randomly choose an action block out of all possible action blocks
         * @return Block - the chosen block object
         */
        private Block chooseBlock()
        {
            Block obj;                                                    //Utilizes polymorphism
            int num = Block.randomNumber(1, (Block.TotalBlocks + 1));     //Generates a random number between 1 and the maximum number of action Blocks
            BlockNames test = (BlockNames)num;
            switch (test)
            {
                case BlockNames.SpinMotor:
                    obj = new SpinMotor();
                    break;
                case BlockNames.LightSmartHub:
                    obj = new LightSmartHub();
                    break;
                case BlockNames.PowerMotor:
                    obj = new PowerMotor();
                    break;
                case BlockNames.SoundsBlock:
                    obj = new SoundsBlock();
                    break;
                case BlockNames.DisplayBlock:
                    obj = new DisplayBlock();
                    break;
                default:
                    obj = new SpinMotor();
                    break;
            }
            return obj;
        }

        /*
         * On the generate buttons click, generate and update all the challenge labels
         */
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                lblChallenge1.Text = "Challenge 1: " + generateEasyChallenge();
                lblChallenge2.Text = "Challenge 2: " + generateMediumChallenge();
                lblChallenge3.Text = "Challenge 3: " + generateHardChallenge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message  + Environment.NewLine + Environment.NewLine + "If this error persists, please contact Jordan with the details.");
            }
        }

        /*
         * Function to generate an easy challenge which will comprise of 1 blocks action
         * and the chance of repeating the whole thing
         * @return string - the generated challenge
         */
        private string generateEasyChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateSegment();
            obj = chooseBlock();
            challenge += obj.generateSegment();

            challenge += "." + repeat();
            return challenge;
        }

        /*
         * Function to generate a medium challenge which will comprise of 2 block segments
         * which will be of different block types and has the chance of repeating the whole thing
         * @return string - the generated challenge
         */
        private string generateMediumChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateSegment();
            obj = chooseBlock();
            challenge += obj.generateSegment();

            Block objNew;
            do
            {
                objNew = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateSegment() + "." + repeat();

            return challenge;
        }

        /*
         * Function to generate a medium challenge which will comprise of 3 block segments
         * which will be of at least 2 different block types with the chance of repeating the whole thing
         * @return string - the generated challenge
         */
        private string generateHardChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateSegment();
            obj = chooseBlock();
            challenge += obj.generateSegment();

            Block objNew;
            do
            {
                objNew = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateSegment();

            do
            {
                obj = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and finally " + obj.generateSegment() + "." + repeat();

            return challenge;
        }

        /*
         * Function to decide whether the challenge should be looped
         * 1 in 5 chance of it being looped
         * @return the generated string if any
         */
        private string repeat()
        {
            string toReturn = "";
            int num = Block.randomNumber(1, 6);                             //Generate a number between 0 and 6
            if(num == 5)                                                    //If it's a 5, repeat the code segment
            {
                num = Block.randomNumber(2, 6);                             //Generate a new random number to specify how many times to repeat it
                toReturn = " Repeat this ";
                if (num == 5)                                               //If it's a 5 generated, it will be repeated an infinite amount of times
                {
                    toReturn += "an infinite amount of times.";
                }
                else                                                        //Else it will repeat the number of times according to the generated number
                {
                    toReturn += num + " times using the loop block.";
                }
            }
            return toReturn;
        }
    }
}
