using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework
{
    public class EfAboutDal : EfEntityRepositoryBase<About,RealEstateDbContext> ,IAboutRepository
    {
        public EfAboutDal(RealEstateDbContext context) : base(context)
        {
        }
    }
}