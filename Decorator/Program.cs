
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.Decorator;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Pediu uma pizza simples\n");
        IPizza pizza = new Pizza();
        Console.WriteLine(pizza.TipoPizza());

        Console.WriteLine("Pediu para adicionar bacon e massa especial\n");

        pizza = new BaconDecorator(pizza);
        pizza = new MassaEspecialDecorator(pizza);

        Console.WriteLine(pizza.TipoPizza());

        Console.WriteLine("Pediu para adicionar borda recheada\n");

        pizza = new BordaRecheadaDecorator(pizza);

        Console.WriteLine(pizza.TipoPizza());

        //Isso é possível graças a recursão

        /*
        BordaRechedaDecorator possui uma instância de pizza do tipo MassaEspecialDecorator;
        Dentro de MassaEspecialDecorator existe uma instância de pizza do tipo BaconDecorator;
        Dentro de BaconDecorator existe uma instância de pizza do tipo pizza;       
        */
    }
}