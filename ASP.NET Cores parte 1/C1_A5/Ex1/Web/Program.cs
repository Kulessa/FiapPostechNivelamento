using Web;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
    string.Join(null,
        new List<Livro> {
            new Livro("001", "Quem Mexeu na Minha Query?", 12.99m),
            new Livro("002", "Fique Rico com C#", 30.99m),
            new Livro("003", "Java Para Baixinhos", 25.99m)}
            .Select(livro => 
                $"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco,10:C}\r\n")));

app.Run();
