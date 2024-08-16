using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.Entities
{
    internal class Ward
    {
        [Key]
        public int WardID { get; set; }

        [Required]
        [MaxLength(100)]
        public string WardName { get; set; }

        [Required]
        public int WardCapacityRooms { get; set; }

        [Required]
        public int MaxPatients { get; set; }

        [Required]
        public int CurrentPatients { get; set; }

        //navigational property
        public virtual List<Nurse> Nurses { get; set; } = new List<Nurse>();
    }
}
