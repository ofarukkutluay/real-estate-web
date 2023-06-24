using Microsoft.EntityFrameworkCore;
using real_estate_web.Data.EntityFramework;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.Common
{
    public static class DataGenerator
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RealEstateDbContext(serviceProvider.GetRequiredService<DbContextOptions<RealEstateDbContext>>()))
            {

                if (!context.Fronts.Any())
                {
                    List<Front> fronts = new List<Front>
                    {
                        new Front { Name = "Kuzey" },
                        new Front { Name = "Kuzey Doğu" },
                        new Front { Name = "Doğu" },
                        new Front { Name = "Güney Doğu" },
                        new Front { Name = "Güney" },
                        new Front { Name = "Güney Batı" },
                        new Front { Name = "Batı" },
                        new Front { Name = "Kuzey Batı" },
                        new Front{Name= "Bilinmiyor"}
                    };
                    await context.Fronts.AddRangeAsync(fronts);
                }

                if (!context.DeedStatuses.Any())
                {
                    List<DeedStatus> deedStatusList = new List<DeedStatus>
                    {
                        new DeedStatus { Name = "Kat Mülkiyetli" },
                        new DeedStatus { Name = "Kat İrtifaklı" },
                        new DeedStatus { Name = "Arsa" },
                        new DeedStatus { Name = "Tarla" }
                    };
                    await context.DeedStatuses.AddRangeAsync(deedStatusList);
                }

                if (!context.HeatingTypes.Any())
                {
                    List<HeatingType> heatingTypes = new List<HeatingType>
                    {
                        new HeatingType { Name = "Doğalgaz Sobalı" },
                        new HeatingType { Name = "Sobalı" },
                        new HeatingType { Name = "Yerden Isıtma" },
                        new HeatingType { Name = "Kombili" },
                        new HeatingType { Name = "Merkezi Sistem" },
                        new HeatingType { Name = "FuelOil" }
                    };
                    await context.HeatingTypes.AddRangeAsync(heatingTypes);
                }

                if (!context.InternetTypes.Any())
                {
                    List<InternetType> internetTypes = new List<InternetType>
                    {
                        new InternetType { Name = "ADSL/VDSL" },
                        new InternetType { Name = "Fiber" },
                        new InternetType { Name = "Bilinmiyor"}
                    };
                    await context.InternetTypes.AddRangeAsync(internetTypes);
                }

                if (!context.JobTitles.Any())
                {
                    List<JobTitle> jobTitles = new List<JobTitle>
                    {
                        new JobTitle { Name = "Broker" },
                        new JobTitle { Name = "Danışman" },
                        new JobTitle { Name = "Müdür" },
                        new JobTitle { Name = "Asistan" }
                    };
                    await context.JobTitles.AddRangeAsync(jobTitles);
                }

                if (!context.PropertyTypes.Any())
                {
                    List<PropertyType> propertyTypes = new List<PropertyType>
                    {
                        new PropertyType() { Name = "Daire" },
                        new PropertyType() { Name = "Rezidence" },
                        new PropertyType() { Name = "Müstakil Ev" },
                        new PropertyType() { Name = "Villa" },
                        new PropertyType() { Name = "Çiftlik Evi" },
                        new PropertyType() { Name = "Yazlık" },
                        new PropertyType() { Name = "Büro/Ofis" },
                        new PropertyType() { Name = "Depo/Antrepo" },
                        new PropertyType() { Name = "Dükkan/Mağaza" },
                        new PropertyType() { Name = "Plaza" },
                        new PropertyType() { Name = "Palaza Katı" },
                        new PropertyType() { Name = "Sağlık Merkezi" },
                        new PropertyType() { Name = "Spor Tesisi" }
                    };
                    await context.PropertyTypes.AddRangeAsync(propertyTypes);
                }

                if (!context.Statuses.Any())
                {
                    List<Status> statusList = new List<Status>
                    {
                        new Status() { Name = "Satılık" },
                        new Status() { Name = "Kiralık" },
                        new Status() { Name = "Devren Satılık" },
                        new Status() { Name = "Devren Kiralık" }
                    };
                    await context.Statuses.AddRangeAsync(statusList);
                }

                if (!context.UseCases.Any())
                {
                    List<UsingStatus> usingStatusList = new List<UsingStatus>
                    {
                        new UsingStatus() { Name = "Boş" },
                        new UsingStatus() { Name = "Mülk Sahibi" },
                        new UsingStatus() { Name = "Kiracılı" }
                    };
                    await context.UseCases.AddRangeAsync(usingStatusList);
                }

                if (!context.About.Any())
                {
                    await context.About.AddAsync(new About());
                }
                if(!context.Contact.Any()){
                    await context.Contact.AddAsync(new Contact());
                }
                

                await context.SaveChangesAsync();
            }
        }
    }
}
