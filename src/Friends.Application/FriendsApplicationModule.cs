using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Friends.Authorization;

namespace Friends
{
    [DependsOn(
        typeof(FriendsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FriendsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FriendsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FriendsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
