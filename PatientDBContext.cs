using Microsoft.EntityFrameworkCore;
using PatientRegistration.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Data.DBContext
{
    public class PatientDBContext : DbContext
    {
        public PatientDBContext(DbContextOptions<PatientDBContext> options)
          : base(options)
        {
        }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientCategory> PatientCategory { get; set; }

        public virtual DbSet<Relation> Relation { get; set; }
        public virtual DbSet<Company> Company { get; set; }

        public virtual DbSet<Country> Country { get; set; }

        public virtual DbSet<City> City { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseChangeTrackingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Patient>(entity =>
            {

                entity.HasKey(x => x.Id);

                entity.HasOne(e => e.PatientCategory);
              

                entity.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

            });


            modelBuilder.Entity<PatientCategory>(entity =>
            {

                entity.HasKey(x => x.Id);

                entity.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<Relation>(entity =>
            {

                entity.HasKey(x => x.Id);

                entity.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<Company>(entity =>
            {

                entity.HasKey(x => x.Id);

                entity.HasOne(e => e.PatientCategory);

                entity.Property(e => e.Name)
                   .HasMaxLength(50)
                   .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GLECODE)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.ShowName)
                  .HasMaxLength(50)
                  .IsUnicode(false);

                entity.Property(e => e.SidatCustomerID)
                 .HasMaxLength(30)
                 .IsUnicode(false);

                entity.Property(e => e.Address)
               .HasMaxLength(100)
               .IsUnicode(false);

                entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .IsUnicode(false);

                entity.Property(e => e.WEF)
                .HasMaxLength(30)
                .IsUnicode(false);

            });

           
            modelBuilder.Entity<Country>(entity =>
            {

                entity.HasKey(x => x.Id);
                entity.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<City>(entity =>
            {

                entity.HasKey(x => x.Id);
                entity.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryID)
                  .HasMaxLength(30)
                  .IsUnicode(false);

            });


        }
    }
}

