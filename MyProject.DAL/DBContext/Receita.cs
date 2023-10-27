using System;
using System.Collections.Generic;

namespace MyProject.DAL.DBContext;

public partial class Receita
{
    public int Id { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Data { get; set; }

    public int? Idusuario { get; set; }

    public virtual Usuario? IdusuarioNavigation { get; set; }
}
