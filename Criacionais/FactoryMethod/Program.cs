using FactoryMethod.Factories;
using FactoryMethod.Model;

public class Program
{
    public static void Main()
    {
        FuncionarioFactory funcionarioFactory = null;
        Console.WriteLine("Digite o código do tipo de funcionário que deseja criar:");
        Console.WriteLine("1 - Gerente | 2 - Atendente");
        string codigo = Console.ReadLine();
        switch (codigo)
        {
            case "1":
                funcionarioFactory = new GerenteFactory("Fulano", 35, 5000, "Gerente");
                
                break;
            case "2":
                funcionarioFactory = new AtendenteFactory("Beutrano", 20, 2000, "Atendente");
                break;
        }
        Funcionario funcionario = funcionarioFactory.CriarFuncionario();
        funcionario.Info();
        funcionario.CalcularBonus();


    }
}