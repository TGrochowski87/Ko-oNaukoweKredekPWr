using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TomaszGrochowskiZadanieDomowe3.ViewModels;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;
using TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces;

namespace TomaszGrochowskiZadanieDomowe4.Repositories
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
        public List<RegionViewModel> GetRegions()
        {
            List<Region> region = DBContext.Regions.ToList();
            return Mapper.Map<List<Region>, List<RegionViewModel>>(region);
        }
    }
}
