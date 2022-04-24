using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework
{
    public class EfCityRepository : EfEntityRepositoryBase<City, RealEstateDbContext> , ICityRepository
    {
        public EfCityRepository(RealEstateDbContext context) : base(context)
        {
        }
    }
}
