namespace Mediator
{
    public class Mediator
    {
        List<Vendedor> _vendedores;

        public Mediator()
        {
            _vendedores =  new List<Vendedor>();
        }

        public void CadastrarVendedor(Vendedor vendedor)
        {
            _vendedores.Add(vendedor);
        }

        public void Vender(int id)
        {
            Produto produto = null;
            for(int i = 0; i < _vendedores.Count;i++)
            {
                produto = _vendedores[i].Vender(id);
                if(produto != null)
                {
                    Console.WriteLine($"Vendeu o produto: ");
                    Console.WriteLine($"Id: {produto.Id} | Nome: {produto.Nome} | Preço: {produto.Preco}");
                    return;
                }
            }
        }

        public void ExibirProdutos()
        {
            for (int i = 0; i < _vendedores.Count; i++)
            {
                _vendedores[i].ListarProdutos();
            }
        }
    }
}
