using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShawnProject.Authorization;

namespace ShawnProject
{
    [DependsOn(
        typeof(ShawnProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ShawnProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ShawnProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ShawnProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
