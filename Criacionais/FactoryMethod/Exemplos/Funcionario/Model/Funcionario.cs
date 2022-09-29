namespace FactoryMethod.Exemplos.Funcionario.Model
{
    public abstract class Funcionario
    {
        protected string _nome;
        protected int _idade;
        protected double _salario;
        protected string _descricao;

        public Funcionario(string nome, int idade, double salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public void Info()
        {
            Console.WriteLine($"Nome: {_nome} \nIdade: {_idade}\nSalario base: {_salario} \nFunção: {_descricao}");
        }

        public abstract void CalcularBonus();

    }
}
