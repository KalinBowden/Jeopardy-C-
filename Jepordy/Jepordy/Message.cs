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
    /// A form that lets the user determine if they guessed corectly.
    /// </summary>
    public partial class Message : Form
    {
        // Class level varaibles.
        private string answer;
        private string guess;
        private bool isCorrect;

        public Message()
        {
            InitializeComponent();
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

        public string Guess
        {
            get
            {
                return guess;
            }

            set
            {
                guess = value;
            }
        }

        public bool IsCorrect
        {
            get
            {
                return isCorrect;
            }

            set
            {
                isCorrect = value;
            }
        }

        /// <summary>
        /// Load the answer and the player guess.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Message_Load(object sender, EventArgs e)
        {
            txtAnswer.Text = answer;
            txtGuess.Text = guess;
        }

        /// <summary>
        /// Return true if the user guessed corectly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            isCorrect = true;
            this.Close();
        }

        /// <summary>
        /// Return false if the user guessed incorrectly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            isCorrect = false;
            this.Close();
        }
    }// End of Class.
}// End of Solution.
