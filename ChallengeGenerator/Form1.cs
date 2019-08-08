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
        private Block generateCodeSegment()
        {
            Block obj;
            int num = Block.randomNumber(1, 5);
            BlockNames test = (BlockNames)num;
            switch (test)
            {
                case BlockNames.SpinMotor:
                    obj = new SpinMotor();
                    //challenge += obj.generateLine();
                    break;
                case BlockNames.LightSmartHub:
                    obj = new LightSmartHub();
                    //challenge += obj.generateLine();
                    break;
                case BlockNames.PowerMotor:
                    obj = new PowerMotor();
                    //challenge += obj.generateLine();
                    break;
                case BlockNames.SoundsBlock:
                    obj = new SoundsBlock();
                    break;
                default:
                    obj = new SpinMotor();
                    break;
            }
            return obj;
            //Console.WriteLine(challenge);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblChallenge1.Text = "Challenge 1: " + generateEasyChallenge();
            System.Threading.Thread.Sleep(20);
            lblChallenge2.Text = "Challenge 2: " + generateMediumChallenge();
            System.Threading.Thread.Sleep(20);
            lblChallenge3.Text = "Challenge 3: " + generateHardChallenge();
        }

        private string generateEasyChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateLine();
            obj = generateCodeSegment();
            challenge += obj.generateLine();

            challenge += "." + repeat();
            return challenge;
        }

        private string generateMediumChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateLine();
            obj = generateCodeSegment();
            challenge += obj.generateLine();

            Block objNew;
            do
            {
                System.Threading.Thread.Sleep(20);
                objNew = generateCodeSegment();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateLine() + "." + repeat();

            return challenge;
        }

        private string generateHardChallenge()
        {
            string challenge;
            Block obj = new StartBlock();
            challenge = obj.generateLine();
            obj = generateCodeSegment();
            challenge += obj.generateLine();

            Block objNew;
            do
            {
                System.Threading.Thread.Sleep(20);
                objNew = generateCodeSegment();
            } while (obj.Name == objNew.Name);

            challenge += " and then " + objNew.generateLine();

            do
            {
                System.Threading.Thread.Sleep(20);
                obj = generateCodeSegment();
            } while (obj.Name == objNew.Name);

            challenge += " and finally " + obj.generateLine() + "." + repeat();

            return challenge;
        }

        private string repeat()
        {
            string toReturn = "";
            System.Threading.Thread.Sleep(20);
            int num = Block.randomNumber(1, 6);
            if(num == 5)
            {
                System.Threading.Thread.Sleep(20);
                num = Block.randomNumber(2, 5);
                toReturn = " Repeat this " + num + " times using the loop block.";
            }
            return toReturn;
        }
    }
}
