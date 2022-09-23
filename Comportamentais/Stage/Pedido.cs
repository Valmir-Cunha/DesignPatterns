namespace Stage
{
    public class Pedido
    {
        PedidoStatus _estado;

        public PedidoStatus Estado
        {
            get => _estado;
            set
            {
                _estado = value;
                NomeEstado();
            }
        }

        public Pedido()
        {
            _estado = new PedidoPendente(this);
        }

        public void NomeEstado()
        {
            Console.WriteLine($"O estado desse pedido é {_estado.Nome}");
        }

        public void AprovarPagamento()
        {
            _estado.AprovarPagamento();
        }
        public void RejeitarPagamento()
        {
            _estado.RejeitarPagamento();
        }
        public void EsperarPagamento()
        {
            _estado.EsperarPagamento();
        }
        public void EnviarPedido()
        {
            _estado.EnviarPedido();
        }
    }
}
