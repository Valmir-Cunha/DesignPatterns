using FactoryMethod.Exemplos.Transporte.Model;

namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public class AviaoFactory : TransporteFactory
    {
        public override Model.Transporte CriarTransporte(string descricao, int anoFabricacao)
        {
            return new Aviao(descricao, anoFabricacao);
        }
    }
}
