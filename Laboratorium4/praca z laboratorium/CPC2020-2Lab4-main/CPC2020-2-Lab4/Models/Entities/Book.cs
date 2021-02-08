using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPC2020_2_Lab4.Models.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string Title { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int YearOfPublish { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        [Required]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
    }
}
