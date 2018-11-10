using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShawnProject.MultiTenancy.Dto;

namespace ShawnProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
