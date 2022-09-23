namespace Stage
{
    public class PedidoRejeitado : PedidoStatus
    {
        private Pedido _pedido;

        public PedidoRejeitado(Pedido pedido)
        {
            _pedido = pedido;
            Nome = "PedidoRejeitado";
        }
        public override void AprovarPagamento()
        {
            Console.WriteLine("Pedido foi rejeitado, não é possível aprova-lo");
        }
        public override void RejeitarPagamento()
        {
            Console.WriteLine("Pedido rejeitado");
        }
        public override void EsperarPagamento()
        {
            Console.WriteLine("Pedido foi rejeitado, não é possível esperar");
        }
        public override void EnviarPedido()
        {
            Console.WriteLine("Pedido foi rejeitado, não é possível enviar");
        }
    }
}
