using System;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IRegionsRepository 
    /// </summary>
    public class RegionsRepository : Repository, IRegionsRepository
    {
        /// <summary>
        /// Definition of method designed to get data from Regions table
        /// </summary>
        /// <returns>Data received from data base</returns>
        public DataTable GetRegions()
        {
            //A query to data base
            string queryLogin = $"SELECT Regions.Name AS 'Region', Regions.Area, AccessibilityTypes.Name AS 'Accessibility' FROM Regions " +
                $"JOIN AccessibilityTypes ON Regions.AccessibilityTypeId = AccessibilityTypes.Id;";

            Connection.Open();

            //Getting data from data base
            SqlDataAdapter adapter = new SqlDataAdapter(queryLogin, Connection);
            DataTable table = new DataTable();
            //Saving received data in DataBase variable
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
    }
}
