namespace FactoryMethod.Exemplos.Transporte.Factories
{
    public abstract class TransporteFactory
    {
        protected string _descricao;
        protected int _anoFabricacao;

        public TransporteFactory(string descricao, int anoFabricacao)
        {
            _descricao=descricao;
            _anoFabricacao=anoFabricacao;
        }

        public abstract Model.Transporte CriarTransporte();
    }
}
