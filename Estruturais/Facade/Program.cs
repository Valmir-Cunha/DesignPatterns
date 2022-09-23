using Facade;

public class Program
{
    public static void Main()
    {
        PizzariaFacade facade = new PizzariaFacade();
        Console.WriteLine("-------------Pedidos-----------");
        Console.WriteLine("Pedido 1:");
        facade.BuscarPizzaVegana();
        Console.WriteLine("Pedido 2:");
        facade.BuscarPizzaQueijo();
        Console.WriteLine("Pedido 3:");
        facade.BuscaCervejaOriginal();
        Console.WriteLine("Pedido 4:");
        facade.BuscarPizzaPortuguesaComCocaCola();

    }
}