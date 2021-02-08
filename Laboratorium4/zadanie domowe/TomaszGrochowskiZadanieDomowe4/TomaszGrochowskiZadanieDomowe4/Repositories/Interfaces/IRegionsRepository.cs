using System.Collections.Generic;
using System.Data;
using TomaszGrochowskiZadanieDomowe3.ViewModels;

namespace TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces
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
        List<RegionViewModel> GetRegions();
    }
}
