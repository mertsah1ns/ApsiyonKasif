using ApsiyonKasif.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApsiyonKasif.Repository.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<AdvertType> AdvertTypes { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentProperty> ApartmentProperties { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BuildingComplex> BuildingComplexes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<HeatingType> HeatingTypes { get; set; }
        public DbSet<HomeImage> HomeImages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<HomeProperty> HomeProperties { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
    }
}
