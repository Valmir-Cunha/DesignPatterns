namespace Builder.Builder
{
    public class Diretor
    {
        VeiculoBuilder _veiculoBuilder;

        public void DefinirBuilder(VeiculoBuilder veiculoBuilder)
        {
            _veiculoBuilder = veiculoBuilder;
        }

        public void CriarVeiculoSemGPS()
        {
            _veiculoBuilder.AdicionarPneus();
            _veiculoBuilder.AdicionarAssentos();
            _veiculoBuilder.AdicionarControladorDeDirecao();
            _veiculoBuilder.AdicionarControleDeBordo();
        }

        public void CriarVeiculoComGPS()
        {
            _veiculoBuilder.AdicionarPneus();
            _veiculoBuilder.AdicionarAssentos();
            _veiculoBuilder.AdicionarControladorDeDirecao();
            _veiculoBuilder.AdicionarControleDeBordo();
            _veiculoBuilder.AdicionarGPS();
        }
    }
}
