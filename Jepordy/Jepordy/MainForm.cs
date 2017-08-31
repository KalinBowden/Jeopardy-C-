using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Jepordy
{
    /// <summary>
    /// Application: A application that allows the user/s to play a game of jepordy.
    /// Developer: Kalin Bowden.
    /// Date: 12.03.2016.
    /// Purpose: Play a fun game of Jeapordy with yourself or friends.
    /// </summary>
    public partial class MainForm : Form
    {
        // Class level varaibles.
        private int[,] gameboard = new int[6,5];
        private bool[,] isAnswered = new bool[6, 5];
        private Catagory[] myCatagory;
        public int value;
        private int timeRemaining = 1300;
        Game myGame;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new game whe nthe form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Splash splash = new Splash();
            splash.ShowDialog();
            NewGame();
        }

        /// <summary>
        /// When this event fires the appliacation will exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check that the user really wants to exit.
            MessageBox.Show("Are you sure you wish to exit?", "Exit Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (true)
            {
                MessageBox.Show("See you soon!", "GoodBye", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        /// <summary>
        /// When this event fires it will display information about this pogram.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jepordy Hands On Exam 3.\r\nDeveloper: Kalin Bowden.\r\nDate Created: 12.03.2016.\r\n\r\n\tA application that simulates one round of Jepordy for the user to paly.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// When this event fires it will display the rule of the game to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t-Rules of the Game-\r\n" + "\r\n" + DisplayRulesOfTheGame(), "Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Whe this event fires it will call the method that Display the options form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayOptions();
        }

        /// <summary>
        /// Display the options form
        /// </summary>
        public void DisplayOptions()
        {
            OptionsForm subForm = new OptionsForm();
            subForm.ShowDialog();
            myGame = subForm.MyGame;
        }

        /// <summary>
        /// Set the game up for a new game.
        /// </summary>
        public void NewGame()
        {
            // Set the Catagoeries up.
            myCatagory = new Catagory[6];
            for (int index = 0; index < 6; index++)
            {
                myCatagory[index] = new Catagory();
            }

            // Set the game board for a new game.
            timeRemaining = 1300;
            timer1.Start();
            TestReadXML();
            SetCategorys();
            SetPanes();
            CreateGame();
        }

        /// <summary>
        /// Set the initail values for all the rows at the start of a new game.
        /// </summary>
        public void SetPanes()
        {
            // Set row 0 to the intail values.
            txtPane0_0.Text = string.Format("${0}", myCatagory[0].Quiz[0].Value);
            txtPane0_1.Text = string.Format("${0}", myCatagory[1].Quiz[0].Value);
            txtPane0_2.Text = string.Format("${0}", myCatagory[2].Quiz[0].Value);
            txtPane0_3.Text = string.Format("${0}", myCatagory[3].Quiz[0].Value);
            txtPane0_4.Text = string.Format("${0}", myCatagory[4].Quiz[0].Value);
            txtPane0_5.Text = string.Format("${0}", myCatagory[5].Quiz[0].Value);

            // Set row 1 to the initial value.
            txtPane1_0.Text = string.Format("${0}", myCatagory[0].Quiz[1].Value);
            txtPane1_1.Text = string.Format("${0}", myCatagory[1].Quiz[1].Value);
            txtPane1_2.Text = string.Format("${0}", myCatagory[2].Quiz[1].Value);
            txtPane1_3.Text = string.Format("${0}", myCatagory[3].Quiz[1].Value);
            txtPane1_4.Text = string.Format("${0}", myCatagory[4].Quiz[1].Value);
            txtPane1_5.Text = string.Format("${0}", myCatagory[5].Quiz[1].Value);

            // Set row 2 to the initial value.
            txtPane2_0.Text = string.Format("${0}", myCatagory[0].Quiz[2].Value);
            txtPane2_1.Text = string.Format("${0}", myCatagory[1].Quiz[2].Value);
            txtPane2_2.Text = string.Format("${0}", myCatagory[2].Quiz[2].Value);
            txtPane2_3.Text = string.Format("${0}", myCatagory[3].Quiz[2].Value);
            txtPane2_4.Text = string.Format("${0}", myCatagory[4].Quiz[2].Value);
            txtPane2_5.Text = string.Format("${0}", myCatagory[5].Quiz[2].Value);

            // Set row 3 to the initial values.
            txtPane3_0.Text = string.Format("${0}", myCatagory[0].Quiz[3].Value);
            txtPane3_1.Text = string.Format("${0}", myCatagory[1].Quiz[3].Value);
            txtPane3_2.Text = string.Format("${0}", myCatagory[2].Quiz[3].Value);
            txtPane3_3.Text = string.Format("${0}", myCatagory[3].Quiz[3].Value);
            txtPane3_4.Text = string.Format("${0}", myCatagory[4].Quiz[3].Value);
            txtPane3_5.Text = string.Format("${0}", myCatagory[5].Quiz[3].Value);

            // Set row 4 to intial values.
            txtPane4_0.Text = string.Format("${0}", myCatagory[0].Quiz[4].Value);
            txtPane4_1.Text = string.Format("${0}", myCatagory[1].Quiz[4].Value);
            txtPane4_2.Text = string.Format("${0}", myCatagory[2].Quiz[4].Value);
            txtPane4_3.Text = string.Format("${0}", myCatagory[3].Quiz[4].Value);
            txtPane4_4.Text = string.Format("${0}", myCatagory[4].Quiz[4].Value);
            txtPane4_5.Text = string.Format("${0}", myCatagory[5].Quiz[4].Value);
        }// End of Method.

        /// <summary>
        /// Promt the player for the amount of human players.
        /// </summary>
        public void CreateGame()
        {
            // Prompt the user to select the game options.
            DisplayOptions();

            // Set the player valeus on the form.
            lblPlayer1.Text = myGame.Player1.Name;
            lblPlayer2.Text = myGame.Player2.Name;
            lblPlayer3.Text = myGame.Player3.Name;
            lblPlayer1Score.Text = "$" + myGame.Player1.Score;
            lblPlayer2Score.Text = "$" + myGame.Player2.Score;
            lblPlayer3Score.Text = "$" + myGame.Player3.Score;
        }

        /// <summary>
        /// Test to see if the game board has been completeted.
        /// </summary>
        /// <returns></returns>
        public bool CheckCompleted()
        {
            // Look through the bool array to see if all panes have been answered.
            foreach (bool pane in isAnswered)
            {
                if (pane)
                {
                    return false;
                }
            }// End of ForEach.

            return true;
        }// End of Method.

        /// <summary>
        /// When this event fires a new game will be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TestReadXML();
            NewGame();
        }

        /// <summary>
        /// Return the rules of the game.
        /// </summary>
        /// <returns></returns>
        public string DisplayRulesOfTheGame()
        {
            string gameRules = "Players will have ## to answer the question.\r\n" +
                "If a plyaer answers a question correctly their score will increase by the amount of the bet.\r\n" +
                "If a Player answers a question incorrctly their score will decrease by the amount of the bet.\r\n" +
                "\tA players score can go negitive!-\r\n" +
                "The game will end when all questions have been answered.\r\n" +
                "The player with the highest score will be decalred the winner." +
                "Good Luck!";

            return gameRules;
        }

        /// <summary>
        /// Display the Q and A form when a question is clicked.
        /// Pass the form the player and question variables.
        /// return the results of the q and a.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DisplayQandA(object sender, EventArgs e)
        {
            // Event level variables.
            TextBox temp = (TextBox)sender;
            temp.Text = "";
            int[] index = GetIndexValue(temp);

            // Instaniate a new Q and A form, send it the question selected and the questtions answer.
            QandAForm subForm = new QandAForm();
            subForm.Quiz = myCatagory[index[1]].Quiz[index[0]].Quiz;
            subForm.Answer = myCatagory[index[1]].Quiz[index[0]].Answer;
            subForm.Player1 = myGame.Player1.Name;
            subForm.Player2 = myGame.Player2.Name;
            subForm.Player3 = myGame.Player3.Name;

            // Show the QnadA form to the user.
            subForm.ShowDialog();

            // Determie who anwered the question
            if (subForm.WinningPlayer == 1 || subForm.WinningPlayer == -1)// Player 1.
            {
                myGame.Player1.Score += (subForm.WinningPlayer == 1 ? myCatagory[index[1]].Quiz[index[0]].Value : (-myCatagory[index[1]].Quiz[index[0]].Value));
                lblPlayer1Score.Text = "$" + myGame.Player1.Score;
            }
            else if (subForm.WinningPlayer == 2 || subForm.WinningPlayer == -2)// Playwer 2.
            {
                myGame.Player2.Score += (subForm.WinningPlayer == 2 ? myCatagory[index[1]].Quiz[index[0]].Value : (-myCatagory[index[1]].Quiz[index[0]].Value));
                lblPlayer2Score.Text = "$" + myGame.Player2.Score;
            }
            else if (subForm.WinningPlayer == 3 || subForm.WinningPlayer == -3)// Player 3.
            {
                myGame.Player3.Score += (subForm.WinningPlayer == 3 ? myCatagory[index[1]].Quiz[index[0]].Value : (-myCatagory[index[1]].Quiz[index[0]].Value));
                lblPlayer3Score.Text = "$" + myGame.Player3.Score;
            }
            else if (subForm.WinningPlayer == 0)
            {
                MessageBox.Show("No one won.");
            }

            // Set this question status as answered.
            isAnswered[index[1], index[0]] = true;

            // Determine if end of game.
            if (!TestIsAnswered())
            {
                EndGame(WhoWon());
            }
        }// End of Event.

        /// <summary>
        /// Return the index value of the selected textbox.
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public int[] GetIndexValue(TextBox temp)
        {
            // Method level varailbes
            int[] results = new int[2];
            int count = 0;

            // search the textbox name for the indexes.
            foreach (Char myChar in temp.Name)
            {
                if (Int32.TryParse(myChar.ToString(), out results[count]))
                {
                    count++;
                }
            }
            return results;
        }

        /// <summary>
        /// Read in an XML file and use it to set the game board and questions.
        /// </summary>
        public void TestReadXML()
        {
            // Method level varaibles.
            myCatagory[5] = new Catagory();
            int index = 0;

            // Create catagory objects from an XML file.
            foreach (XElement level1Element in XElement.Load(@"Jep.xml").Elements("category"))
            {
                // Set the catagorey titles.
                myCatagory[index].Title = level1Element.Attribute("name").Value;

                // Set the first question.
                foreach (XElement level2Element in level1Element.Elements("first"))
                {
                    myCatagory[index].Quiz[0].Quiz = level2Element.Attribute("quiz").Value;
                    myCatagory[index].Quiz[0].Answer = level2Element.Attribute("answer").Value;
                    myCatagory[index].Quiz[0].Value = Int32.Parse(level2Element.Attribute("points").Value);
                }

                // Set the second question.
                foreach (XElement level2Element in level1Element.Elements("second"))
                {
                    myCatagory[index].Quiz[1].Quiz = level2Element.Attribute("quiz").Value;
                    myCatagory[index].Quiz[1].Answer = level2Element.Attribute("answer").Value;
                    myCatagory[index].Quiz[1].Value = Int32.Parse(level2Element.Attribute("points").Value);
                }

                // Set the third question
                foreach (XElement level2Element in level1Element.Elements("third"))
                {
                    myCatagory[index].Quiz[2].Quiz = level2Element.Attribute("quiz").Value;
                    myCatagory[index].Quiz[2].Answer = level2Element.Attribute("answer").Value;
                    myCatagory[index].Quiz[2].Value = Int32.Parse(level2Element.Attribute("points").Value);
                }

                // Set the fourth question.
                foreach (XElement level2Element in level1Element.Elements("fourth"))
                {
                    myCatagory[index].Quiz[3].Quiz = level2Element.Attribute("quiz").Value;
                    myCatagory[index].Quiz[3].Answer = level2Element.Attribute("answer").Value;
                    myCatagory[index].Quiz[3].Value = Int32.Parse(level2Element.Attribute("points").Value);
                }

                // Set the fifth question.
                foreach (XElement level2Element in level1Element.Elements("fifth"))
                {
                    myCatagory[index].Quiz[4].Quiz = level2Element.Attribute("quiz").Value;
                    myCatagory[index].Quiz[4].Answer = level2Element.Attribute("answer").Value;
                    myCatagory[index].Quiz[4].Value = Int32.Parse(level2Element.Attribute("points").Value);
                }

                // Increment index.
                index++;
            } // End of Foreach.
        }// End of Method.

        /// <summary>
        /// Set the borad panes to the starting values and the catagory panes to thier catagory.
        /// </summary>
        public void SetBoard()
        {
            SetCategorys();
            SetPanes();
        }

        /// <summary>
        /// Set the Catagoery panes to thier titles.
        /// </summary>
        public void SetCategorys()
        {
            lblCat1.Text = myCatagory[0].Title;
            lblCat2.Text = myCatagory[1].Title;
            lblCat3.Text = myCatagory[2].Title;
            lblCat4.Text = myCatagory[3].Title;
            lblCat5.Text = myCatagory[4].Title;
            lblCat6.Text = myCatagory[5].Title;
        }

        /// <summary>
        /// Determine if the game is over.
        /// </summary>
        /// <returns></returns>
        public bool TestIsAnswered()
        {
            // Search the bool array for completion.
            foreach (bool pane in isAnswered)
            {
                if (!pane)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// When the game ends display the Results and save the game results to the database.
        /// </summary>
        /// <param name="player"></param>
        public void EndGame(int player)
        {
            // Method level varaibles.
            MessageBox.Show("Game ended!");
            GameResult result = new GameResult();
            

            // Set GameResult base on who won.
            if (player == 1)
            {
                result.Player = myGame.Player1.Name;
                result.Score = myGame.Player1.Score;
                result.Date = myGame.GameDate;
            }
            else if (player == 2)
            {
                result.Player = myGame.Player2.Name;
                result.Score = myGame.Player2.Score;
                result.Date = myGame.GameDate;
            }
            else if (player == 3)
            {
                result.Player = myGame.Player2.Name;
                result.Score = myGame.Player2.Score;
                result.Date = myGame.GameDate;
            }
            else
            {
                result.Player = "NO WINNER";
                result.Score = 0;
                result.Date = DateTime.Now;
            }

            // Insert game result into database.
            result.SerializeGameResult(result);

            // Display the results screen.
            ResultsScreen subForm = new ResultsScreen();
            subForm.ShowDialog();

            // Determie if the user wants to play again.
            if (subForm.NewGame)
            {
                NewGame();
            }
            else
            {
                Application.Exit();
            }
        }// End of Method.

        /// <summary>
        /// Time the game.
        /// When time is up the game will end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment time reamaining.
            timeRemaining--;
            lblTimer.Text = (timeRemaining / 60).ToString();

            // Test for the end of tha game.
            if (timeRemaining == 0)
            {
                MessageBox.Show("End Game");
            }
        }

        /// <summary>
        /// When this method fires the game will end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EndGame(WhoWon());
        }

        /// <summary>
        /// Dispaly the spalsh screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enstineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Splash subForm = new Splash();
            subForm.ShowDialog();
        }

        /// <summary>
        /// Determine the winner of the game.
        /// </summary>
        /// <returns></returns>
        public int WhoWon()
        {
            if (myGame.Player1.Score > myGame.Player2.Score && myGame.Player1.Score > myGame.Player3.Score)
            {
                return 1;
            }
            else if (myGame.Player2.Score > myGame.Player1.Score && myGame.Player2.Score > myGame.Player3.Score)
            {
                return 2;
            }
            else if (myGame.Player3.Score > myGame.Player2.Score && myGame.Player3.Score > myGame.Player1.Score)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
    }// End of Class.
}// End of Solution.
