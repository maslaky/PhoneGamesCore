using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneGames.Sessions.Dto;

namespace PhoneGames.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
