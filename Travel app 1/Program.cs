using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Travel_app_1;
using Travel_app_1.TravelApp;
using Travel_app_1.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TravelAppService>();
builder.Services.AddScoped<NorthwindService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbInputModule),
        typeof(IgbCheckboxModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbIconButtonModule),
        typeof(IgbAvatarModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbCardModule),
        typeof(IgbGridModule)
    );
}