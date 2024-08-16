using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tasks.Entities;

namespace tasks.Context
{
    internal class HospitalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyHospital;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
    }
}