using System.Threading.Tasks;
using Friends.Models.TokenAuth;
using Friends.Web.Controllers;
using Shouldly;
using Xunit;

namespace Friends.Web.Tests.Controllers
{
    public class HomeController_Tests: FriendsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}