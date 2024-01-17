using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        public string WName { get; set; } = string.Empty;
        public int EmployNum { get; set; }
        public int Salary { get; set; }
        public string? WCompany { get; set; }
        public DateTime WStartDate { get; set; }
        public DateTime WEndDate { get; set; }
        public string? WAddress { get; set; }

    }
}
