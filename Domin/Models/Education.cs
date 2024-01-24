using Domin.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShawarmaHousePortal.Models
{
    public class Education
    {
        [Key]
        public int EId { get; set; }
        [Required]  
        public int EName { get; set; }
        [ForeignKey("EName")]
        public EducationLevel?  EducationLevel { get; set; }
        public int EmployNum { get; set; }
        public string? Specialization { get; set; }
        public string? Scool { get; set; }
        public string? Average { get; set; }
        public DateTime? Edate { get; set; }

    }
}
