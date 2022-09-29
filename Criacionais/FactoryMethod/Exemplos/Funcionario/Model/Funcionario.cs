namespace FactoryMethod.Exemplos.Funcionario.Model
{
    public abstract class Funcionario
    {
        protected string _nome;
        protected int _idade;
        protected double _salario;
        protected string _descricao;

        public void Info()
        {
            Console.WriteLine($"Nome: {_nome} \nIdade: {_idade}\nSalario base: {_salario} \nFunção: {_descricao}");
        }

        public abstract void CalcularBonus();

    }
}
