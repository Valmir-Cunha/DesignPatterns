namespace Stage
{
    public class PedidoAprovado : PedidoStatus
    {
        private Pedido _pedido;

        public PedidoAprovado(Pedido pedido)
        {
            _pedido = pedido;
            Nome = "PedidoAprovado";
        }
        public override void AprovarPagamento()
        {
            Console.WriteLine("Pedido já aprovado");
        }
        public override void RejeitarPagamento()
        {
            _pedido.Estado = new PedidoRejeitado(_pedido);
        }
        public override void EsperarPagamento()
        {
            _pedido.Estado = new PedidoPendente(_pedido);
        }
        public override void EnviarPedido()
        {
            Console.WriteLine("Pedido está sendo enviado");
        }
    }
}
