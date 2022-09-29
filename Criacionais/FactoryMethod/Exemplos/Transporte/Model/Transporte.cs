namespace FactoryMethod.Exemplos.Transporte.Model
{
    public abstract class Transporte
    {
        protected string _descricao;
        protected int _anoFabricacao;

        public abstract void Entregar(string pacote);
    }
}
