using System;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe3.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IUsersRepository 
    /// </summary>
    public class UsersRepository : Repository, IUsersRepository
    {
        /// <summary>
        /// Definition of method designed to compare given login data with the data saved in data base
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>True, if matching login data has been found</returns>
        public bool Login(string login, string password)
        {
            //Query to data base
            string queryLogin = $"SELECT Logins.* FROM Logins WHERE Login='{login}' AND Password='{password}';";

            Connection.Open();

            //Getting data from data base
            SqlDataAdapter adapter = new SqlDataAdapter(queryLogin, Connection);
            DataTable table = new DataTable();
            //Saving received data in DataTable variable
            adapter.Fill(table);

            Connection.Close();

            return table.Rows.Count > 0 ? true : false;
        }

        /// <summary>
        /// Declaration of method designed to login a user as a guest
        /// </summary>
        /// <returns>False, that indicates, that the admin privileges are not granted to user</returns>
        public bool LoginAsGuest()
        {
            return false;
        }
    }
}
