using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        [DisplayName("المسمى الوظيفي")]
        public string JobName { get; set; }=String.Empty;
        [DisplayName("الفرع  ")]
        public string? JonPranch { get; set; }
        [DisplayName(" تاريخ الانشاء ")]
        public DateTime JobCreateDate { get; set; } = DateTime.Now;
        [DisplayName(" الحالة ")]
        public bool JobSatuse { get; set; }=true;
        [DisplayName(" التفاصيل ")]
        public string? JobDescription { get; set; }

    }
}
