using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jepordy
{
    /// <summary>
    /// Class: A form for displaying the selected quesion to the user.
    /// Develoepr: Kalin Bowden.
    /// </summary>
    public partial class QandAForm : Form
    {
        // Class level varaibles.
        private Catagory firstCat;
        private Catagory secondCat;
        private Catagory thirdCat;
        private Catagory fourthCat;
        private Catagory fifthCat;
        private Catagory sixthCat;
        private int value;
        private string quiz;
        private string answer;
        private string player1;
        private string player2;
        private string player3;
        private int winningPlayer;
        private int guessingPlayer;
        private int timeReamining = 30;

        internal Catagory FirstCat
        {
            get
            {
                return firstCat;
            }

            set
            {
                firstCat = value;
            }
        }

        internal Catagory SecondCat
        {
            get
            {
                return secondCat;
            }

            set
            {
                secondCat = value;
            }
        }

        internal Catagory ThirdCat
        {
            get
            {
                return thirdCat;
            }

            set
            {
                thirdCat = value;
            }
        }

        internal Catagory FourthCat
        {
            get
            {
                return fourthCat;
            }

            set
            {
                fourthCat = value;
            }
        }

        internal Catagory FifthCat
        {
            get
            {
                return fifthCat;
            }

            set
            {
                fifthCat = value;
            }
        }

        internal Catagory SixthCat
        {
            get
            {
                return sixthCat;
            }

            set
            {
                sixthCat = value;
            }
        }

        public string Quiz
        {
            get
            {
                return quiz;
            }

            set
            {
                quiz = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int WinningPlayer
        {
            get
            {
                return winningPlayer;
            }

            set
            {
                winningPlayer = value;
            }
        }

        public string Player1
        {
            get
            {
                return player1;
            }

            set
            {
                player1 = value;
            }
        }

        public string Player2
        {
            get
            {
                return player2;
            }

            set
            {
                player2 = value;
            }
        }

        public string Player3
        {
            get
            {
                return player3;
            }

            set
            {
                player3 = value;
            }
        }

        public QandAForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the form control text properties.
        /// </summary>
        public void SetQandA()
        { 
            txtQuestionDisplay.Text = quiz;
            btnAnswerP1.Text = player1;
            btnAnswerP2.Text = player2;
            btnAnswerP3.Text = player3;
            
        }

        /// <summary>
        /// When the foram loads set it to display the the corect inforamtion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QandAForm_Load(object sender, EventArgs e)
        {
            SetQandA();
            txtAnswer.Visible = false;
            btnSubmit.Visible = false;
            timer1.Start();
            timer1.Interval = 1000;
        }

        /// <summary>
        /// Test the answer to determine if it is correct.
        /// </summary>
        /// <returns></returns>
        public bool TestAnswer()
        {
            Message msg = new Message();
            msg.Answer = answer;
            msg.Guess = txtAnswer.Text;

            msg.ShowDialog();

            //if (txtAnswer.Text == answer)
            //{
            //    return true;
            //}
            return msg.IsCorrect; ;
        }

        /// <summary>
        /// Allow the user to try and make a guess.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AttemptGuess(object sender, EventArgs e)
        {
            // Method level variables.
            Button myButton = (Button)sender;
            txtAnswer.Text = "";
            txtAnswer.Visible = true;
            btnSubmit.Visible = true;

            // Determine who is answering.
            if (myButton.Name == "btnAnswerP1")
            {
                lblGuessingPlayer.Text = player1;
                guessingPlayer = 1;
            }
            else if (myButton.Name == "btnAnswerP2")
            {
                lblGuessingPlayer.Text = player2;
                guessingPlayer = 2;
            }
            else if (myButton.Name == "btnAnswerP3")
            {
                lblGuessingPlayer.Text = player3;
                guessingPlayer = 3;
            }
        }

        /// <summary>
        /// When this event fires determine if the guessing player is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TestPlayerAnswer();
        }

        /// <summary>
        /// Time the question.
        /// After 30 seconds the time is up and the form will close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Send the time remaining to the label.
            lblTimer.Text = timeReamining--.ToString();
            
            // If the time is up close the form.
            if (timeReamining == 0)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Determime who answered the question and if they guessed correctly.
        /// </summary>
        public void TestPlayerAnswer()
        {
            if (guessingPlayer == 1)
            {
                winningPlayer = ((TestAnswer()) ? 1 : -1);
                MessageBox.Show((winningPlayer == 1 ? player1 + " guessed correctly." : player1 + " guessed incorectly."));
                this.Close();
            }
            else if (guessingPlayer == 2)
            {
                winningPlayer = ((TestAnswer()) ? 2 : -2);
                MessageBox.Show((winningPlayer == 2 ? player2 + "guessed correctly." : player2 + " guessed incorectly."));
                this.Close();
            }
            else if (guessingPlayer == 3)
            {
                winningPlayer = ((TestAnswer()) ? 3 : -3);
                MessageBox.Show((winningPlayer == 3 ? player3 + " guessed correctly." : player3 + " guessed incorectly."));
                this.Close();
            }
            else
            {
                winningPlayer = 0;
            }
        }

        public void TestPlayerAnswer2()
        {

        }
    }// End of Class.
}// End of Solution.
