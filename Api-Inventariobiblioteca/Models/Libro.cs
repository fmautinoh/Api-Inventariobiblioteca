using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Inventariobiblioteca.Models;

public partial class Libro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LibroId { get; set; }

    public string NombreLib { get; set; } = null!;

    public int TipoId { get; set; }

    public int? Edicion { get; set; }

    public string? Año { get; set; }

    public string? Editorial { get; set; }

    public virtual ICollection<InventarioLibro> InventarioLibros { get; set; } = new List<InventarioLibro>();

    public virtual TipoLibro Tipo { get; set; } = null!;
}
