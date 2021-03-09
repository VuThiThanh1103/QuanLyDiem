using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDiem.Models
{
    public partial class QLDIEMDbContext : DbContext
    {
        public QLDIEMDbContext()
            : base("name=QLDIEMDbContext")
        {
        }
        public virtual DbSet<HOCSINH> HOCSINHS { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENS { get; set; }
        public virtual DbSet<LOP> LOPS { get; set; }
        public virtual DbSet<MONHOC> MONHOCS { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
