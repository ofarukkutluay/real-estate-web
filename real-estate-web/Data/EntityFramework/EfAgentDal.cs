using System;
using real_estate_web.Data.Abstract;
using real_estate_web.Data.EntityFramework.Common;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Data.EntityFramework
{
    public class EfAgentDal : EfEntityRepositoryBase<Agent, RealEstateDbContext>, IAgentRepository
    {
        public EfAgentDal(RealEstateDbContext context) : base(context)
        {
        }

        public IEnumerable<AgentDto> GetListAgentDto()
        {
            var result = from a in Context.Agents
                        join jt in Context.JobTitles on a.JobTitle equals jt.Id
                        into temp
                        from jt in temp.DefaultIfEmpty()
                        select new AgentDto()
                         {
                             Id = a.Id,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             Email = a.Email,
                             MobileNumber = a.MobileNumber,
                             PhoneNumber = a.PhoneNumber,
                             Description = a.Description,
                             FacebookLink = a.FacebookLink,
                             TwitterLink = a.TwitterLink,
                             LinkedinLink = a.LinkedinLink,
                             InstagramLink = a.InstagramLink,
                             YoutubeLink = a.YoutubeLink,
                             JobTitleName = jt.Name
                         };

            return result;
        }

        public AgentDto GetAgentDto(int? id)
        {
            var result = from a in Context.Agents
                        join jt in Context.JobTitles on a.JobTitle equals jt.Id
                        into temp
                        from jt in temp.DefaultIfEmpty()
                        where a.Id == id
                        select new AgentDto()
                         {
                             Id = a.Id,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             Email = a.Email,
                             MobileNumber = a.MobileNumber,
                             PhoneNumber = a.PhoneNumber,
                             Description = a.Description,
                             FacebookLink = a.FacebookLink,
                             TwitterLink = a.TwitterLink,
                             LinkedinLink = a.LinkedinLink,
                             InstagramLink = a.InstagramLink,
                             YoutubeLink = a.YoutubeLink,
                             JobTitleId = jt.Id,
                             JobTitleName = jt.Name
                         };

            return result.FirstOrDefault();
        }
    }
}
