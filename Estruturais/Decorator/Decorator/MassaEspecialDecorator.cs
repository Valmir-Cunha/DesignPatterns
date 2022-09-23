using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator.Decorator
{
    public class MassaEspecialDecorator : PizzaDecorator
    {
        public MassaEspecialDecorator(IPizza pizza) : base(pizza)
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
            TipoPizza += "\n Com massa especial";
            return TipoPizza;
        }
    }
}
