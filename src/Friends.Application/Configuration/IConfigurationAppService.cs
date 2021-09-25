using System.Threading.Tasks;
using Friends.Configuration.Dto;

namespace Friends.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
