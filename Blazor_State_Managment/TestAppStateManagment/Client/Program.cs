using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TestAppStateManagment.Client;
using TestAppStateManagment.Client.Infrastructure;
using TestAppStateManagment.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddSingleton<User>();
builder.Services.AddSingleton<AppStateManager>();


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
