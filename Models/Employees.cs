using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Crud.Models;

public class Employees
{
    [Key]
    [DisplayName("Id")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome Completo")]
    [StringLength(80, ErrorMessage = "O nome só pode conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome precisa conter pelo menos 5 caracteres")]
    [DisplayName("Nome Completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "Email inválido, por favor insira o e-mail correto")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a sua data de nascimento")]
    [DisplayName("Data de Nascimento")]
    public int Year { get; set; }
    
    [Required(ErrorMessage = "Informe o seu cargo")]
    [MinLength(5, ErrorMessage = "O nome do seu cargo precisa conter ao menos 5 caracteres")]
    [DisplayName("Cargo")]
    public string Cargo { get; set; } = string.Empty;

    public List<Promoted> Promoteds { get; set; } = new();
}