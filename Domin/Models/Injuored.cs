using System.ComponentModel.DataAnnotations;

namespace ShawarmaHousePortal.Models
{
    public class Injuored
    {

        [Key]
        public int Id { get; set; }
        public string InjouredName { get; set; }=string.Empty;
        public int EmpId { get; set; }
    }
}
