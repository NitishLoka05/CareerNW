namespace CareerNW.RepoEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CareerNWDbContext : DbContext
    {
        public CareerNWDbContext()
            : base("name=CareerNWDbContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<EMail> EMails { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.StreetAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.StreetAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Vendors)
                .WithMany(e => e.Addresses)
                .Map(m => m.ToTable("VendorAddress").MapLeftKey("AddressID").MapRightKey("VendorID"));

            modelBuilder.Entity<EMail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<EMail>()
                .HasMany(e => e.Vendors)
                .WithMany(e => e.EMails)
                .Map(m => m.ToTable("VendorEMail").MapLeftKey("EMailID").MapRightKey("VendorID"));

            modelBuilder.Entity<Phone>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<Phone>()
                .HasMany(e => e.Vendors)
                .WithMany(e => e.Phones)
                .Map(m => m.ToTable("VendorPhone").MapLeftKey("PhoneID").MapRightKey("VendorID"));

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
