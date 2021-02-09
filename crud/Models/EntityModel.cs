using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace crud.Models
{
    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<post> post { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<post>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<post>()
                .Property(e => e.descripcion)
                .IsUnicode(false);
        }
    }
}
