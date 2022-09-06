using Decorator.Component;

namespace Decorator.ConcreteDecorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza=pizza;
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }

        public virtual string TipoPizza()
        {
            var TipoPizza = _pizza.TipoPizza();
            return TipoPizza;
        }
    }
}
