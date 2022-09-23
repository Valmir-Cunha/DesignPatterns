using Composite.Component;

namespace Composite.Leaf
{
    public class Produto : Item
    {
        string _nome;
        decimal _preco;

        public Produto(string nome, decimal preco)
        {
            _nome=nome;
            _preco=preco;
        }

        public decimal GetValor()
        {
            return _preco;
        }
    }
}
