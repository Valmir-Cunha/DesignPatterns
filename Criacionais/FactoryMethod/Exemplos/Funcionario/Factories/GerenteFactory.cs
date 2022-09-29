using FactoryMethod.Exemplos.Funcionario.Model;

namespace FactoryMethod.Exemplos.Funcionario.Factories
{
    public class GerenteFactory : FuncionarioFactory
    {
        public override Model.Funcionario CriarFuncionario(string nome, int idade, double salario, string descricao)
        {
            return new Gerente(nome, idade, salario, descricao);
        }
    }
}
