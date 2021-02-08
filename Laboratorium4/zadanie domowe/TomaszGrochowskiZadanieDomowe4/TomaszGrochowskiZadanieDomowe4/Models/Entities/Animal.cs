using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe4.Models.Entities
{
    /// <summary>
    /// Model of Animal entity
    /// </summary>
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int AnimalTypeId { get; set; }
        [ForeignKey("AnimalTypeId")]
        public virtual AnimalType AnimalType { get; set; }
        [Required]
        public int PopulationId { get; set; }
        [ForeignKey("PopulationId")]
        public virtual PopulationStatus PopulationStatus { get; set; }
        [Required]
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }
    }
}
