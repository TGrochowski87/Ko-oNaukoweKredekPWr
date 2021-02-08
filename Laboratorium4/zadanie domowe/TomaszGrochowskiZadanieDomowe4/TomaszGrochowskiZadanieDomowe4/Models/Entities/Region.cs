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
    /// Model of Region entity
    /// </summary>
    public class Region
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Area { get; set; }
        [Required]
        public int AccessibilityTypeId { get; set; }
        [ForeignKey("AccessibilityTypeId")]
        public virtual AccessibilityType AccessibilityType { get; set; }
    }
}
