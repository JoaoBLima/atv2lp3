using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Categorium
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Despesa> Despesas { get; set; } = new List<Despesa>();
}
