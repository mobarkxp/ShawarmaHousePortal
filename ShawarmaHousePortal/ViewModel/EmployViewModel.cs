using ShawarmaHousePortal.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShawarmaHousePortal.ViewModel
{
    public class EmployViewModel
    {
        public int EmpId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("الاسم الكامل ")]
        public string Name { get; set; } = string.Empty;
        [DisplayName(" رقم الجوال ")]
        public int Phone { get; set; }
        [DisplayName(" الايميل ")]
        [EmailAddress(ErrorMessage = "الايميل غير صحيح")]
        public string Email { get; set; } = string.Empty;
        [DisplayName(" تاريخ الميلاد ")]
        public DateTime DateBrith { get; set; }
        [DisplayName(" الجنس ")]
        public int GenderId { get; set; }
        [ForeignKey("GenderId")]

        public Gender? Gender { get; set; }
        [DisplayName(" الحالة الإجتماعية ")]
        public int MariedId { get; set; }
        [ForeignKey("MariedId")]
        public Maried? Maried { get; set; }
        [DisplayName(" الجنسية ")]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        [DisplayName(" هل لديك رخصة قيادة ؟ ")]

        public bool HaveDriveLicence { get; set; }
        [DisplayName(" العنوان ")]

        public List<Educationclass>? Educationclasses { get; set; }
        public List<WorkClass>? WorkClasses { get; set; }
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
        public bool IsHaveCrime { get; set; }
        [DisplayName(" هل لديك عمل خاص ؟ ")]
        public bool IsHaveSpicialWork { get; set; }
        [DisplayName(" ماهي الوظيفة التي تريد التقدم لها ؟ ")]
        public string? JobTitle { get; set; }
        [DisplayName(" ماهي الوظايف الأخرى التي يمكنك القيام بها ؟ ")]
        public string? JobCanDo { get; set; }
        [DisplayName(" ماهو الدخل الشهري الاجمالي الذي تتوقعه ؟ ")]
        public int ExpectSalary { get; set; }
        [DisplayName(" متى يمكنك البدء ب العمل لدى الشركة في حال توظفك ؟ ")]

        public string? PeroudTime { get; set; }
        [DisplayName(" ماهي اهدافك الشخصية والمهنية التي تسعى لتحقيقها في السنوات الخمس القادمة؟ ")]

        public string? Gaols { get; set; }
        [DisplayName(" لما ترغب العمل في شركة مطاعم بيت الشاورما ؟ ")]

        public string? WhyChoosCompany { get; set; }
    }

    public class Educationclass
    {
        public string? EducationDepartment { get; set; }
        public string? EducationSerctificate { get; set; }
        public string? EducationAvarage { get; set; }
        public string? EducationSchool { get; set; }



    }

    public class WorkClass
    {
       
        public string? JobTile { get; set; }
        public int ExpectSalary { get; set; }
        public string? CompanyName { get; set; }
        public string? WorkAddress { get; set; }



    }
}
