namespace FactoryMethod.Exemplos.Transporte.Model
{
    public class Aviao : Transporte
    {
        public Aviao(string descricao, int fabricacao)
        {
            _descricao = descricao;
            _anoFabricacao = fabricacao;
        }

        public override void Entregar(string pacote)
        {
            Console.WriteLine($"O pacote {pacote} será transportado por um avião modelo {_descricao}");
        }
    }
}
