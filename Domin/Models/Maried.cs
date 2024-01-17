using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Maried
    {
        [Key]
        public int MId { get; set; }
        [Required]
        public string MName { get; set; }=string.Empty;
    }
}
