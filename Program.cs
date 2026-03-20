using InventarioApp.Services;
using InventarioApp.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Registramos nuestro servicio 👇
builder.Services.AddSingleton<IProductoService, ProductoService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();

