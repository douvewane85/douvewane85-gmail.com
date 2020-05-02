namespace TP_Cargaison_LIAGE3_GLRS3.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCargaison : DbContext
    {
        public ModelCargaison()
            : base("name=ModelCargaison")
        {
        }

        public virtual DbSet<Cargaison> Cargaison { get; set; }
        public virtual DbSet<Marchandise> Marchandise { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargaison>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Cargaison>()
                .HasMany(e => e.Marchandise)
                .WithRequired(e => e.Cargaison)
                .HasForeignKey(e => e.Cargaison_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.FullName)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Login)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Pwd)
                .IsFixedLength();

            modelBuilder.Entity<Utilisateur>()
                .Property(e => e.Profil)
                .IsFixedLength();
        }
    }
}
