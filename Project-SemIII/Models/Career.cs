using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class Career
    {
        [Key]
        public int CareerId { get; set; }
        public string? FullName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
        public virtual ICollection<CandidateDetails>? CandidateDetails { get; set; }
        public virtual ICollection<SelectedCandidates>? SelectedCandidates { get; set; }
    }
}
