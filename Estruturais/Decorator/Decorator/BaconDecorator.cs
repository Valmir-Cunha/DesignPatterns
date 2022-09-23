using Decorator.Component;
using Decorator.ConcreteDecorator;

namespace Decorator.Decorator
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4m;
            return preco;
        }

        public override string TipoPizza()
        {
            var TipoPizza = base.TipoPizza();
            TipoPizza += "\n Com bacon";
            return TipoPizza;
        }
    }
}
