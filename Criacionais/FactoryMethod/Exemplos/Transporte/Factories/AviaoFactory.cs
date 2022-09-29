using FactoryMethod.Exemplos.Transporte.Model;

namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public class AviaoFactory : TransporteFactory
    {
        public AviaoFactory(string descricao, int anoFabricacao) : base(descricao, anoFabricacao)
        {
        }

        public override Model.Transporte CriarTransporte()
        {
            return new Aviao(_descricao,_anoFabricacao);
        }
    }
}
