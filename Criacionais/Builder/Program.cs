using Builder.Builder;

public class Program
{
    public static void Main()
    {
        Diretor diretor = new Diretor();
        Console.WriteLine("-------------------------------CARRO-------------------------------------------------------------");
        VeiculoBuilder veiculoBuilder = new CarroBuilder();
        diretor.DefinirBuilder(veiculoBuilder);       
        Console.WriteLine("-------------------------------Sem GPS-------------------------------------------------------------");
        diretor.CriarVeiculoSemGPS();
        veiculoBuilder.ImprimirInfo();
        veiculoBuilder.Resetar();
        Console.WriteLine("-------------------------------Com GPS-------------------------------------------------------------");
        diretor.CriarVeiculoComGPS();
        veiculoBuilder.ImprimirInfo();

        Console.WriteLine("-------------------------------MOTO-------------------------------------------------------------");
        veiculoBuilder = new MotoBuilder();
        diretor.DefinirBuilder(veiculoBuilder);
        Console.WriteLine("-------------------------------Sem GPS-------------------------------------------------------------");
        diretor.CriarVeiculoSemGPS();
        veiculoBuilder.ImprimirInfo();
        veiculoBuilder.Resetar();
        Console.WriteLine("-------------------------------Com GPS-------------------------------------------------------------");
        diretor.CriarVeiculoComGPS();
        veiculoBuilder.ImprimirInfo();
        veiculoBuilder.Resetar();
    }
}