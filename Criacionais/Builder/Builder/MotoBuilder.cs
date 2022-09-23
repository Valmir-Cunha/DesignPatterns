using Builder.Model;

namespace Builder.Builder
{
    public class MotoBuilder : VeiculoBuilder
    {
        private Moto _moto;

        public MotoBuilder()
        {
            Resetar();
        }

        public override void Resetar()
        {
            _moto = new Moto();
        }

        public override void AdicionarAssentos()
        {
            _moto.AdicionarComponente("2 assentos");
        }

        public override void AdicionarControladorDeDirecao()
        {
            _moto.AdicionarComponente("Guidão");
        }

        public override void AdicionarControleDeBordo()
        {
            _moto.AdicionarComponente("Painel");
        }

        public override void AdicionarGPS()
        {
            _moto.AdicionarComponente("GPS");
        }

        public override void AdicionarPneus()
        {
            _moto.AdicionarComponente("2 Pneus");
        }
        public override void ImprimirInfo()
        {
            _moto.ListaComponentes();
        }
    }
}
