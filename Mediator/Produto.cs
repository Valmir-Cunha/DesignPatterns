namespace Mediator
{
    public class Produto
    {
        int _id;
        string _nome;
        decimal _preco;

        public int Id { get => _id; set { _id = value; } }
        public string Nome { get => _nome; set { _nome = value; } }
        public decimal Preco { get => _preco; set { _preco = value; } }

        public Produto(int id, string nome, decimal preco)
        {
            _id=id;
            _nome=nome;
            _preco=preco;
        }
    }
}
