namespace FactoryMethod.Exemplos.Funcionario.Model
{
    public class Atendente : Funcionario
    {
        public Atendente(string nome, int idade, double salario, string descricao) : base(nome, idade, salario, descricao)
        {
        }

        public override void CalcularBonus()
        {
            Console.Write($"Salário com bônus: {_salario + (_salario * 0.05)}");
        }

        
    }
}
