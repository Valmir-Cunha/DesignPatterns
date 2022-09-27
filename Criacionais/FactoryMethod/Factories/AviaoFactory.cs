using FactoryMethod.Model;

namespace FactoryMethod.Factories
{
    public class AviaoFactory : TransporteFactory
    {
        public AviaoFactory(string descricao, int anoFabricacao) : base(descricao, anoFabricacao)
        {
        }

        public override Transporte CriarTransporte()
        {
            return new Aviao(_descricao,_anoFabricacao);
        }
    }
}
