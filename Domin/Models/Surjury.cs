using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Surjury
    {

        [Key]
        public int Id { get; set; }
        public string SurjuryName { get; set; } = string.Empty;
        public int EmpId { get; set; }
    }
}
