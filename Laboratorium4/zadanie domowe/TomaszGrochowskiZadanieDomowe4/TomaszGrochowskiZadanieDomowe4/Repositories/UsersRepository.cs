using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;
using TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe4.Repositories
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
            User user = DBContext.Users.SingleOrDefault(u => u.Login == login && u.Password == password);
            return user != null;
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
