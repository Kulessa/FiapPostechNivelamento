var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new Relatorio(new Catalogo()).Imprimir());

app.Run();
