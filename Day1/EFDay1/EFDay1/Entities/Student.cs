using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.Entities
{
    //POCO Class
    //Plain onld C# Object

    //there are 4 ways to map c# properties to db columns
    //1- Default mapping 
    //2- Data Annotation (Meta data, Constrains on the properties)
    //3- Fluent APi // you don't have the source code for the class
    //inside the dbcontext -> Lambda expression to Do what the data Annotation does
    // 4- Configuration class => separate the configuration of each
    //table into a separate configuration class
    //call each configuration class inside the dbContext
    internal class Student
    {
        //by default any property defined as int ID or StudentID
        //will make it pk , identity 
        [Key]
        public int StdID { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        [Column("FullName")]
        public string Name { get; set; }
        [Length(3,500)]
        public string? Address { get; set; }
        public int Age { get; set; }
        [DataType("Money")]
        public decimal Allowance { get; set; }
        //by default if a property has a getter only then it will not be mapped
        [NotMapped]
        public DateTime TimeStamp { get; set; }

        //navigational property
        public virtual Department? Department { get; set; }
    }
}
