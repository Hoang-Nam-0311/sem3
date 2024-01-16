using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? TechnicalSpecifications {  get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
