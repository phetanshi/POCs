using KeepScrolling.ViewModels.Auth;
using KeepScrolling.ViewModels.Models;

namespace KeepScrolling.UI.Pages.ServiceHandlers.Interfaces
{
    public interface IUserServiceHandler
    {
        Task<AuthenticationResponse> LoginAsync();
        Task<bool> IsTokenExpiredAsync();
        Task<UserVM> GetLoginUserDetailsAsync();
    }
}
