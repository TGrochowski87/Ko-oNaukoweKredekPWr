using System.Data;

namespace TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// Interface that contains declarations of methods responsible for communication with data base for Users table
    /// </summary>
    public interface IUsersRepository
    {
        /// <summary>
        /// Declaration of method designed to compare given login data with the data saved in data base
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string login, string password);
        /// <summary>
        /// Declaration of method designed to login a user as a guest
        /// </summary>
        /// <returns></returns>
        bool LoginAsGuest();
    }
}
