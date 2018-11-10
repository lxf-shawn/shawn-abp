using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ShawnProject.Configuration.Dto;

namespace ShawnProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ShawnProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
