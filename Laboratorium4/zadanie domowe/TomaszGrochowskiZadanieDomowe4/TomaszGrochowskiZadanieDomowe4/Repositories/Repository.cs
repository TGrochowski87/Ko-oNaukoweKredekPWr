using AutoMapper;
using System.Data.SqlClient;
using TomaszGrochowskiZadanieDomowe3.Infrastructure;
using TomaszGrochowskiZadanieDomowe4.Models;

namespace TomaszGrochowskiZadanieDomowe4.Repositories
{
    /// <summary>
    /// A abstract class that contains variables and methods inherited by every Repository class
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Variable containing connection to data base
        /// </summary>
        protected readonly DataBaseContext DBContext = new DataBaseContext();

        /// <summary>
        /// Variable containing mapper configuration
        /// </summary>
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));

        /// <summary>
        /// Variable containing mapper
        /// </summary>
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
