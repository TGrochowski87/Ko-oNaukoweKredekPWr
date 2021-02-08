using System.Collections.Generic;
using System.Data;
using TomaszGrochowskiZadanieDomowe3.ViewModels;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;

namespace TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces
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
        List<KeeperViewModel> GetKeepers();

        /// <summary>
        /// Declaration of method designed to get specified record from Keepers table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Keeper GetKeeper(int id);

        /// <summary>
        /// Declaration of method designed to add new record to Keepers table
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        bool AddKeeper(string firstName, string lastName, string contactNumber, int lodgeId);

        /// <summary>
        /// Declaration of method designed to delete record from Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        bool DeleteKeeper(int keeperId);

        /// <summary>
        /// Declaration of method designed to edit a record in Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        bool EditKeeper(int keeperId, string firstName, string lastName, string contactNumber, int lodgeId);
    }
}
