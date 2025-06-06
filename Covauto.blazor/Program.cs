using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Covauto.blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var apiUrl = "https://localhost:7119/";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });



await builder.Build().RunAsync();
