using KeepScrolling.UI.Auth.Services;
using KeepScrolling.UI.Pages.ServiceHandlers.Interfaces;
using KeepScrolling.ViewModels.Auth;
using KeepScrolling.ViewModels.Models;
using Helpers = KeepScrolling.UI.Helpers;

namespace KeepScrolling.UI.Pages.ServiceHandlers.Definitions
{
    public class UserServiceHandler : ServiceHandlerBase, IUserServiceHandler
    {
        private readonly IAccessTokenService accessTokenService;

        public UserServiceHandler(IAccessTokenService accessTokenService, IConfiguration configuration, HttpClient http) : base(configuration, http)
        {
            this.accessTokenService = accessTokenService;
        }

        public async Task<UserVM> GetLoginUserDetailsAsync()
        {
            bool isExpired = await IsTokenExpiredAsync();

            if (isExpired)
                return null;

            return await Post<UserVM>(Helpers.UriHelper.LoginUserDetails);
        }

        public async Task<bool> IsTokenExpiredAsync()
        {
            return await Post<bool>(Helpers.UriHelper.IsTokenExpired);
        }

        public async Task<AuthenticationResponse> LoginAsync()
        {
            return await Post<AuthenticationResponse>(Helpers.UriHelper.Login);
        }
    }
}
