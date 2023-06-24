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

            modelBuilder.Entity<Agent>().HasOne<JobTitle>().WithMany().HasForeignKey(x => x.JobTitle);
            modelBuilder.Entity<Property>().HasOne<City>().WithMany().HasForeignKey(x => x.IlId);
            modelBuilder.Entity<Property>().HasOne<District>().WithMany().HasForeignKey(x => x.IlceId);
            modelBuilder.Entity<Property>().HasOne<Neighborhood>().WithMany().HasForeignKey(x => x.MahalleId);
            //modelBuilder.Entity<Property>().HasOne<PropertyType>().WithMany().HasForeignKey(x => x.PropertyTypeId);
            //modelBuilder.Entity<Property>().HasOne<Status>().WithMany().HasForeignKey(x => x.StatusId);
            //modelBuilder.Entity<Property>().HasOne<HeatingType>().WithMany().HasForeignKey(x => x.IsitmaTipiId);
            //modelBuilder.Entity<Property>().HasOne<InternetType>().WithMany().HasForeignKey(x => x.InternetTipiId);
            //modelBuilder.Entity<Property>().HasOne<Front>().WithMany().HasForeignKey(x => x.CepheId);
            //modelBuilder.Entity<Property>().HasOne<UsingStatus>().WithMany().HasForeignKey(x => x.KullanimDurumuId);
            //modelBuilder.Entity<Property>().HasOne<DeedStatus>().WithMany().HasForeignKey(x => x.TapuDurumuId);
            modelBuilder.Entity<Property>().HasOne<Agent>().WithMany().HasForeignKey(x => x.AgentId);
            modelBuilder.Entity<PropertyPhoto>().HasOne<Property>().WithMany().HasForeignKey(x => x.PropertyId);

            modelBuilder.Entity<Front>().HasData(new Front { Id=1,Name = "Kuzey" },
                        new Front { Id = 2, Name = "Kuzey Doğu" },
                        new Front { Id = 3, Name = "Doğu" },
                        new Front { Id = 4, Name = "Güney Doğu" },
                        new Front { Id = 5, Name = "Güney" },
                        new Front { Id = 6, Name = "Güney Batı" },
                        new Front { Id = 7, Name = "Batı" },
                        new Front { Id = 8, Name = "Kuzey Batı" },
                        new Front { Id = 9, Name = "Bilinmiyor" });
            modelBuilder.Entity<DeedStatus>().HasData(new DeedStatus { Id = 1, Name = "Kat Mülkiyetli" },
                        new DeedStatus { Id = 2, Name = "Kat İrtifaklı" },
                        new DeedStatus { Id = 3, Name = "Arsa" },
                        new DeedStatus { Id = 4, Name = "Tarla" });
            modelBuilder.Entity<HeatingType>().HasData(new HeatingType { Id = 1, Name = "Doğalgaz Sobalı" },
                        new HeatingType { Id = 2, Name = "Sobalı" },
                        new HeatingType { Id = 3, Name = "Yerden Isıtma" },
                        new HeatingType { Id = 4, Name = "Kombili" },
                        new HeatingType { Id = 5, Name = "Merkezi Sistem" },
                        new HeatingType { Id = 6, Name = "FuelOil" });
            modelBuilder.Entity<InternetType>().HasData(new InternetType { Id = 1, Name = "ADSL/VDSL" },
                        new InternetType { Id = 2, Name = "Fiber" },
                        new InternetType { Id = 3, Name = "Bilinmiyor" });
            modelBuilder.Entity<JobTitle>().HasData(new JobTitle { Id = 1, Name = "Broker" },
                        new JobTitle { Id = 2, Name = "Danışman" },
                        new JobTitle { Id = 3, Name = "Müdür" },
                        new JobTitle { Id = 4, Name = "Asistan" });
            modelBuilder.Entity<PropertyType>().HasData(new PropertyType() { Id = 1, Name = "Daire" },
                        new PropertyType() { Id = 2, Name = "Rezidence" },
                        new PropertyType() { Id = 3, Name = "Müstakil Ev" },
                        new PropertyType() { Id = 4, Name = "Villa" },
                        new PropertyType() { Id = 5, Name = "Çiftlik Evi" },
                        new PropertyType() { Id = 6, Name = "Yazlık" },
                        new PropertyType() { Id = 7, Name = "Büro/Ofis" },
                        new PropertyType() { Id = 8, Name = "Depo/Antrepo" },
                        new PropertyType() { Id = 9, Name = "Dükkan/Mağaza" },
                        new PropertyType() { Id = 10, Name = "Plaza" },
                        new PropertyType() { Id = 11, Name = "Palaza Katı" },
                        new PropertyType() { Id = 12, Name = "Sağlık Merkezi" },
                        new PropertyType() { Id = 13, Name = "Spor Tesisi" });
            modelBuilder.Entity<Status>().HasData(new Status() { Id = 1, Name = "Satılık" },
                        new Status() { Id = 2, Name = "Kiralık" },
                        new Status() { Id = 3, Name = "Devren Satılık" },
                        new Status() { Id = 4, Name = "Devren Kiralık" });
            modelBuilder.Entity<UsingStatus>().HasData(new UsingStatus() { Id = 1, Name = "Boş" },
                        new UsingStatus() { Id = 2, Name = "Mülk Sahibi" },
                        new UsingStatus() { Id = 3, Name = "Kiracılı" });
            modelBuilder.Entity<About>().HasData(new About()
            {
                Id = 1,
                Title = "Birlikte mutlu anılar biriktirebileceğiniz mülkler buluyoruz",
                BodyTitle = "Neden biz?",
                BodyContentA = @"Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a.
         Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec,
          egestas non nisi. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec velit neque, 
          auctor sit amet aliquam vel, ullamcorper sit amet ligula.",
                BodyContentB = @"Sed porttitor lectus nibh. Vivamus magna justo, lacinia eget consectetur sed, 
        convallis at tellus. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. 
        Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus."
            });
            modelBuilder.Entity<Contact>().HasData(new Contact()
            {
                Id=1,
                HeaderDescription = "Aut voluptas consequatur unde sed omnis ex placeat quis eos. Aut natus officia corrupti qui autem fugit consectetur quo. Et ipsum eveniet laboriosam voluptas beatae possimus qui ducimus. Et voluptatem deleniti. Voluptatum voluptatibus amet. Et esse sed omnis inventore hic culpa.",
                GoogleIFrameUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3009.665346984029!2d29.08746581564773!3d41.03257692587779!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cac8566285c3d7%3A0x60da11ebc95f76ce!2sTantavi%2C%20Estergon%20Cd.%20No%3A43%2C%2034764%20%C3%9Cmraniye%2F%C4%B0stanbul!5e0!3m2!1str!2str!4v1649872532554!5m2!1str!2str",
                Email = "contact@example.com",
                PhoneNumber = "+54 356 945234",
                Address = "Üsküdar/İstanbul"
            });

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
        public DbSet<PropertyListingDetail> PropertyListingDetails { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    //EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
