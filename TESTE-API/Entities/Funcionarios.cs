using System;
using System.Collections.Generic;

namespace TESTE_API.Entities;

public class Funcionarios
{
    public int IdFuncionario { get; set; }

    public int IdCargo { get; set; }

    public string Telefone { get; set; } = null!;

    public string Endereco { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public DateOnly DataAdmissao { get; set; }

    public string Ctps { get; set; } = null!;

    public decimal SalarioBruto { get; set; }

    public DateOnly DataNascimento { get; set; }

    public string Banco { get; set; } = null!;

    public string Conta { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool? Ativo { get; set; }

    public string? NomeSocial { get; set; }

    public string? Genero { get; set; }

    public virtual ICollection<ControleDeHora> ControleDeHoras { get; set; } = new List<ControleDeHora>();

    public virtual Cargo IdCargoNavigation { get; set; } = null!;


    public Funcionarios(int id_funcionario, int id_cargo, string nome, string telefone, DateOnly data_admissao, string ctps, decimal salario_bruto, DateOnly data_nascimento, string banco, string conta, string cpf, string email, bool ativo, string nome_social, string genero, string endereco)
    {
        this.IdFuncionario = id_funcionario;
        this.IdCargo = id_cargo;
        this.Nome = nome;
        this.Telefone = telefone;
        this.DataAdmissao = data_admissao;
        this.Ctps = ctps;
        this.SalarioBruto = salario_bruto;
        this.DataNascimento = data_nascimento;
        this.Banco = banco;
        this.Conta = conta;
        this.Cpf = cpf;
        this.Email = email;
        this.Ativo = ativo;
        this.NomeSocial = nome_social;
        this.Genero = genero;
        this.Endereco = endereco;
    }
}

