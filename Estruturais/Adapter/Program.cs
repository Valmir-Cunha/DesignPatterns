using Adapter;

public class Program
{
    public static void Main()
    {
        ServicoExternoValidacao servicoExternoValidacao = new ServicoExternoValidacao();
        IValidacoesUsuario validacoesUsuario = new ValidacoesUsuarioAdapter(servicoExternoValidacao);
        string email = "fulano@gmail.com";
        Console.WriteLine(validacoesUsuario.ValidarEmail(email));
    }
}