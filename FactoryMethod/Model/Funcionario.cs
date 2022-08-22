using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public abstract class Funcionario
    {
        string _nome;
        int _idade;
        decimal _salario;

        public Funcionario (string nome, int idade, decimal salario)
        {
            _nome=nome;
            _idade=idade;
            _salario=salario;
        }
    }
}
