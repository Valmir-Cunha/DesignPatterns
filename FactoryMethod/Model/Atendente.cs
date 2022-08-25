using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public class Atendente : Funcionario
    {
        string _nome;
        int _idade;
        decimal _salario;
        string _descricao;

        public Atendente(string nome, int idade, decimal salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override string Nome { get => _nome; set => _nome = value; }
        public override int Idade { get => _idade; set => _idade = value; }
        public override decimal Salario { get => _salario; set => _salario = value; }
        public override string Descricao { get => _descricao; set => _descricao = value; }
    }
}
