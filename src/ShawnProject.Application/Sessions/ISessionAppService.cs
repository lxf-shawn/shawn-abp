using System.Threading.Tasks;
using Abp.Application.Services;
using ShawnProject.Sessions.Dto;

namespace ShawnProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
