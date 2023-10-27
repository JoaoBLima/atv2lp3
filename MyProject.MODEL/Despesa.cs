using System;
using System.Collections.Generic;

namespace MyProject.MODEL;

public partial class Despesa
{
    public int Id { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Data { get; set; }

    public int? Idusuario { get; set; }

    public int? Idcategoria { get; set; }

    public virtual Categorium? IdcategoriaNavigation { get; set; }

    public virtual Usuario? IdusuarioNavigation { get; set; }
}
