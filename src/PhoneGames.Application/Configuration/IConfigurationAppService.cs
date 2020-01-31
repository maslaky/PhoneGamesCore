using System.Threading.Tasks;
using PhoneGames.Configuration.Dto;

namespace PhoneGames.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
