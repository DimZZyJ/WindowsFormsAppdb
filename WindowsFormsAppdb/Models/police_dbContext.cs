using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindowsFormsAppdb.Models
{
    public partial class police_dbContext : DbContext
    {
        public police_dbContext()
        {
        }

        public police_dbContext(DbContextOptions<police_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Citizen> Citizen { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Fine> Fine { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<TechPasport> TechPasport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Username=postgres;Password=govno123321;Database=police_db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("citizen");

                entity.Property(e => e.CitizenId)
                    .HasColumnName("citizen_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CitizenFio)
                    .IsRequired()
                    .HasColumnName("citizen_fio")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("employee_pkey");

                entity.ToTable("employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpFio)
                    .IsRequired()
                    .HasColumnName("emp_fio")
                    .HasMaxLength(150);

                entity.Property(e => e.EmpPosition).HasColumnName("emp_position");

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("leave_date")
                    .HasColumnType("date");

                entity.Property(e => e.WorkDate)
                    .HasColumnName("work_date")
                    .HasColumnType("date");

                entity.Property(e => e.WorkStatus)
                    .HasColumnName("work_status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Fine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fine");

                entity.Property(e => e.Ammount).HasColumnName("ammount");

                entity.Property(e => e.Koap12).HasColumnName("koap12");

                entity.Property(e => e.VialationDate)
                    .HasColumnName("vialation_date")
                    .HasColumnType("date");

                entity.Property(e => e.VialationPlace)
                    .HasColumnName("vialation_place")
                    .HasMaxLength(150);

                entity.Property(e => e.VialatorId).HasColumnName("vialator_id");

                entity.Property(e => e.VialatorTechPasportId).HasColumnName("vialator_tech_pasport_id");

                entity.HasOne(d => d.Vialator)
                    .WithMany()
                    .HasForeignKey(d => d.VialatorId)
                    .HasConstraintName("fine_vialator_id_fkey");

                entity.HasOne(d => d.VialatorTechPasport)
                    .WithMany()
                    .HasForeignKey(d => d.VialatorTechPasportId)
                    .HasConstraintName("fine_vialator_tech_pasport_id_fkey");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasKey(e => e.InsuranceSerialnumber)
                    .HasName("insurance_pkey");

                entity.ToTable("insurance");

                entity.Property(e => e.InsuranceSerialnumber)
                    .HasColumnName("insurance_serialnumber")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceBefore)
                    .HasColumnName("insurance_before")
                    .HasColumnType("date");

                entity.Property(e => e.InsuranceCivilianId).HasColumnName("insurance_civilian_id");

                entity.Property(e => e.InsuranceFrom)
                    .HasColumnName("insurance_from")
                    .HasColumnType("date");

                entity.Property(e => e.InsuranceTechPasportId).HasColumnName("insurance_tech_pasport_id");

                entity.HasOne(d => d.InsuranceCivilian)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.InsuranceCivilianId)
                    .HasConstraintName("insurance_insurance_civilian_id_fkey");

                entity.HasOne(d => d.InsuranceTechPasport)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.InsuranceTechPasportId)
                    .HasConstraintName("insurance_insurance_tech_pasport_id_fkey");
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.ToTable("license");

                entity.Property(e => e.LicenseId).HasColumnName("license_id");

                entity.Property(e => e.BeforeData)
                    .HasColumnName("before_data")
                    .HasColumnType("date");

                entity.Property(e => e.FromData)
                    .HasColumnName("from_data")
                    .HasColumnType("date");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.License)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("license_owner_id_fkey");
            });

            modelBuilder.Entity<TechPasport>(entity =>
            {
                entity.HasKey(e => e.TechPassId)
                    .HasName("tech_pasport_pkey");

                entity.ToTable("tech_pasport");

                entity.Property(e => e.TechPassId)
                    .HasColumnName("tech_pass_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarModel)
                    .HasColumnName("car_model")
                    .HasMaxLength(50);

                entity.Property(e => e.CivTechPassportId).HasColumnName("civ_tech_passport_id");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.Vin)
                    .HasColumnName("vin")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CivTechPassport)
                    .WithMany(p => p.TechPasport)
                    .HasForeignKey(d => d.CivTechPassportId)
                    .HasConstraintName("tech_pasport_civ_tech_passport_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
