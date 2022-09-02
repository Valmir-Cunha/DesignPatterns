using Composite.Component;
using Composite.Leaf;

namespace Composite.Composite
{
    public class Caixa : Item
    {
        List<Item> _produtos;

        public Caixa()
        {
            _produtos = new List<Item>();
        }

        public decimal GetValor()
        {
            return _produtos.Select(p => p.GetValor()).Sum();
        }

        public void Adicionar(Item item)
        {
            _produtos.Add(item);
        }
    }
}
