using System.ComponentModel.DataAnnotations;

namespace SuperMarket.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }= string.Empty;

    }
}
