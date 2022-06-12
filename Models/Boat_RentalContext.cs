using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Boat_RentalContext : DbContext
    {
        public Boat_RentalContext()
        {
        }

        public Boat_RentalContext(DbContextOptions<Boat_RentalContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Boat> Boats { get; set; }
        public virtual DbSet<Boattype> Boattypes { get; set; }
        public virtual DbSet<Command> Commands { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=Boat_Rental;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Boat>(entity =>
            {
                entity.HasKey(e => e.IdBoat)
                    .HasName("PRIMARY");

                entity.ToTable("boat");

                entity.HasIndex(e => e.IdBoatType, "boat_boatType_FK");

                entity.Property(e => e.IdBoat)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Boat");

                entity.Property(e => e.DescriptionBoat)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Description_Boat");

                entity.Property(e => e.PriceBoat)
                .HasColumnType("double")
                .HasColumnName("Price_Boat");

                entity.Property(e => e.IdBoatType)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_BoatType");

                entity.Property(e => e.IsRentedBoat).HasColumnName("IsRented_Boat");

                entity.Property(e => e.LicenseBoat)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("License_Boat");

                entity.Property(e => e.NameBoat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Boat");

                entity.Property(e => e.SlotBoat)
                    .HasColumnType("int(11)")
                    .HasColumnName("Slot_Boat");

                entity.HasOne(d => d.IdBoatTypeNavigation)
                    .WithMany(p => p.Boats)
                    .HasForeignKey(d => d.IdBoatType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("boat_boatType_FK");
            });

            modelBuilder.Entity<Boattype>(entity =>
            {
                entity.HasKey(e => e.IdBoatType)
                    .HasName("PRIMARY");

                entity.ToTable("boattype");

                entity.Property(e => e.IdBoatType)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_BoatType");

                entity.Property(e => e.TypeBoatType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Type_BoatType");
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasKey(e => e.IdCommand)
                    .HasName("PRIMARY");

                entity.ToTable("command");

                entity.HasIndex(e => e.IdBoat, "command_boat0_FK");

                entity.HasIndex(e => e.IdCustomer, "command_customer_FK");

                entity.Property(e => e.IdCommand)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Command");

                entity.Property(e => e.DateEndCommand)
                    .HasColumnType("datetime")
                    .HasColumnName("DateEnd_Command");

                entity.Property(e => e.DateStartCommand)
                    .HasColumnType("datetime")
                    .HasColumnName("DateStart_Command");

                entity.Property(e => e.HasPaiedDepositCommand).HasColumnName("HasPaiedDeposit_Command");

                entity.Property(e => e.IdBoat)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Boat");

                entity.Property(e => e.IdCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Customer");


                entity.HasOne(d => d.IdBoatNavigation)
                    .WithMany(p => p.Commands)
                    .HasForeignKey(d => d.IdBoat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("command_boat0_FK");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Commands)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("command_customer_FK");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer)
                    .HasName("PRIMARY");

                entity.ToTable("customer");

                entity.Property(e => e.IdCustomer)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Customer");

                entity.Property(e => e.AgeCustomer)
                    .HasColumnType("datetime")
                    .HasColumnName("Age_Customer");

                entity.Property(e => e.BoatLicenseCustomer).HasColumnName("BoatLicense_Customer");

                entity.Property(e => e.FirstNameCustomer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("FirstName_Customer");

                entity.Property(e => e.HasRentedCustomer).HasColumnName("HasRented_Customer");

                entity.Property(e => e.LastNameCustomer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LastName_Customer");

                entity.Property(e => e.MailCustomer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Mail_Customer");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.IdMember)
                    .HasName("PRIMARY");

                entity.ToTable("member");

                entity.Property(e => e.IdMember)
                    .HasColumnType("int(11)")
                    .HasColumnName("Id_Member");

                entity.Property(e => e.LoginMember)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Login_Member");

                entity.Property(e => e.PasswordMember)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Password_Member");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
