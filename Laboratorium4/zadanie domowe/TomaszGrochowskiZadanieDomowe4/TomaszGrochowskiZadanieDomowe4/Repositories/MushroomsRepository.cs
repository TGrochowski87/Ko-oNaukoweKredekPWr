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
    /// Class that contains definitions for methods of interface IMushroomRepository 
    /// </summary>
    public class MushroomsRepository : Repository, IMushroomsRepository
    {
        /// <summary>
        /// Definition of method designed to get data from Mushrooms table
        /// </summary>
        /// <returns>Data received from data base</returns>
        public List<MushroomViewModel> GetMushrooms()
        {
            List<Mushroom> mushroom = DBContext.Mushrooms.ToList();
            return Mapper.Map<List<Mushroom>, List<MushroomViewModel>>(mushroom);
        }
    }
}
