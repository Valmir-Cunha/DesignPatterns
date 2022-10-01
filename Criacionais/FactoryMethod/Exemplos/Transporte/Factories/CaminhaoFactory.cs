using FactoryMethod.Exemplos.Transporte.Model;

namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public class CaminhaoFactory : TransporteFactory
    {
        public override Model.Transporte CriarTransporte(string descricao, int anoFabricacao)
        {
            return new Caminhao(descricao, anoFabricacao);
        }
    }
}
