using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public class GerenteFactory : FuncionarioFactory
    {
        string _nome;
        int _idade;
        decimal _salario;
        string _descricao;

        public GerenteFactory(string nome, int idade, decimal salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override Funcionario CriarFuncionario()
        {
            return new Gerente(_nome, _idade, _salario, _descricao);
        }
    }
}
