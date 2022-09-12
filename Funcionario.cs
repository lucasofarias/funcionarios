using System;
using System.Globalization;

namespace exercício;

class Funcionario {
    
    public string Id { get; set; }
    public string Nome { get; set; }
    public double Salario { get; private set; }

    public Funcionario(string id, string nome, double salario) {
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public Funcionario(string id, string nome) {
        Id = id;
        Nome = nome;
    }

    public void AumentarSalario(double porcentagem) {
        Salario = Salario + Salario * porcentagem / 100;
    }

    public override string ToString() {
        return Id + ", " + Nome + ", $" + Salario.ToString("F2", CultureInfo.InvariantCulture);
    }
}
