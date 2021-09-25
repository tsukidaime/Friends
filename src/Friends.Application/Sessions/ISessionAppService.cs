using System.Threading.Tasks;
using Abp.Application.Services;
using Friends.Sessions.Dto;

namespace Friends.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
