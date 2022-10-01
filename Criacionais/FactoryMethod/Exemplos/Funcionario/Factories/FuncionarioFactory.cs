namespace FactoryMethod.Exemplos.Funcionario.Factories
{
    public abstract class FuncionarioFactory
    {
        public abstract Model.Funcionario CriarFuncionario(string nome, int idade, double salario, string descricao);
    }
}
