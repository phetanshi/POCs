using KeepScrolling.ViewModels.Models;

namespace KeepScrolling.UI.Pages.ServiceHandlers.Interfaces
{
    public interface ISampleServiceHandler
    {
        Task<List<UserVM>> GetUsersAsync();
    }
}
