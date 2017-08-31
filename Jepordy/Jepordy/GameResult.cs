using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jepordy
{
    /// <summary>
    /// Class: A class for storing the game results in a databse.
    /// </summary>
    [Serializable]
    class GameResult
    {
        // Class level varaibels.
        private string player;
        private int score;
        private DateTime date;
        private string serResults;

        /// <summary>
        /// Get or set the player.
        /// </summary>
        public string Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        /// <summary>
        /// Get or set the score.
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
        /// Get or set the date of the game.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        /// <summary>
        /// Get or set the serialized results.
        /// </summary>
        public string SerResults
        {
            get
            {
                return serResults;
            }

            set
            {
                serResults = value;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GameResult()
        {

        }

        /// <summary>
        /// Serialize the results of hte game.
        /// </summary>
        /// <param name="result"></param>
        public void SerializeGameResult(GameResult result)
        {
            Serializer.SerializeNow(result);
            DataAdapter.Insert(this.serResults);
        }

        /// <summary>
        /// Return a string array that hold all the games in tha database.
        /// </summary>
        /// <returns></returns>
        public static string[] CreateResultList()
        {
            return DataAdapter.Pull();
        }

        /// <summary>
        /// Return a GameResult object from serialized data.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static GameResult AddGameResults(string result)
        {
            return Serializer.DeSerialize(result);
        }

        /// <summary>
        /// Display a formated string that represents the gameResult obejct.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Player: " + player + "\tScore: " + score + "\tDate: " + date.ToShortDateString();
        }

    }// End of Class.
}// End of Solution.
