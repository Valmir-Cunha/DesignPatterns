namespace Observer
{
    public class Program
    {
        public static void Main()
        {
            Produto produto = new Produto(0,"PS5");
            Cliente cliente1 = new Cliente("Julio");
            Cliente cliente2 = new Cliente("Guilherme");
            Cliente cliente3 = new Cliente("Vinicius");

            produto.RegistrarObserver(cliente1);
            produto.RegistrarObserver(cliente2);
            produto.RegistrarObserver(cliente3);

            produto.Estoque = 10;


        }
    }
}