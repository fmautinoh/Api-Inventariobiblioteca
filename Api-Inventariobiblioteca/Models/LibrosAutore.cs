using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api_Inventariobiblioteca.Models;

public partial class LibrosAutore
{
    [Required]
    [ForeignKey(nameof(LibroId))]
    public int LibroId { get; set; }
    [Required]
    [ForeignKey(nameof(AutorId))]
    public int AutorId { get; set; }
    [JsonIgnore]
    public virtual Autore Autor { get; set; } = null!;
    [JsonIgnore]
    public virtual Libro Libro { get; set; } = null!;
}