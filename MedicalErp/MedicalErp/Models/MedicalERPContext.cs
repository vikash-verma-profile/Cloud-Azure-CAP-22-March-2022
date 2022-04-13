using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MedicalErp.Models
{
    public partial class MedicalERPContext : DbContext
    {
        public MedicalERPContext()
        {
        }

        public MedicalERPContext(DbContextOptions<MedicalERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDoctor> TblDoctors { get; set; }
        public virtual DbSet<TblDoctorSpecialityDoctorMapping> TblDoctorSpecialityDoctorMappings { get; set; }
        public virtual DbSet<TblPatient> TblPatients { get; set; }
        public virtual DbSet<TblPatientDoctorMapping> TblPatientDoctorMappings { get; set; }
        public virtual DbSet<TblSpecialityMaster> TblSpecialityMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDoctor>(entity =>
            {
                entity.ToTable("tblDoctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDoctorSpecialityDoctorMapping>(entity =>
            {
                entity.ToTable("tblDoctorSpecialityDoctorMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatient>(entity =>
            {
                entity.ToTable("tblPatient");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientDoctorMapping>(entity =>
            {
                entity.ToTable("tblPatientDoctorMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSpecialityMaster>(entity =>
            {
                entity.ToTable("tblSpecialityMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Speciality).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
