using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyeto.Models;

public class CategoriumModel
{
    public int IdCategoria { get; set; }

    public string? Descripcion { get; set; } 

    public string? Tipo { get; set; } 
}
