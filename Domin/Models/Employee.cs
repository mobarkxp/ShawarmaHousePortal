using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShawarmaHousePortal.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("الاسم الكامل ")]
        public string Name { get; set; }=string.Empty;
        [DisplayName(" رقم الجوال ")]
        [MaxLength(10)]
        [MinLength(10)]
        public string Phone { get; set; }=String.Empty;
        [DisplayName(" الايميل ")]
        [EmailAddress(ErrorMessage ="الايميل غير صحيح")]
        public string Email { get; set; } = string.Empty;
        [DisplayName(" تاريخ الميلاد ")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateBrith { get; set; }
        [DisplayName(" الجنس ")]
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]
        [DisplayName("  الجنس ")]
        public Gender? Gender { get; set; }
        [DisplayName(" الحالة الإجتماعية ")]
        public int MariedId { get; set; }
        [ForeignKey("MariedId")]
        public Maried? Maried { get; set; }
        [DisplayName(" الجنسية ")]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public  City? City { get; set; }
        [DisplayName(" هل لديك رخصة قيادة ؟ ")]
        public bool HaveDriveLicence { get; set; }
        [DisplayName(" العنوان ")]
        public string? Address { get; set; }
        [DisplayName(" هل لديك اصابة ؟ ")]
        public bool IsInjured { get; set; }
        [DisplayName(" هل تتلقى اي علاج في الوقت الحالي ؟ ")]
        public bool HaveMidecal { get; set; }
        [DisplayName(" هل سبق وأجريت لك عملية جراحية ")]
        public bool HaveSurjury { get; set; }
        [DisplayName(" هل انت مدخن ؟ ")]
        public bool IsSmoke { get; set; }
        [DisplayName(" هل سبق وتقدمت بطلب الحصول على عمل لدى الشركة ؟ ")]
        public bool IsHavePreviousOrder { get; set; }
        [DisplayName(" هل سبق وأن فصلت من أي عمل لأسباب تأديبية ؟ ")]
        public bool IsSeprated { get; set; }
        [DisplayName(" هل سبق ان ادنت في أي جريمة أو حكم عليك بجريمة مخلة بالشرف ولأمانة ؟ ")]
        public bool IsHaveCrime { get; set;}
        [DisplayName(" هل لديك عمل خاص ؟ ")]
        public bool IsHaveSpicialWork { get; set; }
        [DisplayName(" ماهي الوظيفة التي تريد التقدم لها ؟ ")]
        public string? JobTitle { get; set; }
        [DisplayName(" ماهي الوظايف الأخرى التي يمكنك القيام بها ؟ ")]
        public string? JobCanDo { get; set; }
        [DisplayName(" ماهو الدخل الشهري الاجمالي الذي تتوقعه ؟ ")]
        public int ExpectSalary { get; set;}
        [DisplayName(" متى يمكنك البدء ب العمل لدى الشركة في حال توظفك ؟ ")]

        public string? PeroudTime { get; set; }
        [DisplayName(" ماهي اهدافك الشخصية والمهنية التي تسعى لتحقيقها في السنوات الخمس القادمة؟ ")]

        public string? Gaols { get; set;}
        [DisplayName(" لما ترغب العمل في شركة مطاعم بيت الشاورما ؟ ")]

        public string? WhyChoosCompany { get; set;}

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateSubmit { get; set; }=DateTime.Now;

        public int RandomEmpid { get; set; }




    }
}
