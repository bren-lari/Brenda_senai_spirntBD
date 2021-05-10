using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_spMedicalGroup_tarde.Domains;

#nullable disable

namespace senai_spMedicalGroup_tarde.Context
{
    public partial class MedicalGroupContext : DbContext
    {
        public MedicalGroupContext()
        {
        }

        public MedicalGroupContext(DbContextOptions<MedicalGroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Clinica> Clinicas { get; set; }
        public virtual DbSet<Consultum> Consulta { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; Initial Catalog=Senai_SPMEDI_Tarde; user id=sa; pwd=sa132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador)
                    .HasName("PK__Administ__EBE80EA19145769B");

                entity.ToTable("Administrador");

                entity.Property(e => e.IdAdministrador).HasColumnName("idAdministrador");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.HasKey(e => e.IdClinica)
                    .HasName("PK__Clinica__C73A6055FD92C4AD");

                entity.ToTable("Clinica");

                entity.Property(e => e.IdClinica).HasColumnName("idClinica");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HorarioDeFuncionamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consultum>(entity =>
            {
                entity.HasKey(e => e.IdConsulta)
                    .HasName("PK__Consulta__CA9C61F5226862FE");

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.Property(e => e.DataConsulta)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Situação)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Consulta__idUsua__4F47C5E3");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade)
                    .HasName("PK__Especial__40969805DE7C5EEA");

                entity.ToTable("Especialidade");

                entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NomeEspecialidade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Especialidades)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Especiali__idUsu__5224328E");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedico)
                    .HasName("PK__Medico__4E03DEBA8A0850C0");

                entity.ToTable("Medico");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EspecialidadeDeterminada)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK__Paciente__F48A08F214007A68");

                entity.ToTable("Paciente");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.IdConsulta).HasColumnName("idConsulta");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("FK__Paciente__idCons__57DD0BE4");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFFEE143F18");

                entity.ToTable("tipoUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.TituloTipoUsuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tituloTipoUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TipoUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__tipoUsuar__idUsu__46B27FE2");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A67E9DAEBA");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
