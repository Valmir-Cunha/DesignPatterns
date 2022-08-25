using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public class AtendenteFactory : FuncionarioFactory
    {
        string _nome;
        int _idade;
        decimal _salario;
        string _descricao;

        public AtendenteFactory(string nome, int idade, decimal salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override Funcionario CriarFuncionario()
        {
            return new Atendente(_nome,_idade, _salario, _descricao);
        }
    }
}
