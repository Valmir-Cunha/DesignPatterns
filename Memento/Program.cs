namespace Memento
{
    public class Program
    {
        public static void Main()
        {
            Acao acao = new Acao();
            acao.Estado = "play";
            Armazena armazena = new Armazena();
            armazena.Memento = acao.CriarMemento();
            acao.Estado = "pause";
            acao.RestaurarEstado(armazena.Memento);
        }
    }
}