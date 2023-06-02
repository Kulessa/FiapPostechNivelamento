using Web;

internal class Catalogo
{
    public List<Livro> GetLivros() =>
        new List<Livro> {
            new Livro("001", "Quem Mexeu na Minha Query?", 12.99m),
            new Livro("002", "Fique Rico com C#", 30.99m),
            new Livro("003", "Java Para Baixinhos", 25.99m)};
}
