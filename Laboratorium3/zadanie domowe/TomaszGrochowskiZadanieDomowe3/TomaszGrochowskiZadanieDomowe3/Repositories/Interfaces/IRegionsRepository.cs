using System.Data;

namespace TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interface that contains declarations of methods responsible for communication with data base for Regions table
    /// </summary>
    public interface IRegionsRepository
    {
        /// <summary>
        /// Declaration of method designed to get data from Regions table
        /// </summary>
        /// <returns></returns>
        DataTable GetRegions();
    }
}
