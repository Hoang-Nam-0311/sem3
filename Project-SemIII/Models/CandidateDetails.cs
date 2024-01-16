using System.ComponentModel.DataAnnotations;

namespace Project_Sem3.Models
{
    public class CandidateDetails
    {
        [Key]
        public int CandidateId { get; set; }
        public int CareerId { get; set; }
        public byte[]? Resume { get; set; }
        public string? PersonalDetails { get; set; }
        public string? EducationDetails { get; set; }
        public virtual Career? Career { get; set; }
    }
}
