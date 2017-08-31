using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jepordy
{
    /// <summary>
    /// Class: Allows the creation of a catagory object.
    /// Developer: Kalin Bowden.
    /// Date: 12.03.2016.
    /// </summary>
    class Catagory
    {
        // Class level variable.
        private string title;
        private Question[] quiz;

        // TODO
        //private Question quiz1;
        //private Question quiz2;
        //private Question quiz3;
        //private Question quiz4;
        //private Question quiz5;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Catagory()
        {
            // Insantiate 5 questions.
            quiz = new Question[5];
            for (int index = 0; index < quiz.Length; index++)
            {
                quiz[index] = new Question();
            }
            
        }

        /// <summary>
        /// Get or set the title of the catagory.
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Get or set the quiz.
        /// </summary>
        internal Question[] Quiz
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
    }// End of Class.
}// End of Solution.
