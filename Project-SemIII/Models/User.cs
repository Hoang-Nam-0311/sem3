using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Project_Sem3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
    }
}
