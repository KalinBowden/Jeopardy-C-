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
    /// Class: This class controls the logic for the otions form.
    /// Developer: Kalin Bowden.
    /// Date: 12.05.2016.
    /// Purpose: Allows the user to set the game settings and player names.
    /// </summary>
    public partial class OptionsForm : Form
    {
        // Class level variables
        private Random roll = new Random();
        private string[] nameAI = new string[] {"Amy", "Joe", "Jim", "Dexter", "Bob", "Sam", "Sue" };
        Game myGame;

        public Random Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }

        public string[] NameAI
        {
            get
            {
                return nameAI;
            }

            set
            {
                nameAI = value;
            }
        }

        internal Game MyGame
        {
            get
            {
                return myGame;
            }

            set
            {
                myGame = value;
            }
        }

        public OptionsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Determine how many players will be playing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxPlayerNum.Text == "1")
            {
                // Set lables
                lblPlayer2.Text = "AI";
                lblPlayer3.Text = "AI";

                // Set text boxes.
                txtPlayer2.Text = nameAI[roll.Next(0, 7)];
                txtPlayer3.Text = nameAI[roll.Next(0, 7)];
            }
            else if (cmbBxPlayerNum.Text == "2")
            {
                // Set lables
                lblPlayer2.Text = "Player 2";
                lblPlayer3.Text = "AI";

                // Set text Box;
                txtPlayer3.Text = nameAI[roll.Next(0,7)];

            }
            else if (cmbBxPlayerNum.Text == "3")
            {
                // Set lables
                lblPlayer2.Text = "Player 2";
                lblPlayer3.Text = "Player 3";

            }
        }// End of Method.

        /// <summary>
        /// When this event fores set the game object player proprties and return to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbBxPlayerNum.Text != "")
            {
                // Set player 1.
                myGame.Player1.Name = (txtPlayer1.Text == ""? "Player 1" : txtPlayer1.Text);

                // Set player 2.
                myGame.Player2.Name = (txtPlayer2.Text == "" ? "Player 1" : txtPlayer2.Text);
                myGame.Player2.IsAI = (cmbBxPlayerNum.Text == "2" || cmbBxPlayerNum.Text == "3") ? false : true;

                // Set player 3.
                myGame.Player3.Name = (txtPlayer3.Text == "" ? "Player 1" : txtPlayer3.Text);
                myGame.Player3.IsAI = (cmbBxPlayerNum.Text == "3") ? false : true;

                // Exit the options form.
                this.Close();
            }
            else
            {
                MessageBox.Show("You must select the number of players before the game can start.", "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }// End of Event.

        /// <summary>
        /// Create a game object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            myGame = new Game();
        }

    }// End of Class.
}// End of Solution.
