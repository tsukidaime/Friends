using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Friends.EntityFrameworkCore;
using Friends.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Friends.Web.Tests
{
    [DependsOn(
        typeof(FriendsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FriendsWebTestModule : AbpModule
    {
        public FriendsWebTestModule(FriendsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FriendsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FriendsWebMvcModule).Assembly);
        }
    }
}