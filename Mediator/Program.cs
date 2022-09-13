namespace Mediator
{
    public class Program
    {
        public static void Main()
        {
            Mediator mediator = new Mediator();

            Vendedor vendedor = new Vendedor();
            vendedor.CadastrarProduto(new Produto(1, "Camisa",40m));
            vendedor.CadastrarProduto(new Produto(2, "Sapato", 50m));

            Vendedor vendedor1 = new Vendedor();
            vendedor1.CadastrarProduto(new Produto(3, "Xbox", 4000m));
            vendedor1.CadastrarProduto(new Produto(4, "PS5", 5000m));

            mediator.CadastrarVendedor(vendedor);
            mediator.CadastrarVendedor(vendedor1);

            Comprador comprador = new Comprador(mediator);

            mediator.ExibirProdutos();
            Console.WriteLine("----------------------------------");
            comprador.Comprar(1);
            comprador.Comprar(4);
            Console.WriteLine("----------------------------------");
            mediator.ExibirProdutos();

        }
    }
}