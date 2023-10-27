﻿using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Senha { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Despesa> Despesas { get; set; } = new List<Despesa>();

    public virtual ICollection<Receita> Receita { get; set; } = new List<Receita>();
}
