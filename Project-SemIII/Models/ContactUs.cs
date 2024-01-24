using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class ContactUs
    {
        [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage = "FullName is required")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "CompanyName is required")]
        public string? CompanyName { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string? City { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string? State { get; set; }
        [Required(ErrorMessage = "PostalCode is required")]
        public string? PostalCode { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "EmailAddress is required")]
        public string? EmailAddress { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Comments is required")]
        public string? Comments { get; set; }

    }
}
