using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public abstract class FuncionarioFactory
    {
        protected string _nome;
        protected int _idade;
        protected double _salario;
        protected string _descricao;
        public abstract Funcionario CriarFuncionario();
    }
}
