using Builder.Model;

namespace Builder.Builder
{
    public class CarroBuilder : VeiculoBuilder
    {
        private Carro _carro;

        public CarroBuilder()
        {
            Resetar();
        }

        public override void Resetar()
        {
            _carro = new Carro();
        }

        public override void AdicionarAssentos()
        {
            _carro.AdicionarComponente("4 assentos");
        }

        public override void AdicionarControladorDeDirecao()
        {
            _carro.AdicionarComponente("Volante");
        }

        public override void AdicionarControleDeBordo()
        {
            _carro.AdicionarComponente("Controle de bordo");
        }

        public override void AdicionarGPS()
        {
            _carro.AdicionarComponente("GPS");
        }

        public override void AdicionarPneus()
        {
            _carro.AdicionarComponente("4 pneus");
        }
        
        public override void ImprimirInfo()
        {
            _carro.ListaComponentes();
        }
    }
}
