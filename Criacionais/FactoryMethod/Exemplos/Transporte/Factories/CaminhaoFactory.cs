using FactoryMethod.Exemplos.Transporte.Model;

namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public class CaminhaoFactory : TransporteFactory
    {
        public CaminhaoFactory(string descricao, int anoFabricacao) : base(descricao, anoFabricacao)
        {
        }

        public override Model.Transporte CriarTransporte()
        {
            return new Caminhao(_descricao,_anoFabricacao);
        }
    }
}
