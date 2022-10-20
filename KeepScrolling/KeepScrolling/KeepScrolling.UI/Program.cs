using KeepScrolling.UI;
using KeepScrolling.UI.Auth;
using KeepScrolling.UI.Auth.Services;
using KeepScrolling.UI.Auth.Services.Definitions;
using KeepScrolling.UI.Pages.ServiceHandlers.Definitions;
using KeepScrolling.UI.Pages.ServiceHandlers.Interfaces;
using KeepScrolling.UI.Pages.ServiceHandlers.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace KeepScrolling.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            var baseAddress = new Uri(builder.HostEnvironment.BaseAddress);

            builder.Services.AddHttpClient<ISampleServiceHandler, SampleServiceHandler>("SampleServiceClient", client =>
            {
                client.BaseAddress = baseAddress;
            }).AddHttpMessageHandler<AppAutherizationHandler>();

            builder.Services.AddHttpClient<IUserServiceHandler, UserServiceHandler>("UserServiceClient", client =>
            {
                client.BaseAddress = baseAddress;
            }).AddHttpMessageHandler<AppAutherizationHandler>();

            builder.Services.AddScoped<AuthenticationStateProvider, AppAuthenticationStateProvider>();
            builder.Services.AddTransient<AppAutherizationHandler>();

            builder.Services.AddScoped<IAccessTokenService, AppAccessTokenService>();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            //builder.Services.AddMsalAuthentication(options =>
            //{
            //    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
            //    options.ProviderOptions.DefaultAccessTokenScopes.Add("api://api.id.uri/access_as_user");
            //});

            await builder.Build().RunAsync();
        }
    }
}