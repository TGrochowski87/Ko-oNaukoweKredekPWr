using System.Collections.Generic;
using System.Data;
using TomaszGrochowskiZadanieDomowe3.ViewModels;

namespace TomaszGrochowskiZadanieDomowe4.Repositories.Interfaces
{
    /// <summary>
    /// Interface that contains declarations of methods responsible for communication with data base for Animals table
    /// </summary>
    public interface IAnimalsRepository
    {
        /// <summary>
        /// Declaration of method designed to get data from Animals table
        /// </summary>
        /// <returns></returns>
        List<AnimalViewModel> GetAnimals();
    }
}
