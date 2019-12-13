namespace TrainReserveSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Passenger_Booking> Passenger_Booking { get; set; }
        public virtual DbSet<Passenger_Details> Passenger_Details { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Train_Detail> Train_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Passenger_Booking)
                .WithRequired(e => e.Booking)
                .HasForeignKey(e => e.FK_Booking_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Booking)
                .HasForeignKey(e => e.FK_Booking_ID);

            modelBuilder.Entity<Passenger_Details>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_Details>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_Details>()
                .Property(e => e.P_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_Details>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_Details>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_Details>()
                .HasMany(e => e.Passenger_Booking)
                .WithRequired(e => e.Passenger_Details)
                .HasForeignKey(e => e.FK_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Train_Detail>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Train_Detail>()
                .Property(e => e.Destination)
                .IsUnicode(false);

            modelBuilder.Entity<Train_Detail>()
                .Property(e => e.Train_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Train_Detail>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Train_Detail)
                .HasForeignKey(e => e.FK_Train_Detail_ID);
        }
    }
}
