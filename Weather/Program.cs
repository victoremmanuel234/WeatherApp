using System.Globalization;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "wwwroot"
});

builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();


app.Run();
