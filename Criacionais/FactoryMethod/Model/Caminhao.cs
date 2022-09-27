namespace FactoryMethod.Model
{
    public class Caminhao : Transporte
    {
        public Caminhao(string descricao, int fabricacao)
        {
            _descricao = descricao;
            _anoFabricacao = fabricacao;
        }
        public override void Entregar(string pacote)
        {
            Console.WriteLine($"O pacote {pacote} será transportado por um caminhao modelo {_descricao}");
        }
    }
}
