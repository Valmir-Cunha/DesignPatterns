namespace ChainOfResponsibility
{
    public abstract class Autorizador
    {
        protected Autorizador _autorizador;

        public Autorizador AddProximoAutorizador(Autorizador autorizador)
        {
            _autorizador = autorizador;
            return _autorizador;
        }

        public abstract void AprovarProjeto(string nome, decimal orcamento);
    }
}
