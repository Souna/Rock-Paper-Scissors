using System;
using System.Drawing;
using System.Windows.Forms;
/*A rock paper scissors game I wrote in C# because I got bored.
There may be horrible code, but I made this primarily to learn.
Image resources seem crazy, I was too lazy to fix that up.
Criticism welcome.

Made by: Souna
*/
namespace RPS
{
    public partial class frmRPS : Form
    {
        Random rand = new Random();
        string[] RockPaperScissors =  { "Rock", "Paper", "Scissors" };
        string PlayerSelection;
        int timeLeft;
        public frmRPS()
        {
            InitializeComponent();
        }

        private void Roll()
        {
            int cpuRoll = rand.Next(3) + 1;

            switch (cpuRoll)
            {
                case 1:
                    lblDisplayCPUroll.Text = RockPaperScissors[0];
                    break;
                case 2:
                    lblDisplayCPUroll.Text = RockPaperScissors[1];
                    break;
                case 3:
                    lblDisplayCPUroll.Text = RockPaperScissors[2];
                    break;
            }
            GetGameResults(cpuRoll);
        }

        private void GetGameResults(int cpuRoll)
        {
            lblYourRoll.Visible = true;
            lblCpuRoll.Visible = true;

            if (PlayerSelection == RockPaperScissors[0]) //if you picked rock
            {
                lblDisplayYourRoll.Text = RockPaperScissors[0];

                if (cpuRoll == 1)  //cpu has rock
                {
                    lblResult.ForeColor = Color.DimGray;
                    lblResult.Text = "It's a Tie";
                }
                else if (cpuRoll == 2)  //cpu has paper
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "You Lose!";
                }
                else  //cpu has scissors
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "You Win!";
                }
            }
            else if (PlayerSelection == RockPaperScissors[1]) //if you picked paper
            {
                lblDisplayYourRoll.Text = RockPaperScissors[1];

                if (cpuRoll == 1) //cpu has rock
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "You Win!";
                }
                else if (cpuRoll == 2) //cpu has paper
                {
                    lblResult.ForeColor = Color.DimGray;
                    lblResult.Text = "It's a Tie";
                }
                else //cpu has scissors
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "You Lose!";
                }
            }
            else if (PlayerSelection == RockPaperScissors[2])  //if you picked scissors
            {
                lblDisplayYourRoll.Text = RockPaperScissors[2];

                if (cpuRoll == 1) //cpu has rock
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "You Lose!";
                }
                else if (cpuRoll == 2) //cpu has paper
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "You Win!";
                }
                else  //cpu has scissors
                {
                    lblResult.ForeColor = Color.DimGray;
                    lblResult.Text = "It's a Tie";
                }
            }
            else  //chose nothing
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "You chose nothing, so you lose.";
                picSadFace.Visible = true;
                lblYourRoll.Visible = false;
                lblDisplayYourRoll.Text = "";
                lblCpuRoll.Visible = false;
                lblDisplayCPUroll.Text = "";
            }
        }

        /********************************BUTTONS***********************************/
        private void picRock_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[0];
            DisableOtherButtons();
        }
        private void picRockDisabled_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[0];
            DisableOtherButtons();
        }
        private void picPaper_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[1];
            DisableOtherButtons();
        }
        private void picPaperDisabled_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[1];
            DisableOtherButtons();
        }
        private void picScissors_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[2];
            DisableOtherButtons();
        }
        private void picScissorsDisabled_Click(object sender, EventArgs e)
        {
            PlayerSelection = RockPaperScissors[2];
            DisableOtherButtons();
        }

        /********************************BUTTONS***********************************/
        private void btnClr_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            label1.Text = "Press Play!";
            btnPlay.Enabled = true;
            progressBar1.Visible = true;
            lblResult.Text = "";
            lblDisplayCPUroll.Text = "";
            lblYourRoll.Visible = false;
            lblCpuRoll.Visible = false;
            lblDisplayYourRoll.Text = "";
            lblTimeLeft.Text = "";
            picSadFace.Visible = false;
            GameTimer.Stop();
            ResetGameControls();

            //show disabled images before pressing play again
            picRockDisabled.Visible = true;
            picRockDisabled.Enabled = false;

            picPaperDisabled.Visible = true;
            picPaperDisabled.Enabled = false;

            picScissorsDisabled.Visible = true;
            picScissorsDisabled.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(243, 28);
            label1.Text = "Choose one!";
            btnPlay.Enabled = false;
            EnableGameButtons();
            /*start timer and progressbar*/
            timeLeft = Convert.ToInt16(TimeLeftDisplay.Value);
            progressBar1.Step = -(Convert.ToInt16(progressBar1.Maximum / timeLeft));  //there is def a better way than this
            GameTimer.Start();
            GameTimer_Tick(timeLeft, EventArgs.Empty);  //calling this makes the timer tick immediately; no 1-sec delay
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            if (timeLeft > -1)
            {
                lblTimeLeft.Text = timeLeft.ToString();
                progressBar1.PerformStep();

                if (timeLeft == 0)
                {
                    //lblTimeLeft.Text = "STOP!";
                    lblTimeLeft.Text = "";
                    progressBar1.Value = 0;  //incase the bar can't step down to 0 without leaving some over
                    progressBar1.Visible = false;
                    GameTimer.Stop();
                    Roll();
                    DisableGameButtons();
                }
            }
        }

        private void DisableOtherButtons()
        {
            if (PlayerSelection == RockPaperScissors[0]) //rock
            {
                picRock.Visible = true;
                picRockDisabled.Visible = false;

                picPaper.Visible = false;
                picPaperDisabled.Visible = true;

                picScissors.Visible = false;
                picScissorsDisabled.Visible = true;
            }
            else if (PlayerSelection == RockPaperScissors[1]) //paper
            {
                picPaper.Visible = true;
                picPaperDisabled.Visible = false;

                picRock.Visible = false;
                picRockDisabled.Visible = true;

                picScissors.Visible = false;
                picScissorsDisabled.Visible = true;
            }
            else if (PlayerSelection == RockPaperScissors[2]) //scissors
            {
                picScissors.Visible = true;
                picScissorsDisabled.Visible = false;

                picRock.Visible = false;
                picRockDisabled.Visible = true;

                picPaper.Visible = false;
                picPaperDisabled.Visible = true;
            }
        }

        private void DisableGameButtons()
        {
            picRock.Enabled = false;
            picRockDisabled.Enabled = false;

            picPaper.Enabled = false;
            picPaperDisabled.Enabled = false;

            picScissors.Enabled = false;
            picScissorsDisabled.Enabled = false;
        }

        private void EnableGameButtons()
        {
            picRock.Enabled = true;
            picRockDisabled.Enabled = true;
            picRockDisabled.Visible = false;

            picPaper.Enabled = true;
            picPaperDisabled.Enabled = true;
            picPaperDisabled.Visible = false;

            picScissors.Enabled = true;
            picScissorsDisabled.Enabled = true;
            picScissorsDisabled.Visible = false;
        }

        private void ResetGameControls()
        {
            PlayerSelection = "";  //clear player selection
            progressBar1.Value = progressBar1.Maximum;  //replenish progressbar
            picRock.Enabled = false;
            picRock.Visible = true;
            picRockDisabled.Visible = false;
            picRockDisabled.Enabled = true;

            picPaper.Enabled = false;
            picPaper.Visible = true;
            picPaperDisabled.Visible = false;
            picPaperDisabled.Enabled = true;

            picScissors.Enabled = false;
            picScissors.Visible = true;
            picScissorsDisabled.Visible = false;
            picScissorsDisabled.Enabled = true;
        }

        private void frmRPS_Load(object sender, EventArgs e)
        {
            /*shows disabled images initially to look cooler*/
            picRockDisabled.Visible = true;
            picRockDisabled.Enabled = false;

            picPaperDisabled.Visible = true;
            picPaperDisabled.Enabled = false;

            picScissorsDisabled.Visible = true;
            picScissorsDisabled.Enabled = false;
        }
    }
}