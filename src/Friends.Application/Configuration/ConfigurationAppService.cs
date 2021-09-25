using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Friends.Configuration.Dto;

namespace Friends.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FriendsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
