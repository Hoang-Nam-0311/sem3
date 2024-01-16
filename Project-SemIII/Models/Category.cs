using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        
    }
}
