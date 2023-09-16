using System;
using System.Collections.Generic;

namespace TESTE_API.Entities;

public partial class Login
{
    public int IdFuncionario { get; set; }

    public string? Login1 { get; set; }

    public string? Senha { get; set; }

    public virtual Funcionarios IdFuncionarioNavigation { get; set; } = null!;
}
