using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MovieApi.Models
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
        }

        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddMovie> AddMovies { get; set; }
        public virtual DbSet<FinalBooking> FinalBookings { get; set; }
        public virtual DbSet<MyBooking> MyBookings { get; set; }
        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AddMovie>(entity =>
            {
                entity.ToTable("AddMovie");

                entity.Property(e => e.MovieImage).HasMaxLength(100);

                entity.Property(e => e.MovieName).HasMaxLength(100);
            });

            modelBuilder.Entity<FinalBooking>(entity =>
            {
                entity.ToTable("FinalBooking");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName).HasMaxLength(100);

                entity.Property(e => e.Time).HasMaxLength(100);

                entity.Property(e => e.TotalFare).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MyBooking>(entity =>
            {
                entity.ToTable("MyBooking");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .HasColumnName("Email id");

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Meal).HasMaxLength(100);

                entity.Property(e => e.MovieName)
                    .HasMaxLength(100)
                    .HasColumnName("Movie Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfTickets).HasColumnName("no.of tickets");

                entity.Property(e => e.Time).HasMaxLength(100);
            });

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.ToTable("TblAdmin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.ConfirmPassword).HasMaxLength(100);

                entity.Property(e => e.ContactNumber).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
