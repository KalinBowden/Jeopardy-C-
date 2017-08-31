using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jepordy
{
    /// <summary>
    /// Class: Allows the program to connect to the databases.
    /// Developer: Kalin Bowden.
    /// Date: 12.03.2016.
    /// </summary>
    class DataAdapter
    {
        // Class level variabels.
        private static SqlConnection dbConn = new SqlConnection("Data Source=stusql;Initial Catalog=kb0783332;Integrated Security=True");

        /// <summary>
        /// Allow the application to connect to the database.
        /// </summary>
        public static void Connect()
        {
            try
            {
                // Open the connection.
                dbConn.Open();
            }
            catch (Exception exc)
            {

            }
        }

        /// <summary>
        /// Allow the application to disconnect from the database.
        /// </summary>
        public static void Disconnect()
        {
            try
            {
                // Close Conencton.
                dbConn.Close();
            }
            catch (Exception exc)
            {

            }
            
        }

        /// <summary>
        /// Insert the game results into the database.
        /// </summary>
        /// <param name="data"></param>
        public static void Insert(string data)
        {

            try
            {
                // Sql insert string.
                string sqlInsert = "INSERT INTO GameResultsDB(Result) VALUES (@data)";
                Connect();
                SqlCommand cmd = new SqlCommand(sqlInsert, dbConn);
                cmd.Parameters.AddWithValue("@Data", data);

                // Execute the insert.
                cmd.ExecuteNonQuery();
            }
            catch(Exception exc)
            {

            }
            finally
            {
                Disconnect();
            }
        }

        /// <summary>
        /// Pull the game results from the database.
        /// </summary>
        /// <returns></returns>
        public static string[] Pull()
        {
            // Method level varaibels
            string[] myArray = new string[1000];
            int count = 0;
            string sqlPull = "SELECT Result FROM GameResultsDB";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sqlPull, dbConn);

                // Execute Query.
                SqlDataReader sqlRead = cmd.ExecuteReader();

                // Read Game results into a string array.
                while (sqlRead.Read())
                {
                    myArray[count++] = sqlRead["Result"].ToString();
                }
            }
            catch (Exception exc)
            {

            }
            finally
            {
                Disconnect();
            }
            return myArray;
        }// End of Method.

    }// End of CLass.
}// End of Solution.
