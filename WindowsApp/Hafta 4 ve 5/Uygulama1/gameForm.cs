using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama1
{
    public partial class GameForm : Form
    {
        private bool isLogin;

        private int sec;

        private int

                matchGameCount,
                mathGameCount;

        private int

                countMatch,
                countMath;

        private int timeMemory;

        private string userName;

        private string SelectedGame;

        private readonly Random randomize = new Random();

        private int

                addend1,
                addend2,
                timeLeft;

        private Label firstClicked;

        private Label secondClicked;

        private List<string>
            icons =
                new List<string>()
                {
                    "*",
                    "*",
                    "+",
                    "+",
                    "!",
                    "!",
                    "#",
                    "#",
                    "?",
                    "?",
                    "=",
                    "=",
                    "<",
                    "<",
                    ";",
                    ";"
                };

        public GameForm()
        {
            InitializeComponent();
            isLogin = false;
            firstClicked = null;
            secondClicked = null;
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            Counter.Text = "Last Sec : " + sec;
            sec--;
            if (sec == -1)
            {
                LoginTimer.Stop();
                isLogin = false;
                DialogResult login =
                    MessageBox
                        .Show("Please log in within the given time.. (Press yes if you want to again try.)",
                        "Time out",
                        MessageBoxButtons.YesNo);
                if (login == DialogResult.Yes)
                {
                    sec = 10;
                    Counter.Text = "Last Sec : " + sec;
                    LoginTimer.Start();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[0];
            ((Control)(SCBTabCntrl.TabPages[1])).Enabled = false;
            ((Control)(SCBTabCntrl.TabPages[2])).Enabled = false;
            LoginTimer.Start();
            Counter.Text = " " + sec;
            sec = 10;
            timeMemory = 10;
            timeLeft = 60;
        }

        private void SCBTabCntrl_SelectedIndexChanged(object sender,EventArgs e )
  
        {
            if (isLogin == false)
            {
                if (SCBTabCntrl.SelectedTab != SCBTabCntrl.TabPages[0])
                {
                    MessageBox.Show("Warning please login first.");
                    SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[0];
                }
            }
            else
            {
                /*TsLoginBtn.Enabled = false;
                if (SCBTabCntrl.SelectedTab == SCBTabCntrl.TabPages[0])
                    MessageBox.Show("Already you maked login");
                if (SelectedGame == "Game1")
                {
                    SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[1];
                }
                else if (SelectedGame == "Game2")
                {
                    SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[2];
                }
                */
                ((Control)(SCBTabCntrl.TabPages[1])).Enabled = true;
                ((Control)(SCBTabCntrl.TabPages[2])).Enabled = true;
            }
        }

        private void TsGameStart_Click(object sender, EventArgs e)
        {
            SelectedGame = "Game1";
            countMatch++;
            icons =
                new List<string>()
                {
                    "*",
                    "*",
                    "+",
                    "+",
                    "!",
                    "!",
                    "#",
                    "#",
                    "?",
                    "?",
                    "=",
                    "=",
                    "<",
                    "<",
                    ";",
                    ";"
                }; // If you want to play this forever you have to write this
            TsGameStart.Enabled = false;
            TsGameStart2.Enabled = false;
            matchGameCount = 0;
            timerMem.Start();
            timeMemory--;
            firstClicked = null;
            secondClicked = null;

            // Assigment
            foreach (Control cell in tableLayoutPanel1.Controls)
            {
                Random randomGen = new Random();
                if (cell is Label cellLabel)
                {
                    int index = randomGen.Next(icons.Count);
                    cellLabel.Text = icons[index];
                    icons.RemoveAt (index);
                }
            }
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label controlLabel)
                {
                    if (
                        controlLabel.ForeColor == controlLabel.BackColor // There is a reverse card
                    ) return;
                }
            }
            gameTimer.Stop();
            TsGameStart.Enabled = true;
            TsGameStart2.Enabled = true;
            MessageBox
                .Show("You are Winner !" + " Total Time :" + matchGameCount);

            // Assigment
            foreach (Control cell in tableLayoutPanel1.Controls)
            {
                if (cell is Label cellLabel)
                {
                    cell.Text = "Ş";
                    timeMemory = 10;
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (
                SelectedGame == "Game1" // Matching Game
            )
            {
                if (timeMemory == -1)
                    gameSec.Text = "Total Time :" + matchGameCount;

                matchGameCount++;
            }
            else if (
                SelectedGame == "Game2" // Math Quiz Game
            )
            {
                if (
                    CheckAnswer() //True
                )
                {
                    gameTimer.Stop();
                    MessageBox
                        .Show("You are Winner !" +
                        " Total Time :" +
                        mathGameCount);
                    TsGameStart.Enabled = true;
                    TsGameStart2.Enabled = true;
                    plusLeft.Text = "Num";
                    plusRight.Text = "Num";
                    minusLeft.Text = "Num";
                    minusRight.Text = "Num";
                }
                else if (timeLeft > 0)
                {
                    mathGameCount++;
                    timeLeft--;
                    lastTimer.Text = "Remaining time : " + timeLeft.ToString();
                }
                else
                {
                    gameTimer.Stop();
                    TsGameStart.Enabled = true;
                    TsGameStart2.Enabled = true;
                    plusLeft.Text = "Num";
                    plusRight.Text = "Num";
                    minusLeft.Text = "Num";
                    minusRight.Text = "Num";

                    MessageBox.Show("You lose Time out");
                }
            }
        }

        private bool CheckAnswer()
        {
            bool answer = false;
            if (
                addend1 + addend2 == plusAnswer.Value &&
                addend1 - addend2 == minusAnswer.Value
            )
            {
                answer = true;
            }
            return answer;
        }

        private void TimerMem_Tick(object sender, EventArgs e)
        {
            gameSec.Text = "Last Sec : " + timeMemory;
            timeMemory--;
            if (timeMemory == -1)
            {
                gameTimer.Start();
                timerMem.Stop();

                //Return card
                foreach (Control cell in tableLayoutPanel1.Controls)
                {
                    if (cell is Label cellLabel)
                    {
                        cellLabel.ForeColor = cellLabel.BackColor;
                    }
                }
            }
        }

        private new void Click(object sender, EventArgs e)
        {
            Label clickCard = sender as Label;
            if (
                clickCard.ForeColor == clickCard.BackColor //Turn inside out card
            )
            {
                clickCard.ForeColor = Color.Black; // Return normal
                if (firstClicked == null)
                {
                    firstClicked = clickCard;
                }
                else if (secondClicked == null)
                {
                    secondClicked = clickCard;

                    if (firstClicked.Text == secondClicked.Text)
                    {
                        MessageBox.Show("Same card foud");

                        // MessageBox.Show("Same card found," + " Total Time " + gameCounter + ": Sec");
                        CheckForWinner();
                    }
                    else
                    {
                        MessageBox.Show("Not Same Card");
                        firstClicked.ForeColor = firstClicked.BackColor; //Turn inside out card
                        secondClicked.ForeColor = secondClicked.BackColor; //Turn inside out card
                    }
                    firstClicked = null;
                    secondClicked = null;
                }
                else
                {
                    // No Else
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Write a name");
            }
            else
            {
                userName = textBox1.Text;
                isLogin = true;
                label1.Text = "Select Game";
                textBox1.Visible = false;
                button1.Visible = false;

                LoginTimer.Stop();
                Counter.Text = "";
            }
        }

        private void MiniGame1ToolStripMenuItem_Click(object sender, EventArgs e)
     
        {
            if (isLogin != false)
            {
                SelectedGame = "Game1";
                SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[1];
                ((Control)(SCBTabCntrl.TabPages[1])).Enabled = true;
                ((Control)(SCBTabCntrl.TabPages[2])).Enabled = true;
            }
            else
            {
                MessageBox.Show("First you can login");
            }
        }

        private void MiniGame2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogin != false)
            {
                SelectedGame = "Game2";

                SCBTabCntrl.SelectedTab = SCBTabCntrl.TabPages[2];
                ((Control)(SCBTabCntrl.TabPages[1])).Enabled = true;
                ((Control)(SCBTabCntrl.TabPages[2])).Enabled = true;
            }
            else
            {
                MessageBox.Show("First you can login");
            }
        }

        private void TsGameStart2_Click(object sender, EventArgs e)
        {
            countMath++;
            SelectedGame = "Game2";
            gameTimer.Start();
            StartQuiz();
            TsGameStart.Enabled = false;
            TsGameStart2.Enabled = false;
            timeLeft = 60;
            mathGameCount = 0;
        }

        private void StartQuiz()
        {
            addend1 = randomize.Next(51);
            addend2 = randomize.Next(51);

            plusLeft.Text = addend1.ToString();
            plusRight.Text = addend2.ToString();

            minusLeft.Text = addend1.ToString();
            minusRight.Text = addend2.ToString();

            lastTimer.Text = "Remaining time : " + timeLeft.ToString();
            gameTimer.Start();
        }

        private void UserAbout_Click(object sender, EventArgs e)
        {
            if (isLogin == true)
            {
                UserAbout userAB = new UserAbout
                {
                    userKad = userName,

                    countMatchgame = countMatch,
                    countMathgame = countMath
                };

                if (userAB.bestCountmatch1 != null)

                    userAB.bestCountmatch2 = matchGameCount;
                else
                    userAB.bestCountmatch1 = matchGameCount;


                if (userAB.bestCountmath1 != null)

                    userAB.bestCountmath2 = mathGameCount;
                else
                    userAB.bestCountmath1 = mathGameCount;

                userAB.ShowDialog();
            }
            else
            {
                MessageBox.Show("First you can login");
            }
        }
    }
}
/*
       \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/
