using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneGames.MultiTenancy.Dto;

namespace PhoneGames.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

