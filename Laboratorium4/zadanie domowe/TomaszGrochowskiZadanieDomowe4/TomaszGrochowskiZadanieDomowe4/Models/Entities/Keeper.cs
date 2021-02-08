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
    /// Model of Keeper entity
    /// </summary>
    public class Keeper
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, MaxLength(9)]
        public string ContactNumber { get; set; }
        [Required]
        public int LodgeId { get; set; }
        [ForeignKey("LodgeId")]
        public virtual Lodge Lodge { get; set; }
    }
}
