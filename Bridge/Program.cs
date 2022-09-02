using Bridge.Abstracao;
using Bridge.Implementacao;

public class Program
{
    public static void Main()
    {
        Televisao televisao = new Televisao();
        ControleRemoto controle = new ControleRemoto(televisao);

        Console.WriteLine("Canal: {0}", televisao.Canal);
        controle.AumentarCanal();
        controle.AumentarCanal();
        controle.AumentarCanal();
        controle.AumentarCanal();
        controle.AumentarCanal();
        Console.WriteLine("Canal: {0}", televisao.Canal);
        controle.DiminuirCanal();
        controle.DiminuirCanal();
        Console.WriteLine("Canal: {0}", televisao.Canal);

        Console.WriteLine("========================================================");

        Console.WriteLine("Volume: {0}", televisao.Volume);
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        controle.AumentarVolume();
        Console.WriteLine("Volume: {0}",televisao.Volume);
        Console.WriteLine("Mutando televisão:");
        controle.MutarDesmutar();
        Console.WriteLine("Volume: {0}", televisao.Volume);
        Console.WriteLine("Desmutando televisão:");
        controle.MutarDesmutar();
        Console.WriteLine("Volume: {0}", televisao.Volume);

    }
}