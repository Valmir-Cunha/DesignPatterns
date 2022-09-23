namespace Stage
{
    public class PedidoPendente : PedidoStatus
    {
        private Pedido _pedido;

        public PedidoPendente(Pedido pedido)
        {
            _pedido = pedido;
            Nome = "PedidoPendente";
        }

        public override void AprovarPagamento()
        {
            _pedido.Estado = new PedidoAprovado(_pedido);
        }
        public override void RejeitarPagamento()
        {
            _pedido.Estado = new PedidoRejeitado(_pedido);
        }
        public override void EsperarPagamento()
        {
            Console.WriteLine("O pedido já está no pagamento pendente");
        }
        public override void EnviarPedido()
        {
            Console.WriteLine("O pagamento está pendente, o pedido não será enviado");
        }
    }
}
