namespace Stage
{
    public class Program
    {
        public static void Main()
        {
            Pedido pedido = new Pedido();
            pedido.AprovarPagamento();
            pedido.EnviarPedido();
            
            pedido.EsperarPagamento();
            pedido.RejeitarPagamento();
            pedido.EnviarPedido();
            pedido.AprovarPagamento();
        }
    }
}