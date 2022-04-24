using AutoMapper;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;
using real_estate_web.Models.ViewModel;

namespace real_estate_web.Tools.Mapper
{
    public class AutoMapperHelper : Profile
    {
        public AutoMapperHelper()
        {
            CreateMap<AgentDto,AgentVM>();
            CreateMap<AgentVM,Agent>().ForMember(dest=> dest.JobTitle, mem=> mem.MapFrom(src=>src.JobTitleId));
            CreateMap<PropertyDto,PropertyVM>();
        }
    }
}
