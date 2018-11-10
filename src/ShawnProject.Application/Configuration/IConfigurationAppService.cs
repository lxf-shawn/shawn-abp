using System.Threading.Tasks;
using ShawnProject.Configuration.Dto;

namespace ShawnProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
