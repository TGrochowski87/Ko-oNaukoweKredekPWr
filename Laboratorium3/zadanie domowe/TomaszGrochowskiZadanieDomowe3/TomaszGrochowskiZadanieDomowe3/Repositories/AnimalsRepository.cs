using System;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IAnimalRepository 
    /// </summary>
    /// <returns></returns>
    public class AnimalsRepository : Repository, IAnimalsRepository
    {
        /// <summary>
        /// Definition of method designed to get data from Animals table
        /// </summary>
        /// <returns>Data received from database</returns>
        public DataTable GetAnimals()
        {
            //A query to data base
            string queryLogin = $"SELECT Animals.Name AS 'Animal', AnimalTypes.Name AS 'Type', PopulationStatus.Name AS 'Status', Regions.Name AS 'Region' FROM Animals " +
                $"JOIN AnimalTypes ON Animals.AnimalTypeId = AnimalTypes.Id " +
                $"JOIN PopulationStatus ON Animals.PopulationId = PopulationStatus.Id " +
                $"JOIN Regions ON Animals.RegionId = Regions.Id;";

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
