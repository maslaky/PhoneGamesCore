using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneGames.Configuration;

namespace PhoneGames.Web.Host.Startup
{
    [DependsOn(
       typeof(PhoneGamesWebCoreModule))]
    public class PhoneGamesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoneGamesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneGamesWebHostModule).GetAssembly());
        }
    }
}
