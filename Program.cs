using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using todoapp.Data;

string credentialPath = @"C:\Users\User\source\repos\todoapp\todoapp\sample-project-93f93-firebase-adminsdk-u7ase-89c68994a3.json";
Environment.SetEnvironmentVariable(" GOOGLE_APPLICATION_CREDENTIALS", credentialPath);
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
