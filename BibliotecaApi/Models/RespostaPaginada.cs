namespace BibliotecaApi.Models;


/// <summary>
/// Representa uma resposta paginada de dados.
/// </summary>
public class RespostaPaginada<T>
{

    /// <summary>
    /// Lista de itens da página atual.
    /// </summary>
    public List<T> Itens { get; set; } = new();

    /// <summary>
    /// Número da página atual.
    /// </summary>
    /// <example>1</example>
    public int Pagina { get; set; }

    /// <summary>
    /// Quantidade de itens por página.
    /// </summary>
    /// <example>10</example>
    public int TamanhoPagina { get; set; }

    /// <summary>
    /// Número total de itens disponíveis.
    /// </summary>
    /// <example>100</example>
    public int TotalItens { get; set; }

    /// <summary>
    /// Número total de páginas calculado com base no total de itens e tamanho da página.
    /// </summary>
    /// <example>10</example>
    public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / TamanhoPagina);
}
