using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.hroads.webApi_.Domains;

#nullable disable

namespace senai.hroads.webApi_.Contexts
{
    public partial class HroadsContext : DbContext
    {
        public HroadsContext()
        {
        }

        public HroadsContext(DbContextOptions<HroadsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassesHabilidade> ClassesHabilidades { get; set; }
        public virtual DbSet<Habilidade> Habilidades { get; set; }
        public virtual DbSet<Personagen> Personagens { get; set; }
        public virtual DbSet<TiposHabilidade> TiposHabilidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=Senai_Hroads_Tarde; user Id=sa; pwd=sa132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClasse)
                    .HasName("PK__Classes__60FFF80155DF9D9E");

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.NomeClasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassesHabilidade>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__ClassesHa__idCla__4D94879B");

                entity.HasOne(d => d.IdHabilidadeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdHabilidade)
                    .HasConstraintName("FK__ClassesHa__idHab__4E88ABD4");
            });

            modelBuilder.Entity<Habilidade>(entity =>
            {
                entity.HasKey(e => e.IdHabilidade)
                    .HasName("PK__Habilida__655F752835D98C69");

                entity.Property(e => e.IdHabilidade).HasColumnName("idHabilidade");

                entity.Property(e => e.IdTiposHabilidades).HasColumnName("idTiposHabilidades");

                entity.Property(e => e.NomeHabilidade)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTiposHabilidadesNavigation)
                    .WithMany(p => p.Habilidades)
                    .HasForeignKey(d => d.IdTiposHabilidades)
                    .HasConstraintName("FK__Habilidad__idTip__4BAC3F29");
            });

            modelBuilder.Entity<Personagen>(entity =>
            {
                entity.HasKey(e => e.IdPersonagem)
                    .HasName("PK__Personag__E175C72E6423BA73");

                entity.Property(e => e.IdPersonagem).HasColumnName("idPersonagem");

                entity.Property(e => e.DataAtt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataCr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdClasse).HasColumnName("idClasse");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pvmaximo).HasColumnName("PVMaximo");

                entity.HasOne(d => d.IdClasseNavigation)
                    .WithMany(p => p.Personagens)
                    .HasForeignKey(d => d.IdClasse)
                    .HasConstraintName("FK__Personage__idCla__5165187F");
            });

            modelBuilder.Entity<TiposHabilidade>(entity =>
            {
                entity.HasKey(e => e.IdTiposHabilidades)
                    .HasName("PK__TiposHab__B078A3723A0EC7EF");

                entity.Property(e => e.IdTiposHabilidades).HasColumnName("idTiposHabilidades");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
