using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces;
using System.Collections.Generic;
using TomaszGrochowskiZadanieDomowe3.ViewModels;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;
using System.Linq;

namespace TomaszGrochowskiZadanieDomowe4.Repositories
{
    /// <summary>
    /// Class that contains definitions for methods of interface IKeepersRepository
    /// </summary>
    public class KeepersRepository : Repository, IKeepersRepository
    {
        /// <summary>
        /// Definition of method designed to add new record to Keepers table
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        public bool AddKeeper(string firstName, string lastName, string contactNumber, int lodgeId)
        {
            Lodge lodge = DBContext.Lodges.SingleOrDefault(l => l.Id == lodgeId);

            if (lodge == null)
                return false;

            Keeper keeperNew = new Keeper()
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber,
                LodgeId = lodge.Id
            };

            DBContext.Keepers.Add(keeperNew);
            return DBContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Definition of method designed to delete record from Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        public bool DeleteKeeper(int keeperId)
        {
            Keeper keeper = DBContext.Keepers.SingleOrDefault(k => k.Id == keeperId);
            DBContext.Keepers.Remove(keeper);
            return DBContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Definition of method designed to edit a record in Keepers table
        /// </summary>
        /// <param name="keeperId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="contactNumber"></param>
        /// <param name="lodgeId"></param>
        public bool EditKeeper(int keeperId, string firstName, string lastName, string contactNumber, int lodgeId)
        {
            Keeper keeper = DBContext.Keepers.SingleOrDefault(k => k.Id == keeperId);

            keeper.FirstName = firstName;
            keeper.LastName = lastName;
            keeper.ContactNumber = contactNumber;
            keeper.LodgeId = lodgeId;

            return DBContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Definition of method designed to get specified record from Keepers table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of attributes of received record</returns>
        public Keeper GetKeeper(int id)
        {
            return DBContext.Keepers.SingleOrDefault(k => k.Id == id);
        }

        /// <summary>
        /// Definition of method designed to get data from Keepers table
        /// </summary>
        /// <returns>Data received from database</returns>
        public List<KeeperViewModel> GetKeepers()
        {
            List<Keeper> keeper = DBContext.Keepers.ToList();
            return Mapper.Map<List<Keeper>, List<KeeperViewModel>>(keeper);
        }
    }
}
