namespace FactoryMethod.Exemplos.Funcionario.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario, string descricao) : base(nome, idade, salario, descricao)
        {
        }

        public override void CalcularBonus()
        {
            Console.Write($"Salário com bônus: {_salario + (_salario * 0.10)}");
        }
    }
}
