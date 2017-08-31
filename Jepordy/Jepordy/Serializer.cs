using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Jepordy
{
    /// <summary>
    /// Class: A class for serializing Game result data to a databse.
    /// </summary>
    class Serializer
    {
        /// <summary>
        /// Serilize the game result object to be stored in the database.
        /// </summary>
        /// <param name="result"></param>
        public static void SerializeNow(GameResult result)
        {
            // Method level variables.
            MemoryStream myStream = new MemoryStream();
            BinaryFormatter myFormat = new BinaryFormatter();

            // Serialize the data.
            myFormat.Serialize(myStream, result);
            string serValue = Convert.ToBase64String(myStream.ToArray());
            result.SerResults = serValue;
        }

        
        /// <summary>
        /// Deserialize the game result data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static GameResult DeSerialize(string data)
        {
            // Method level variables.
            GameResult myResult;
            object genType;
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(data));
            BinaryFormatter myFormat = new BinaryFormatter();

            // set the incoming data to a object.
            genType = myFormat.Deserialize(myStream);

            // If the object is an instance of a GameResult create a new GameResult.
            if (genType.GetType().Name == "GameResult")
            {
                myResult = (GameResult)genType;
            }
            else
            {
                myResult = new GameResult();
            }

            myStream.Close();

            return myResult;
        }
    }// End of Class.
}// End of Solution.
