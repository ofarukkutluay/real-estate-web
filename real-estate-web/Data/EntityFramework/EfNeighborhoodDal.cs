using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework
{
    public class EfNeighborhoodDal : EfEntityRepositoryBase<Neighborhood,RealEstateDbContext>,INeighborhoodRepository
    {
        public EfNeighborhoodDal(RealEstateDbContext context) : base(context)
        {
        }
    }
}
