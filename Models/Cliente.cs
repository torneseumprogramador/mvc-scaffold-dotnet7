using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace scaffold.Models;

public class Cliente
{
    public int Id {get;set;}

    [Required]
    public string Nome {get;set;} = default!;

    public string Telefone {get;set;} = default!;

    public string Observacao { get; set; } = default!;
}