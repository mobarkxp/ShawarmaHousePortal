using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string GenderName { get; set; }=string.Empty;
    }
}
