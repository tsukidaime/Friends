using System.Threading.Tasks;
using Abp.Application.Services;
using Friends.Authorization.Accounts.Dto;

namespace Friends.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
