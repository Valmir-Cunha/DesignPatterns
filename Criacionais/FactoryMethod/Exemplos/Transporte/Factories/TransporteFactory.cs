namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public abstract class TransporteFactory
    {
        public abstract Model.Transporte CriarTransporte(string descricao, int anoFabricacao);
    }
}
