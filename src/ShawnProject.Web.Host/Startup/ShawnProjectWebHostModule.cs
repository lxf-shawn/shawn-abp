using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShawnProject.Configuration;

namespace ShawnProject.Web.Host.Startup
{
    [DependsOn(
       typeof(ShawnProjectWebCoreModule))]
    public class ShawnProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ShawnProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ShawnProjectWebHostModule).GetAssembly());
        }
    }
}
