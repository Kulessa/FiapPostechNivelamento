
var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

//services.AddTransient(typeof(ICatalogo), typeof(Catalogo));
//services.AddTransient<IRelatorio, Relatorio>();

//services.AddScoped(typeof(ICatalogo), typeof(Catalogo));
//services.AddScoped<IRelatorio, Relatorio>();

var catalogo = new Catalogo();
services.AddSingleton<ICatalogo>(catalogo);
services.AddSingleton<IRelatorio>(new Relatorio(catalogo));

var app = builder.Build();

var env = app.Environment;
//ICatalogo catalogoService = app.Services.GetService<ICatalogo>();
//IRelatorio relatorioService = app.Services.GetService<IRelatorio>();

//var scoped = app.Services.CreateScope();
//ICatalogo catalogoService = scoped.ServiceProvider.GetRequiredService<ICatalogo>();
//IRelatorio relatorioService = scoped.ServiceProvider.GetRequiredService<IRelatorio>();

ICatalogo catalogoService = app.Services.GetRequiredService<ICatalogo>();
IRelatorio relatorioService = app.Services.GetRequiredService<IRelatorio>();

app.MapGet("/", () => relatorioService.Imprimir());

app.Run();
