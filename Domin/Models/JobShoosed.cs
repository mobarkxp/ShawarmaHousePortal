using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
    public class JobShoosed
    {
        [Key]
        public int Id { get; set; }
        public int EmpId { get; set; }
        [ForeignKey("EmpId")]
        public Employee? Employee { get; set; }
        public int JobId { get; set; }
        [ForeignKey("JobId")]
        public Job? Job { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;


    }
}
