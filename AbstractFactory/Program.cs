using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

public class Program
{
    public static void Main()
    {
        MobiliariaFactory mobiliariaFactory = null;
        ICadeira cadeira = null;
        IEstante estante = null;
        ISofa sofa = null;
        Console.WriteLine("Digite o modelo de sala desejado: ");
        Console.WriteLine("1 - Inglesa | 2 - Moderna ");
        string tipo = Console.ReadLine();
        switch (tipo)
        {
            case "1":
                mobiliariaFactory = new MobiliariaInglesaFactory();
                cadeira = mobiliariaFactory.CriarCadeira();
                sofa = mobiliariaFactory.CriarSofa();
                estante = mobiliariaFactory.CriarEstante();
                cadeira.Sentar();
                sofa.Sentar();
                estante.Mobiliar();
                break;
            case "2":
                mobiliariaFactory= new MobiliariaModernaFactory();
                cadeira = mobiliariaFactory.CriarCadeira();
                sofa = mobiliariaFactory.CriarSofa();
                estante = mobiliariaFactory.CriarEstante();
                cadeira.Sentar();
                sofa.Sentar();
                estante.Mobiliar();
                break;
        }
    }
}