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
    /// Class that contains definitions for methods of interface IAnimalRepository 
    /// </summary>
    /// <returns></returns>
    public class AnimalsRepository : Repository, IAnimalsRepository
    {
        /// <summary>
        /// Definition of method designed to get data from Animals table
        /// </summary>
        /// <returns>Data received from database</returns>
        public List<AnimalViewModel> GetAnimals()
        {
            List<Animal> animals = DBContext.Animals.ToList();
            return Mapper.Map<List<Animal>, List<AnimalViewModel>>(animals);
        }
    }
}
