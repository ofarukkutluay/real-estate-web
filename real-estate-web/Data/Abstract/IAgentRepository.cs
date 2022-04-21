using real_estate_web.Data.Common;
using real_estate_web.Models.Database;
using real_estate_web.Models.Database.Dtos;

namespace real_estate_web.Data.Abstract
{
    public interface IAgentRepository : IEntityRepository<Agent>
    {
        IEnumerable<AgentDto> GetListAgentDto();
        AgentDto GetAgentDto(int? id);
    }
}
