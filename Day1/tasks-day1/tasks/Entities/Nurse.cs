using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.Entities
{
    internal class Nurse
    {
        [Key]
        public int NurID { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        [Column("FirstName")]
        public string NurName { get; set; }
        [Length(3, 500)]
        public string? Address { get; set; }
        public int Age { get; set; }
        [DataType("Money")]
        public decimal Salary { get; set; }
        public int ShiftHours { get; set; }
        [NotMapped]
        public int? ExpYears { get; set; }
        //navigational property
        public virtual Ward? Ward { get; set; }
    }
}
