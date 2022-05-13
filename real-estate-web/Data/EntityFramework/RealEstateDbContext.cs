using Microsoft.EntityFrameworkCore;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework
{
    public class RealEstateDbContext : DbContext
    {
        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Agent>().HasOne<JobTitle>().WithMany().HasForeignKey(x=>x.JobTitle);
            //modelBuilder.Entity<District>().HasOne<City>().WithMany().HasForeignKey(x => x.IlKey);
            //modelBuilder.Entity<Neighborhood>().HasOne<District>().WithMany().HasForeignKey(x => x.IlceId);
            //modelBuilder.Entity<Street>().HasOne<Neighborhood>().WithMany().HasForeignKey(x => x.MahalleId);
            modelBuilder.Entity<Property>().HasOne<City>().WithMany().HasForeignKey(x => x.IlId);
            modelBuilder.Entity<Property>().HasOne<District>().WithMany().HasForeignKey(x => x.IlceId);
            modelBuilder.Entity<Property>().HasOne<Neighborhood>().WithMany().HasForeignKey(x => x.MahalleId);
            //modelBuilder.Entity<Property>().HasOne<Street>().WithMany().HasForeignKey(x => x.SokakId);
            modelBuilder.Entity<Property>().HasOne<PropertyType>().WithMany().HasForeignKey(x => x.PropertyTypeId);
            modelBuilder.Entity<Property>().HasOne<Status>().WithMany().HasForeignKey(x => x.StatusId);
            modelBuilder.Entity<Property>().HasOne<HeatingType>().WithMany().HasForeignKey(x => x.IsitmaTipiId);
            modelBuilder.Entity<Property>().HasOne<InternetType>().WithMany().HasForeignKey(x => x.InternetTipiId);
            modelBuilder.Entity<Property>().HasOne<Front>().WithMany().HasForeignKey(x => x.CepheId);
            modelBuilder.Entity<Property>().HasOne<UsingStatus>().WithMany().HasForeignKey(x => x.KullanimDurumuId);
            modelBuilder.Entity<Property>().HasOne<DeedStatus>().WithMany().HasForeignKey(x => x.TapuDurumuId);
            modelBuilder.Entity<Property>().HasOne<Agent>().WithMany().HasForeignKey(x => x.AgentId);
            modelBuilder.Entity<PropertyPhoto>().HasOne<Property>().WithMany().HasForeignKey(x => x.PropertyId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Front> Fronts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<InternetType> InternetTypes { get; set; }
        public DbSet<HeatingType> HeatingTypes { get; set; }
        public DbSet<UsingStatus> UseCases { get; set; }
        public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<DeedStatus> DeedStatuses { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
