using System.Data;

namespace TomaszGrochowskiZadanieDomowe3.Repositories.Interfaces
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
        DataTable GetAnimals();
    }
}
