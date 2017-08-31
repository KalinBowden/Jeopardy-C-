using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jepordy
{
    /// <summary>
    /// Class: Allows the program to create question object for use with the game board.
    /// Developer: Kalin Bowden.
    /// Date: 12.03.2016.
    /// </summary>
    class Question
    {
        // Class level variables.
        private string quiz;
        private string answer;
        private string catagory;
        private int value;

        /// <summary>
        /// Set or get the question answer.
        /// </summary>
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

        /// <summary>
        /// Set or get the question catagory.
        /// </summary>
        public string Catagory
        {
            get
            {
                return catagory;
            }

            set
            {
                catagory = value;
            }
        }

        /// <summary>
        /// Set or get the question value.
        /// </summary>
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

        /// <summary>
        /// Get or set the question.
        /// </summary>
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

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Question()
        {
            //-null-
        }

    }// End of Class.
}// End of Solution.
