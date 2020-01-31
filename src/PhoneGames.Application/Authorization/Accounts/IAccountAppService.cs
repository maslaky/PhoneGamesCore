using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneGames.Authorization.Accounts.Dto;

namespace PhoneGames.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
