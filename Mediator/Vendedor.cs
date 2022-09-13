namespace Mediator
{
    public class Vendedor
    {
        List<Produto> _produtos;
        Mediator _mediator;

        public Vendedor()
        {
            _produtos = new List<Produto>();
        }

        public void CadastrarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            foreach (var produto in _produtos)
            {
                Console.WriteLine($"Id: {produto.Id} | Nome: {produto.Nome} | Preço: {produto.Preco}");
            }
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public Produto Vender(int id)
        {
            var produto = _produtos.Find(x => x.Id == id);
            _produtos.Remove(produto);
            return produto;
        }
    }
}
