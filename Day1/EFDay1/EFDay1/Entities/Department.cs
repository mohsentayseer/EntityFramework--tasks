using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //navigational property
        public virtual List<Student> Students { get; set; }=new List<Student>();
    }
}
