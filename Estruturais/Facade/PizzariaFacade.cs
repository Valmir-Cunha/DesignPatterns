using Facade.SubSistemas;

namespace Facade
{
    public class PizzariaFacade
    {
        private IPizza _fornecedorPizza;
        private IBebidas _fornecedorBebidas;

        public PizzariaFacade()
        {
            _fornecedorBebidas = new FornecedorBebidas();
            _fornecedorPizza = new FornecedorPizza();
        }

        public void BuscaCervejaOriginal()
        {
            _fornecedorBebidas.ObterCervejaOriginal();
        }

        public void BuscaCervejaSkol()
        {
            _fornecedorBebidas.ObterCervejaSkol();
        }

        public void BuscarRefrigeranteCocaCola()
        {
            _fornecedorBebidas.ObterRefrigeranteCocaCola();
        }

        public void BuscarRefrigeranteGuarana()
        {
            _fornecedorBebidas.ObterRefrigeranteGuarana();
        }

        public void BuscarPizzaPortuguesa()
        {
            _fornecedorPizza.ObterPizzaPortuguesa();
        }

        public void BuscarPizzaQueijo()
        {
            _fornecedorPizza.ObterPizzaQueijo();
        }

        public void BuscarPizzaVegana()
        {
            _fornecedorPizza.ObterPizzaVegana();
        }

        public void BuscarPizzaPortuguesaComCocaCola()
        {
            _fornecedorPizza.ObterPizzaPortuguesa();
            _fornecedorBebidas.ObterRefrigeranteCocaCola();
        }

    }
}
