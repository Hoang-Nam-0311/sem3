using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class QuoteUs
    {
        [Key]
        public int QuoteId { get; set; }
        public string? FullName { get; set; }
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public string? Comments { get; set; }
    }
}
