using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jepordy
{
    /// <summary>
    /// Class: Allows the creation of game objects for use and storing.
    /// Developer: Kalin Bowden.
    /// Date: 13.03.2016.
    /// </summary>
    class Game
    {
        // Class level varaibles.
        private DateTime gameDate;
        private Player player1;
        private Player player2;
        private Player player3;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Game ()
        {
            // Set the time the game was created.
            this.gameDate = DateTime.Now;
            this.player1 = new Player();
            this.player2 = new Player();
            this.player3 = new Player();
        }

        /// <summary>
        /// Get or set the game date.
        /// </summary>
        public DateTime GameDate
        {
            get
            {
                return gameDate;
            }

            set
            {
                gameDate = value;
            }
        }

        /// <summary>
        /// Get or set the firt player object.
        /// </summary>
        internal Player Player1
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

        /// <summary>
        /// Get or set the second player object.
        /// </summary>
        internal Player Player2
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

        /// <summary>
        /// Get or set the third player object.
        /// </summary>
        internal Player Player3
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

    }// End of Class.
}// End of Solution.
