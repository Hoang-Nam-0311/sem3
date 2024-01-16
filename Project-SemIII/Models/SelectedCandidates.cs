using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class SelectedCandidates
    {
        [Key]
        public int SelectedCandidateId { get; set; }
        public int CareerId { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime InterviewDate { get; set; }
        public virtual Career? Career { get; set; }
    }
}
