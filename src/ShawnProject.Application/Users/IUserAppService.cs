using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShawnProject.Roles.Dto;
using ShawnProject.Users.Dto;

namespace ShawnProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
