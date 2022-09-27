using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public class CaminhaoFactory : TransporteFactory
    {
        public CaminhaoFactory(string descricao, int anoFabricacao) : base(descricao, anoFabricacao)
        {
        }

        public override Transporte CriarTransporte()
        {
            return new Caminhao(_descricao,_anoFabricacao);
        }
    }
}
