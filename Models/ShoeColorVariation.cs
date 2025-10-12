using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeInventoryApp.Models
{
    public class ShoeColorVariation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Shoe")]
        public int ShoeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a non-negative number.")]
        public int Stock { get; set; }

        // Navigation property
        public Shoe Shoe { get; set; }
    }
}
