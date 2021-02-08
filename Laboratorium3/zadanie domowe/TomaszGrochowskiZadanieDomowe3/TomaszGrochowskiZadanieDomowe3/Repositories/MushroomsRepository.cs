using System;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IMushroomRepository 
    /// </summary>
    public class MushroomsRepository : Repository, IMushroomsRepository
    {
        /// <summary>
        /// Definition of method designed to get data from Mushrooms table
        /// </summary>
        /// <returns>Data received from data base</returns>
        public DataTable GetMushrooms()
        {
            //A query to data base
            string queryLogin = $"SELECT Mushrooms.Name AS 'Mushroom', Mushrooms.Edibility, Regions.Name AS 'Region' FROM " +
                $"Mushrooms JOIN Regions ON Mushrooms.RegionId = Regions.Id;";

            Connection.Open();

            //Getting data from data base
            SqlDataAdapter adapter = new SqlDataAdapter(queryLogin, Connection);
            DataTable table = new DataTable();
            //Saving received data in DataTable variable
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
    }
}
