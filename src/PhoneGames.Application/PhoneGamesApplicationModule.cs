using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneGames.Authorization;

namespace PhoneGames
{
    [DependsOn(
        typeof(PhoneGamesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneGamesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneGamesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhoneGamesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
