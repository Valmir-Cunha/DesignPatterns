using FactoryMethod.Exemplos.Funcionario.Model;

namespace FactoryMethod.Exemplos.Funcionario.Factories
{
    public class AtendenteFactory : FuncionarioFactory
    {
        public override Model.Funcionario CriarFuncionario(string nome, int idade, double salario, string descricao)
        {
            return new Atendente(nome, idade, salario, descricao);
        }
    }
}
