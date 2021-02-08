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
    /// Model of Lodge entity
    /// </summary>
    public class Lodge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RegionId { get; set; }
        [ForeignKey("RegionId")]
        public virtual Region Region { get; set; }
    }
}
