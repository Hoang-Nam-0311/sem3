using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class QuoteUs
    {
        [Key]
        public int QuoteId { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Length must be from 3-16")]
        public string? FullName { get; set; }
       
        [Required(ErrorMessage = "State is required")]
        public string? State { get; set; }
      
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression("^\\d{10,12}$", ErrorMessage = "\r\nPhone is a number of 10-12 characters")]
        public string? Phone { get; set; }
        [DisplayName("Comment")]
        [Required(ErrorMessage = "Comment is required")]
        public string? Comments { get; set; }

    }
}
