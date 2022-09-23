using Decorator.Component;
using Decorator.ConcreteDecorator;

namespace Decorator.Decorator
{
    public class BordaRecheadaDecorator : PizzaDecorator
    {
        public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 5m;
            return preco;
        }

        public override string TipoPizza()
        {
            var TipoPizza = base.TipoPizza();
            TipoPizza += "\n Com borda recheada";
            return TipoPizza;
        }
    }
}
