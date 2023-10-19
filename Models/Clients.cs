using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models;

public class Clients
{
    [Key]
    [DisplayName("Id")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Informe o seu nome completo")]
    [StringLength(80, ErrorMessage = "O nome só pode conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome precisa conter pelo menos 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe seu e-mail")]
    [EmailAddress(ErrorMessage = "Email inválido, por favor insira o e-mail correto")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a sua data de nascimento")]
    [DataType(DataType.Date)]
    [DisplayName("Data de Nascimento")]
    public DateTime Year { get; set; }
    
    [DisplayName(" Informe o seu gênero de filme preferido")]
    public string Gender { get; set; } = string.Empty;

    public List<Exclusive> Exclusives { get; set; } = new();
}