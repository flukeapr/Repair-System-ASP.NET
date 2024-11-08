using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectSE.Models
{
    public partial class technicianAjax : DbContext
    {
        public technicianAjax()
            : base("name=technicianAjax")
        {
        }

        public virtual DbSet<Technician> Technician { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technician>()
                .HasKey(t => t.technician_Id)
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<Technician>()
                .Property(e => e.image)
                .IsUnicode(false);
        }
    }
}
