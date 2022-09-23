using Composite.Composite;
using Composite.Leaf;

public class Program
{
    public static void Main()
    {
        Caixa caixa = new Caixa();
        Caixa caixa2 = new Caixa();

        caixa.Adicionar(new Produto("P1", 15.0m));
        caixa.Adicionar(new Produto("P2", 20.0m));
        caixa.Adicionar(new Produto("P3", 5.0m));
        caixa.Adicionar(new Produto("P4", 10.0m));

        caixa2.Adicionar(new Produto("P5", 100.0m));
        caixa2.Adicionar(new Produto("P6", 150.0m));

        caixa.Adicionar(caixa2);
        Console.WriteLine(caixa.GetValor());
    }
}