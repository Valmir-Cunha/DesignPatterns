using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public class Atendente : Funcionario
    {
        public Atendente (string nome, int idade, decimal salario) : base(nome, idade, salario)
        {
        }
    }
}
