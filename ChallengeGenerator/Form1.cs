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
        private bool looped = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbLevel.SelectedItem = "Level 1";
            looped = false;
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
                if (cmbLevel.SelectedItem == "Level 1")
                {
                    generateLevelOneChallenges();
                }
                else
                {
                    generateLevelTwoChallenges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "If this error persists, please contact Jordan with the details.");
            }
        }

        /*
         * Function to generate an easy challenge which will comprise of 1 blocks action
         * and the chance of repeating the whole thing
         * @return string - the generated challenge
         */
        private string generateEasyChallenge()
        {
            looped = false;
            string challenge;
            Block obj = chooseBlock();
            challenge = obj.generateSegment();
            looped = obj.Looped;

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
            looped = false;
            string challenge;
            Block obj = chooseBlock();
            challenge = obj.generateSegment();
            looped = obj.Looped;

            Block objNew;
            do
            {
                objNew = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateSegment();

            if (!looped)
            {
                looped = objNew.Looped;
            }
            
                
            challenge += "." + repeat();

            return challenge;
        }

        /*
         * Function to generate a medium challenge which will comprise of 3 block segments
         * which will be of at least 2 different block types with the chance of repeating the whole thing
         * @return string - the generated challenge
         */
        private string generateHardChallenge()
        {
            looped = false;
            string challenge;
            Block obj = chooseBlock();
            challenge = obj.generateSegment();
            looped = obj.Looped;

            Block objNew;
            do
            {
                objNew = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateSegment();

            if(!looped)
            {
                looped = objNew.Looped;
            }

            do
            {
                obj = chooseBlock();
            } while (obj.Name == objNew.Name);

            challenge += " and finally " + obj.generateSegment();
            if (!looped)
            {
                looped = obj.Looped;
            }

            challenge += "." + repeat();

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
            if (looped == false)
            {
                int num = Block.randomNumber(1, 6);                             //Generate a number between 0 and 6
                if (num == 5)                                                   //If it's a 5, repeat the code segment
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
            }
            return toReturn;
        }

        /*
         * Function to generate Sensor specific challenges
         */
        public void generateLevelTwoChallenges()
        {

            SensorNames _sensor = (SensorNames)Block.randomNumber(1, 4);
            Block obj;
            int num;
            switch (_sensor)
            {
                case SensorNames.Motion:
                    lblChallenge1.Text = "Challenge 1: When the model is tilted forward, " + generateEasyChallenge();

                    obj = chooseBlock();
                    lblChallenge2.Text = "Challenge 2: When the model is tilted backward, " + generateMediumChallenge();

                    num = Block.randomNumber(1, 3);
                    obj = chooseBlock();
                    if (num == 1)
                    {
                        lblChallenge3.Text = "Challenge 3: When the model is tilted left, " + generateHardChallenge();
                    }
                    else
                    {
                        lblChallenge3.Text = "Challenge 3: When the model is tilted right, " + generateHardChallenge();
                    }
                    break;
                case SensorNames.Distance:
                    int dist1, dist2, dist3;
                    dist1 = Block.randomNumber(1, 16);                              //Generate a random distance between 1 and 15 (the maximum detectable distance)
                    lblChallenge1.Text = "Challenge 1: When the distance is " + dist1 + " centimenters away, " + generateEasyChallenge();

                    do
                    {
                        dist2 = Block.randomNumber(1, 16);
                    } while (dist2 == dist1);
                    lblChallenge2.Text = "Challenge 2: When the distance is " + dist2 + " centimenters away, " + generateMediumChallenge();

                    do
                    {
                        dist3 = Block.randomNumber(1, 16);
                    } while (dist3 == dist1 || dist3 == dist2);
                    lblChallenge3.Text = "Challenge 3: When the distance is " + dist3 + " centimenters away, " + generateHardChallenge();

                    break;
                case SensorNames.Sound:
                    int vol1, vol2, vol3;
                    vol1 = Block.randomNumber(1, 16);                              //Generate a random distance between 1 and 15 (the maximum detectable distance)
                    lblChallenge1.Text = "Challenge 1: When the volume is " + vol1 + ", " + generateEasyChallenge();

                    do
                    {
                        vol2 = Block.randomNumber(1, 16);
                    } while (vol2 == vol1);
                    lblChallenge2.Text = "Challenge 2: When the volume is " + vol2 + ", " + generateMediumChallenge();

                    do
                    {
                        vol3 = Block.randomNumber(1, 16);
                    } while (vol3 == vol1 || vol3 == vol2);
                    lblChallenge3.Text = "Challenge 3: When the volume is " + vol3 + ", " + generateHardChallenge();
                    break;
            }

        }

        /*
         * Function to generate Level one (broad) challenges
         */
        public void generateLevelOneChallenges()
        {
            string challenge = "Challenge 1: ";
            Block obj = new StartBlock();
            challenge += obj.generateSegment();
            lblChallenge1.Text = challenge + generateEasyChallenge();

            obj = new StartBlock();
            challenge = "Challenge 2: " + obj.generateSegment();
            lblChallenge2.Text = challenge + generateMediumChallenge();

            obj = new StartBlock();
            challenge = "Challenge 3: " + obj.generateSegment();
            lblChallenge3.Text = challenge + generateHardChallenge();
        }

        /*
         * Function is called whenever the text in the corresponding textbox is changed.
         * It will adjust the font-size of all challenge labels accordingly
         */
        private void tbxFontSize_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
