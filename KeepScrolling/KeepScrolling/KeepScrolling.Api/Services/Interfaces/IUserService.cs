using KeepScrolling.ViewModels.Auth;
using KeepScrolling.ViewModels.Models;

namespace KeepScrolling.Api.Services.Interfaces
{
    public interface IUserService
    {
        Task<AuthenticationResponse> Login(HttpContext context);
        Task<UserVM> GetUserByToken(string token);
        Task<bool> IsTokenExpired(string token);
    }
}
