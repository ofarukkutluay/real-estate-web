using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework
{
    public class EfFrontDal : EfEntityRepositoryBase<Front,RealEstateDbContext>, IFrontRepository
    {
        public EfFrontDal(RealEstateDbContext context) : base(context)
        {
        }
    }
}
