using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api_Inventariobiblioteca.Models;

public partial class Autore
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AutorId { get; set; }
    [Required]
    [StringLength(80)]
    public string NombreAutor { get; set; } = null!;
    [Required]
    [ForeignKey(nameof(TipoAutorId))]
    public int TipoAutorId { get; set; }
    [JsonIgnore]
    public virtual TipoAutor TipoAutor { get; set; } = null!;
}
