namespace FactoryMethod.Model
{
    public abstract class Funcionario
    {
        public abstract string Nome { get; set; }
        public abstract int Idade { get; set; }
        public abstract decimal Salario { get; set; }
        public abstract string Descricao { get; set; }

        public void Info()
        {
            Console.WriteLine($"Nome: {Nome} \nIdade: {Idade}\nSalario: {Salario} \nFunção: {Descricao}");
        }

    }
}
