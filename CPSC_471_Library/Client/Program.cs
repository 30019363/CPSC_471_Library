global using CPSC_471_Library.Client.Services.BookService;
global using CPSC_471_Library.Client.Services.EventService;
global using CPSC_471_Library.Shared;
using CPSC_471_Library.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IEventService, EventService>();

await builder.Build().RunAsync();
