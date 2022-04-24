using real_estate_web.Data.Common;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Data.Abstract
{
    public interface IPropertyRepository : IEntityRepository<Property>
    {
        IEnumerable<PropertyDto> GetListAgentIdPropertyDto(int agentId);
        PropertyDto GetPropertyDto(int id);
        IEnumerable<PropertyDto> GetListPropertyDto();
    }
}
