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
            CreateMap<PropertyVM,Property>();
            CreateMap<Blog,BlogVM>().ForMember(dest=>dest.Date,mem=>mem.MapFrom(src=>src.Date.ToDateTime(new TimeOnly(01,01))));
            CreateMap<BlogVM,Blog>().ForMember(dest => dest.Date, mem => mem.MapFrom(src => DateOnly.FromDateTime(src.Date)));
            CreateMap<ListingWebsiteScrapingLibrary.PropertyListingDetail, PropertyListingDetail>().ForMember(dest => dest.ListingLink , mem => mem.MapFrom(src=> src.ListiningLink));
        }
    }
}
