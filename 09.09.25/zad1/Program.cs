var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();


var ciemnoskoreMiasta = new List<String>
{
    "francja fuj",
    "wlochy",
    "niemcy",
    "afryka"
};

app.MapDefaultControllerRoute();
app.UseStaticFiles();


app.MapGet("/", () => "Hello World!");
app.MapGet("/witam", () => "Hello witam!");
app.MapGet("/siema", () => "Hello siema!");
app.MapGet("/czarnuchy", () => ciemnoskoreMiasta);

app.Run();
