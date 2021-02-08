using System.Collections.Generic;
using System.Data;

namespace TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interface that contains declarations of methods responsible for communication with data base for Keepers table
    /// </summary>
    public interface IKeepersRepository
    {
        /// <summary>
        /// Declaration of method designed to get data from Keepers table
        /// </summary>
        /// <returns></returns>
        DataTable GetKeepers();

        /// <summary>
        /// Declaration of method designed to get specified record from Keepers table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<string> GetKeeper(int id);

        /// <summary>
        /// Declaration of method designed to add new record to Keepers table
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        void AddKeeper(string firstName, string lastName, string contactNumber, int lodgeId);

        /// <summary>
        /// Declaration of method designed to delete record from Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        void DeleteKeeper(int keeperId);

        /// <summary>
        /// Declaration of method designed to edit a record in Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        void EditKeeper(int keeperId, string firstName, string lastName, string contactNumber, int lodgeId);
    }
}
