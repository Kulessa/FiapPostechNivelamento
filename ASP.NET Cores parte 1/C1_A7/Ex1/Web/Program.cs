
var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddTransient<ICatalogo, Catalogo>();

var app = builder.Build();

var env = app.Environment;

ICatalogo catalogo = app.Services.GetRequiredService<ICatalogo>();
IRelatorio relatorio = new Relatorio(catalogo);

app.MapGet("/", () => relatorio.Imprimir());

app.Run();
