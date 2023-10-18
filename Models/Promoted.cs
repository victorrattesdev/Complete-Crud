using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models;

public class Promoted
{
    [Key]
    [DisplayName("Id")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Informe o novo cargo na empresa.")]
}