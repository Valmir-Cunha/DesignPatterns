using Builder.Model;

namespace Builder.Builder
{
    public abstract class VeiculoBuilder
    {
        public abstract void Resetar();
        public abstract void AdicionarAssentos();
        public abstract void AdicionarPneus();
        public abstract void AdicionarGPS();
        public abstract void AdicionarControleDeBordo();
        public abstract void AdicionarControladorDeDirecao();
        public abstract void ImprimirInfo();
    }
}
