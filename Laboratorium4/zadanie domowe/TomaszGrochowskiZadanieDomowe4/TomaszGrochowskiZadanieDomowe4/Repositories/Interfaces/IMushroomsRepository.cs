using System.Collections.Generic;
using System.Data;
using TomaszGrochowskiZadanieDomowe3.ViewModels;

namespace TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// Interface that contains declarations of methods responsible for communication with data base for Mushroom table
    /// </summary>
    public interface IMushroomsRepository
    {
        /// <summary>
        /// Declaration of method designed to get data from Mushrooms table
        /// </summary>
        /// <returns></returns>
        List<MushroomViewModel> GetMushrooms();
    }
}
