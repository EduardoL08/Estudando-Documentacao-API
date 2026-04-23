using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models;

/// <summary>
/// Representa o empréstimo de um livro para um usuário.
/// </summary>
public class Emprestimo
{

    /// <summary>
    /// Identificador único do empréstimo.
    /// </summary>
    /// <example>1</example>
    public int Id { get; set; }


    /// <summary>
    /// Identificador do livro emprestado.
    /// </summary>
    /// <example>1</example>
    [Required]
    public int LivroId { get; set; }


    /// <summary>
    /// Nome do usuário que realizou o empréstimo.
    /// </summary>
    /// <example>João Silva</example>
    [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
    [StringLength(200)]
    public string NomeUsuario { get; set; } = string.Empty;

    /// <summary>
    /// Data em que o empréstimo foi realizado.
    /// </summary>
    /// <example>2026-04-23T10:00:00</example>
    public DateTime DataEmprestimo { get; set; } = DateTime.UtcNow;

  /// <summary>
    /// Data prevista para devolução do livro.
    /// </summary>
    /// <example>2026-04-30T10:00:00</example>
    public DateTime DataDevolucaoPrevista { get; set; } = DateTime.UtcNow.AddDays(14);


    /// <summary>
    /// Data em que o livro foi efetivamente devolvido.
    /// </summary>
    /// <remarks>
    /// Este campo será nulo caso o livro ainda não tenha sido devolvido.
    /// </remarks>
    /// <example>2026-04-28T15:30:00</example>
    public DateTime? DataDevolucaoEfetiva { get; set; }

    /// <summary>
    /// Status atual do empréstimo.
    /// </summary>
    /// <example>Ativo</example>
    public StatusEmprestimo Status { get; set; } = StatusEmprestimo.Ativo;
}

/// <summary>
/// Representa o status atual de um empréstimo.
/// </summary>
public enum StatusEmprestimo
{

    /// <summary>
    /// O livro está emprestado e ainda não foi devolvido.
    /// </summary>
    Ativo,

    /// <summary>
    /// O livro foi devolvido pelo usuário.
    /// </summary>
    Devolvido,

    /// <summary>
    /// O prazo de devolução foi ultrapassado.
    /// </summary>
    Atrasado
}
