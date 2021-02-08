using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces;
using System.Collections.Generic;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IKeepersRepository
    /// </summary>
    public class KeepersRepository : Repository, IKeepersRepository
    {
        /// <summary>
        /// Definition of method designed to add new record to Keepers table
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        public void AddKeeper(string firstName, string lastName, string contactNumber, int lodgeId)
        {
            //Query to data base for the highest Lodge Id
            string maxLodgeIdQuery = "SELECT MAX(Id) FROM Lodges;";

            //Query to data base
            string insertKeeperQuery = $"INSERT INTO Keepers (FirstName, LastName, ContactNumber, LodgeId) " +
                $"VALUES ('{firstName}', '{lastName}', '{contactNumber}', {lodgeId});";

            Connection.Open();

            //Getting highest Lodge Id from data base
            SqlCommand getMaxLodgeId = new SqlCommand(maxLodgeIdQuery, Connection);
            int maxLodgeId = (int)getMaxLodgeId.ExecuteScalar();

            //Checking if given index is valid
            if(lodgeId < 1 || lodgeId > maxLodgeId)
            {
                if (MessageBox.Show("Lodge ID not found!") == DialogResult.OK)
                {
                    Connection.Close();
                    return;
                }
            }

            //Executing insert query
            SqlCommand commandInsertKeeper = new SqlCommand(insertKeeperQuery, Connection);
            commandInsertKeeper.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary>
        /// Definition of method designed to delete record from Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        public void DeleteKeeper(int keeperId)
        {
            //Query to data base
            string deleteKeeperQuery = $"DELETE FROM Keepers WHERE Id={keeperId};";

            Connection.Open();

            //Executing delete query
            SqlCommand commandDeleteKeeper = new SqlCommand(deleteKeeperQuery, Connection);
            commandDeleteKeeper.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary>
        /// Definition of method designed to edit a record in Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        public void EditKeeper(int keeperId, string firstName, string lastName, string contactNumber, int lodgeId)
        {
            //Query to data base for the highest Lodge Id
            string maxLodgeIdQuery = "SELECT MAX(Id) FROM Lodges;";

            //Query to data base
            string queryEdit = $"UPDATE Keepers SET " +
                $"FirstName='{firstName}', LastName='{lastName}', ContactNumber='{contactNumber}', LodgeId={lodgeId}" +
                $"WHERE Id={keeperId};";

            Connection.Open();

            //Getting highest Lodge Id from data base
            SqlCommand getMaxLodgeId = new SqlCommand(maxLodgeIdQuery, Connection);
            int maxLodgeId = (int)getMaxLodgeId.ExecuteScalar();

            //Checking if given index is valid
            if (lodgeId < 1 || lodgeId > maxLodgeId)
            {
                if (MessageBox.Show("Lodge ID not found!") == DialogResult.OK)
                {
                    Connection.Close();
                    return;
                }
            }

            //Executing update query
            SqlCommand commandEditKeeper = new SqlCommand(queryEdit, Connection);
            commandEditKeeper.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary>
        /// Definition of method designed to get specified record from Keepers table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of attributes of received record</returns>
        public List<string> GetKeeper(int id)
        {
            //List of attributes of received record
            List<string> keeperData = new List<string>();

            //Query to data base
            string querySelect = $"SELECT Keepers.FirstName, Keepers.LastName, Keepers.ContactNumber, Keepers.LodgeId FROM Keepers WHERE Id={id};";

            Connection.Open();

            //Executing select query
            SqlCommand commandGetKeeper = new SqlCommand(querySelect, Connection);
            SqlDataReader reader = commandGetKeeper.ExecuteReader();

            //Reading received data and saving it in List
            if(reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    keeperData.Add(reader[i].ToString());
                }
            }
            else
            {
                Connection.Close();
                    return null;
            }

            Connection.Close();

            return keeperData;
        }

        /// <summary>
        /// Definition of method designed to get data from Keepers table
        /// </summary>
        /// <returns>Data received from database</returns>
        public DataTable GetKeepers()
        {
            //Query to data base
            string queryLogin = $"SELECT Keepers.Id, Keepers.FirstName, Keepers.LastName, Keepers.ContactNumber AS 'Contact', Keepers.LodgeId AS 'Lodge', Regions.Name AS 'Region' FROM Keepers " +
                $"JOIN Lodges ON Keepers.LodgeId = Lodges.Id " +
                $"JOIN Regions ON Lodges.RegionId = Regions.Id;";

            Connection.Open();

            //Executing select query
            SqlDataAdapter adapter = new SqlDataAdapter(queryLogin, Connection);
            DataTable table = new DataTable();
            //Saving received data in DataTable variable
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
    }
}
