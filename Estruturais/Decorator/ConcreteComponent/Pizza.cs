using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class Pizza : IPizza
    {
        public decimal Preco()
        {
            return 30m;
        }

        public string TipoPizza()
        {
            return "Pizza normal com queijo";
        }
    }
}
