using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored;
using Blazored.LocalStorage;
using Syncfusion.Blazor;

namespace MVIOperations
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk0MDQxQDMxMzgyZTMyMmUzMGV4ZTEyaWhQNkFwY09CRXM5OFN6RU9QZy9XZldDdk5jMEdyU09DalJPWHM9;Mjk0MDQyQDMxMzgyZTMyMmUzMEN1K1FqRFA5REZEQWpIb1IyWjhQMlJoeWJvWWJXZUd5KzcyVGRhQnJWckU9;Mjk0MDQzQDMxMzgyZTMyMmUzMFBJazcrU2ExaVg5bHdSMmt5Z2N3U0hJL1ZFbUNhRjNxY3pnL0hsU1AzaUk9;Mjk0MDQ0QDMxMzgyZTMyMmUzMFArRCthREF1Ykt6czlZc0JzcnZGaXUrNVJBOEJ3bGQzNnZvOFYwUm5FOFE9;Mjk0MDQ1QDMxMzgyZTMyMmUzMFdlQ1VMZzZJYmtIQXY1N1VFQ3QyOFpEZWxSdmY2SlF3dkxweVplKzVqUDQ9;Mjk0MDQ2QDMxMzgyZTMyMmUzME11UmVma2xiNy84L0V0WHJXalZObmQ2YUt6M0YyVlF3WGFFVFVZM2hQN009;Mjk0MDQ3QDMxMzgyZTMyMmUzMG84Y3BWa3lFODhVd2FvNWRweE52b0RJeWg4QWo2TG5OdnRHOGFtZ0U0ZEU9;Mjk0MDQ4QDMxMzgyZTMyMmUzMFdRMk13ZmtRdVpjU3dHWFVvUWRGSXp2aHBrelQ2eDNITzUwK3Fwa1JCRW89;Mjk0MDQ5QDMxMzgyZTMyMmUzMEIzOXRUQmdhWU5sQUtXQlVIRC9hZmlpRDYyRDkvVUhqbkFXL2g4ZTh3elk9;NT8mJyc2IWhia31hfWN9Z2doYmF8YGJ8ampqanNiYmlmamlmanMDHmg5MTI6ITcTPCYnPzw8OH0wPD4=;Mjk0MDUwQDMxMzgyZTMyMmUzMGlnOUlTUVRBRGs0MjdDNmQxYSt0bFhYTEc5WlZid3MyT2x6SythNVNGTTA9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage(config => config.JsonSerializerOptions.WriteIndented = true);
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();
        }
    }
}
