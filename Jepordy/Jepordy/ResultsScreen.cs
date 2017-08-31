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
    /// Class: A class for displaying the game results.
    /// </summary>
    public partial class ResultsScreen : Form
    {
        // Class level varaibles
        private bool newGame;

        /// <summary>
        /// Get ot set new game.
        /// </summary>
        public bool NewGame
        {
            get
            {
                return newGame;
            }

            set
            {
                newGame = value;
            }
        }

        public ResultsScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame = true;
            this.Close();
        }

        /// <summary>
        /// Exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            NewGame = false;
            this.Close();
        }

        /// <summary>
        /// When this form loads display the games sotred in the databse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            // Method level varaiables.
            string[] myArray = GameResult.CreateResultList();
            string temp = "";

            // Write each game to the textbox.
            for (int index = 0; index < myArray.Length; index++)
            {
                if (myArray[index] != "" && myArray[index] != null)
                {
                    GameResult myResult = GameResult.AddGameResults(myArray[index]);
                    temp += myResult.ToString() + "\r\n";
                }
            }
            txtScores.Text = temp;
        }
    }// End of Class.
}// End of Solution.
