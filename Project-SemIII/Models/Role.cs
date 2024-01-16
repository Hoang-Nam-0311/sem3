using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<User>? Users { get; set; }
        public string? RoleName { get; set; }
    }
}
