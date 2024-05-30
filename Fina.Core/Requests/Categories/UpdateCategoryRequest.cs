using System.ComponentModel.DataAnnotations;

namespace Fina.Core;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição Inválida")]
    public string? Description { get; set; }
}
