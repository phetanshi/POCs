using KeepScrolling.Domain;
using KeepScrolling.ViewModels.Models;

namespace KeepScrolling.Api.Services.Interfaces
{
    public interface ISampleService
    {
        Task<List<UserVM>> GetUsers();
    }
}
