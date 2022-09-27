using FactoryMethod.ModelFuncionarios;

namespace FactoryMethod.FactoriesFuncionarios
{
    public class AtendenteFactory : FuncionarioFactory
    {
        public AtendenteFactory(string nome, int idade, double salario, string descricao)
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
