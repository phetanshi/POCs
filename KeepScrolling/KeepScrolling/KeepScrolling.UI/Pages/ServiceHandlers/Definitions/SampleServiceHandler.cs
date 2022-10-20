using KeepScrolling.UI.Pages.ServiceHandlers.Interfaces;
using KeepScrolling.ViewModels.Models;
using Helpers = KeepScrolling.UI.Helpers;

namespace KeepScrolling.UI.Pages.ServiceHandlers.Definitions
{
    public class SampleServiceHandler : ServiceHandlerBase, ISampleServiceHandler
    {
        public SampleServiceHandler(IConfiguration configuration, HttpClient http) : base(configuration, http)
        {
        }

        public async Task<List<UserVM>> GetUsersAsync()
        {
            return await Get<List<UserVM>>(Helpers.UriHelper.SampleUsers);
        }
    }
}
