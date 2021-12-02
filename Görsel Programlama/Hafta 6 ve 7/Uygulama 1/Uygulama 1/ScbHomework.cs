using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/

namespace Uygulama_1
{
    public partial class ScbHomework : Form
    {
        private STATUS gameStatus;

        private int gameCounter;

        private int sumOfDice;

        private int myPoint;

        private int Count;
        List<Image> listDice = new List<Image>();

        private  Random randomNum = new Random();

        private  Random ranAnim = new Random();

        private enum STATUS
        {
            IDLE,
            CONTINUE,
            WON,
            LOST
        }

        private enum DiceNames
        {
            Snake_Eye = 2,
            Trey = 3,
            Seven = 8,
            Yo_Leven = 11,
            Box_Cars = 12
        }

        public ScbHomework()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameStatus = STATUS.IDLE;
            Count = 0;
            StopBTN.Enabled = false;

            listDice.Add(Properties.Resources.Dice1);
            listDice.Add(Properties.Resources.Dice2);
            listDice.Add(Properties.Resources.Dice3);
            listDice.Add(Properties.Resources.Dice4);
            listDice.Add(Properties.Resources.Dice5);
            listDice.Add(Properties.Resources.Dice6);
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            TextArea.Text = "";
            gameStatus = STATUS.CONTINUE;
            gameCounter = 0;
            myPoint = 0;
            timerClock.Start();
            StartBTN.Enabled = false;
            StopBTN.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            Count = 0;

            //First Dice
            TextArea.Text = TextArea.Text + "\n\r" + "First Roll \n\r";
            sumOfDice = RollDice();

            if ((DiceNames) sumOfDice == DiceNames.Yo_Leven)
            {
                gameStatus = STATUS.WON;
                TextArea.Text = TextArea.Text + "\n\r" + "YOU WON " + "\n\r";
                StopGame();
            }
            else if ((DiceNames) sumOfDice == DiceNames.Box_Cars)
            {
                gameStatus = STATUS.LOST;
                TextArea.Text = TextArea.Text + "\n\r" + "YOU LOST " + "\n\r";
                StopGame();
            }
            else
            {
                gameStatus = STATUS.CONTINUE;
                myPoint = sumOfDice;
                TimerGame.Start();
            }
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            label1.Text = "Point " + myPoint.ToString();
            label2.Text = "Roll the Dice " + Count.ToString();
            gameCounter++;
            GameSec.Text = gameCounter.ToString() + " Sec";
            if ((gameCounter % 10)== 0)
            {                      
                TextArea.Text = TextArea.Text + "\n\r" + "_____________________________________________ \n\r";

                TextArea.Text = TextArea.Text + "\n\r" + "Next Rolls \n\r";
                sumOfDice = RollDice();

                //Game Tornament
                if (sumOfDice == myPoint)
                    gameStatus = STATUS.WON;
                else if (sumOfDice == (int)DiceNames.Seven)
                    gameStatus = STATUS.LOST;
                else
                    gameStatus = STATUS.CONTINUE;

                if (gameStatus == STATUS.WON)
                {
                    TextArea.Text = TextArea.Text + "\n\r" + "YOU WON " + "\n\r";
                    StopGame();
                }
                else if (gameStatus == STATUS.LOST)
                {
                    TextArea.Text = TextArea.Text + "\n\r" + "YOU LOST " + "\n\r";
                    StopGame();
                }
                TextArea.Text = TextArea.Text + "\n\r" + "_____________________________________________ \n\r";
            }
            else if ((gameCounter % 10) >=4)
            {
                RandDiceAnim();
            }
                  
        }

        private int RandDiceAnim()
        {
            int anim = randomNum.Next(1, 7);
            int anim2 = randomNum.Next(1, 7);
            if (anim == 1)
                pictureBox1.Image = Properties.Resources.Dice1;
            else if (anim == 2)
                pictureBox1.Image = Properties.Resources.Dice2;
            else if (anim == 3)
                pictureBox1.Image = Properties.Resources.Dice3;
            else if (anim == 4)
                pictureBox1.Image = Properties.Resources.Dice4;
            else if (anim == 5)
                pictureBox1.Image = Properties.Resources.Dice5;
            else if (anim == 6) pictureBox1.Image = Properties.Resources.Dice6;

            if (anim2 == 1)
                pictureBox2.Image = Properties.Resources.Dice1;
            else if (anim2 == 2)
                pictureBox2.Image = Properties.Resources.Dice2;
            else if (anim2 == 3)
                pictureBox2.Image = Properties.Resources.Dice3;
            else if (anim2 == 4)
                pictureBox2.Image = Properties.Resources.Dice4;
            else if (anim2 == 5)
                pictureBox2.Image = Properties.Resources.Dice5;
            else if (anim2 == 6) pictureBox2.Image = Properties.Resources.Dice6;

            return anim;
        }

        private void StopGame()
        {
            StartBTN.Enabled = true;
            StopBTN.Enabled = false;
            TimerGame.Stop();
            timerClock.Stop();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label1.Text = "";

        }

        private int RollDice()
        {
            Count++;
            int Dice1 = randomNum.Next(1, 7);
            int Dice2 = randomNum.Next(1, 7);
            TextArea.Text =
                TextArea.Text +
                "\n\r" +
                "Dice 1 = " +
                Dice1.ToString() +
                " Dice 2 = " +
                Dice2.ToString() +
                "\n"+
                 "\r Total : " +
                (Dice1 + Dice2).ToString()+
                "\n\r";

            if (Dice1 == 1)
                pictureBox1.Image = Properties.Resources.Dice1;
            else if (Dice1 == 2)
                pictureBox1.Image = Properties.Resources.Dice2;
            else if (Dice1 == 3)
                pictureBox1.Image = Properties.Resources.Dice3;
            else if (Dice1 == 4)
                pictureBox1.Image = Properties.Resources.Dice4;
            else if (Dice1 == 5)
                pictureBox1.Image = Properties.Resources.Dice5;
            else if (Dice1 == 6) pictureBox1.Image = Properties.Resources.Dice6;

            if (Dice2 == 1)
                pictureBox2.Image = Properties.Resources.Dice1;
            else if (Dice2 == 2)
                pictureBox2.Image = Properties.Resources.Dice2;
            else if (Dice2 == 3)
                pictureBox2.Image = Properties.Resources.Dice3;
            else if (Dice2 == 4)
                pictureBox2.Image = Properties.Resources.Dice4;
            else if (Dice2 == 5)
                pictureBox2.Image = Properties.Resources.Dice5;
            else if (Dice2 == 6) pictureBox2.Image = Properties.Resources.Dice6;

            return Dice1 + Dice2;
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/