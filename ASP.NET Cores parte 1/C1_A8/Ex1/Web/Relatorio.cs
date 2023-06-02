internal class Relatorio : IRelatorio
{
    private readonly ICatalogo catalogo;

    public Relatorio(ICatalogo catalogo) => this.catalogo = catalogo;
    public string Imprimir() =>
        string.Join(null, catalogo.GetLivros()
            .Select(livro =>
                $"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco,10:C}\r\n"));
}
