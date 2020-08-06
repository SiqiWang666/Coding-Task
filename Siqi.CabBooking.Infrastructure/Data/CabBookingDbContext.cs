using Microsoft.EntityFrameworkCore;
using Siqi.CabBooking.Core.Entities;

namespace Siqi.CabBooking.Infrastructure.Data
{
    public class CabBookingDbContext : DbContext
    {
        public CabBookingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<CabType> CabTypes { get; set; }
        public DbSet<BookingHistory> BookingHistories { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>((modelBuilder) =>
            {
                modelBuilder.ToTable("Place");
                modelBuilder.HasKey(p => p.Id);
                modelBuilder.Property(p => p.PlaceName).HasMaxLength(100);
            });

            modelBuilder.Entity<CabType>(modelBuilder =>
            {
                modelBuilder.ToTable("CabType");
                modelBuilder.HasKey(c => c.Id);
                modelBuilder.Property(c => c.CabTypeName).HasMaxLength(30);
            });

            modelBuilder.Entity<BookingHistory>(modelBuilder =>
            {
                modelBuilder.ToTable("BookingHistory");
                modelBuilder.HasKey(bh => bh.Id);
                modelBuilder.Property(bh => bh.Email).HasMaxLength(50);
                modelBuilder.Property(bh => bh.Charge).HasColumnType("DECIMAL(5, 2)");
                modelBuilder.Property(bh => bh.PickupAddress).HasMaxLength(200);
                modelBuilder.Property(bh => bh.ContactNo).HasMaxLength(25);

                // modelBuilder.HasOne(bh => bh.FromPlace).WithMany(p => p.FromBookingHistories)
                //     .HasForeignKey(bh => bh.FromPlaceId).IsRequired();
                // modelBuilder.HasOne(bh => bh.ToPlace).WithMany(p => p.ToBookingHistories)
                //     .HasForeignKey(bh => bh.ToPlaceId).IsRequired().OnDelete(DeleteBehavior.Restrict);
                // modelBuilder.HasOne(bh => bh.Cab).WithMany(c => c.BookingHistories).HasForeignKey(bh => bh.CabTypeId);

            });

            modelBuilder.Entity<Booking>(modelBuilder =>
            {
                modelBuilder.ToTable("Booking");
                modelBuilder.HasKey(b => b.Id);
                modelBuilder.Property(b => b.Email).HasMaxLength(50);
                modelBuilder.Property(b => b.PickupAddress).HasMaxLength(200);
                modelBuilder.Property(b => b.ContactNo).HasMaxLength(25);

                // modelBuilder.HasOne(b => b.FromPlace).WithMany(p => p.FromBookings)
                //     .HasForeignKey(b => b.FromPlaceId);
                // modelBuilder.HasOne(b => b.ToPlace).WithMany(p => p.ToBookings)
                //     .HasForeignKey(b => b.ToPlaceId).OnDelete(DeleteBehavior.Restrict);
                modelBuilder.HasOne(b => b.Cab).WithMany(c => c.Bookings).HasForeignKey(b => b.CabTypeId);
            });
        }
    }
}