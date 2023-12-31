﻿using System;
using System.Collections.Generic;

namespace Api_Inventariobiblioteca.Models;

public partial class TipoAutor
{
    public int TipoAutorId { get; set; }

    public string TipoAutor1 { get; set; } = null!;

    public virtual ICollection<Autore> Autores { get; set; } = new List<Autore>();
}
