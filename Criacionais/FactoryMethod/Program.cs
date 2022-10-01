using FactoryMethod.Exemplos.Funcionario.Factories;
using FactoryMethod.Exemplos.Funcionario.Model;
using FactoryMethod.Exemplos.Transporte.Factories;
using FactoryMethod.Exemplos.Transporte.Model;

public class Program
{
    public static void Main()
    {
        TransporteFactory  transporteFactory = null;
        Transporte transporte = null;
        string pacote = "N° 2893741892";
        Console.WriteLine("Digite o código do tipo de transporte que deseja utilizar no envio:");
        Console.WriteLine("1 - Caminhão | 2 - Avião");
        string codigo = Console.ReadLine();
        switch (codigo)
        {
            case "1":
                transporteFactory = new CaminhaoFactory();
                transporte = transporteFactory.CriarTransporte("Modelo X", 2015); 
                
                break;
            case "2":
                transporteFactory = new AviaoFactory();
                transporte = transporteFactory.CriarTransporte("Modelo Y", 2016); 
                break;
        }

        transporte?.Entregar(pacote);
    }

    public static void ExemploFuncionarios()
    {
        FuncionarioFactory funcionarioFactory = null;
        Funcionario funcionario = null;
        Console.WriteLine("Digite o código do tipo de funcionário que deseja criar:");
        Console.WriteLine("1 - Gerente | 2 - Atendente");
        string codigo = Console.ReadLine();
        switch (codigo)
        {
            case "1":
                funcionarioFactory = new GerenteFactory();
                funcionario = funcionarioFactory.CriarFuncionario("Fulano", 35, 5000, "Gerente");
                break;
            case "2":
                funcionarioFactory = new AtendenteFactory();
                funcionario = funcionarioFactory.CriarFuncionario("Beutrano", 20, 2000, "Atendente");
                break;
        }
        funcionario?.Info();
        funcionario?.CalcularBonus();
    }
}