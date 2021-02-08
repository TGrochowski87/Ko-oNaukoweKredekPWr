using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomaszGrochowskiZadanieDomowe4.Models.Entities;

namespace TomaszGrochowskiZadanieDomowe4.Models
{
    /// <summary>
    /// Data base context class
    /// </summary>
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Utilizing base DBContext constructor with a string containing data base connection string
        /// </summary>
        public DataBaseContext() : base("ConnectionString")
        {

        }

        //Tables in data base
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AccessibilityType> AccessibilityTypes { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Keeper> Keepers { get; set; }
        public DbSet<Lodge> Lodges { get; set; }
        public DbSet<Mushroom> Mushrooms { get; set; }
        public DbSet<PopulationStatus> PopulationStatus { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
