using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models;

public class Exclusive
{
    [Key]
    [DisplayName("Id")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Informe o filme exclusivo que deseja acessar")]
    [StringLength(50, ErrorMessage = "O nome do filme só pode conter até 50 caracteres")]
    [MinLength(2, ErrorMessage = "O nome do filme não pode conter menos de 2 caracteres")]
    [DisplayName("Título")]
    public string Movie { get; set; } = string.Empty;
    
    [DataType(DataType.Date)]
    [DisplayName("Início da promoção")]
    public DateTime StartExclusive { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayName("Fim da promoção")]
    public DateTime EndExclusive { get; set; }
    
    [DisplayName("Generô do Filme")]
    [Required(ErrorMessage = "Gênero inválido e/ou não existente.")]
    public string? Gender { get; set; }
    


}
