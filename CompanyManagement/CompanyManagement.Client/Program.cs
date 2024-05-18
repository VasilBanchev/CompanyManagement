using CompanyManagement.ServiceLayer.CQRS.Commands.CreateProjectCommand;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();
