 using CompanyManagement;
 using CompanyManagement.Components;
 using CompanyManagement.ServiceLayer.CQRS.Commands.CreateProjectCommand;
 using Shared.Extensions;

 var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 builder.AddExtensions(); 
 builder.Services.AddApplicationExtensions(new[] { typeof(CreateProjectCommand).Assembly });

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery(); 
 app.EnsureDatabaseCreated();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(CompanyManagement.Client._Imports).Assembly);

app.Run();
