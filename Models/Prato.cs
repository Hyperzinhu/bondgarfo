using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BondGarfoApp.Models;

public class Prato
{
    public int Id {get; set;}
    
    public string Nome {get; set;}
    
    public string Ingredientes  {get; set;}

    [Display(Name="Categoria")]
    public int CategoriaId {get; set;}
    
    public string categoria {get; set;}
    
    [Display(Name="Preço")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco {get; set;}
    
    [Display(Name="Data de Validade")]
    [DataType(DataType.Date)]
    public DateTime Validade {get; set;}

    // Atributo de Relacionamento
    public virtual Categoria Categoria {get; set;}
}