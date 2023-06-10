using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BondGarfoApp.Models;

public class Categoria
{
    public int Id {get; set;}
    [Display(Name="Categoria")]
    public string Nome {get; set;}
    [Display(Name="Descrição")]
    public string Descricao  {get; set;}

    // Atributo de Relacionamento
    public virtual List<Prato> Pratos {get; set;}
  
}