using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PhoneGames.Configuration.Dto;

namespace PhoneGames.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneGamesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
