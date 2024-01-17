using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Education
    {
        [Key]
        public int EId { get; set; }
        [Required]  
        public string EName { get; set; }=string.Empty;
        public int EmployNum { get; set; }
        public string? Specialization { get; set; }
        public string? Scool { get; set; }
        public string? Average { get; set; }
        public DateTime? Edate { get; set; }

    }
}
