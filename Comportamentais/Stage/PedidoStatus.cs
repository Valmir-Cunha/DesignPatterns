namespace Stage
{
    public abstract class PedidoStatus
    {
        private string _nome;

        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
            }
        }

        public virtual void AprovarPagamento() { }
        public virtual void RejeitarPagamento() { }
        public virtual void EsperarPagamento() { }
        public virtual void EnviarPedido() { }
    }
}
