using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jepordy
{
    /// <summary>
    /// Class: Allows the creation of a player object.
    /// Developer: Kalin Bowden.
    /// Date: 12.03.2016.
    /// </summary>
    class Player
    {
        // Class level variables.
        private string name;
        private int score;
        private int correctGuesses;
        private bool isAI;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Player()
        {
            score = 0;
        }

        /// <summary>
        /// Get or set the player name.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Get orr set the player score.
        /// </summary>
        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        /// <summary>
        /// Get or set the number of correct guesses.
        /// </summary>
        public int CorrectGuesses
        {
            get
            {
                return correctGuesses;
            }

            set
            {
                correctGuesses = value;
            }
        }

        /// <summary>
        /// Get or set if the player object is an AI.
        /// </summary>
        public bool IsAI
        {
            get
            {
                return isAI;
            }

            set
            {
                isAI = value;
            }
        }
    }// End of Class.
}// End of Solution.
