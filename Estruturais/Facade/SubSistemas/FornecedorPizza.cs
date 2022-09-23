namespace Facade.SubSistemas
{
    public class FornecedorPizza : IPizza
    {
        public void ObterPizzaPortuguesa()
        {
            Console.WriteLine("Buscando pizza portuguesa");
        }

        public void ObterPizzaQueijo()
        {
            Console.WriteLine("Buscando pizza de queijo");
        }

        public void ObterPizzaVegana()
        {
            Console.WriteLine("Buscando pizza vegana");
        }
    }
}
