using Bz.F8t.WebApp;
using Bz.F8t.WebApp.ApiClients;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services
    .AddRefitClient<ICompetitionApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Services:AdministrationUri")!));

await builder.Build().RunAsync();
