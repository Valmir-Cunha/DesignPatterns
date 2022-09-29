namespace FactoryMethod.Exemplos.Funcionario.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario, string descricao)
        {
            _nome = nome;
            _idade = idade;
            _salario = salario;
            _descricao = descricao;
        }

        public override void CalcularBonus()
        {
            Console.Write($"Salário com bônus: {_salario + (_salario * 0.10)}");
        }
    }
}
