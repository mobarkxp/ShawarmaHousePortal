using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domin.Models
{
    public class EducationLevel
    {
        [Key]
        public int EducationLevelId { get; set; }

        [Required]
        [DisplayName("اسم الشهادة")]
        public string EducationLevelName { get; set; }=String.Empty;

    }
}
