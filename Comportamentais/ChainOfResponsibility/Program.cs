namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main()
        {
            Autorizador autorizador = new GerenteProjeto();
            autorizador.AddProximoAutorizador(new Administracao());
            autorizador.AprovarProjeto("Funcionalidade X", 2000m);
            autorizador.AprovarProjeto("Site web", 20000m);
            autorizador.AprovarProjeto("Produto X", 100000m);
        }
    }
}
