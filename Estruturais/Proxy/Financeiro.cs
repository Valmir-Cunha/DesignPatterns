namespace Proxy
{
    public class Financeiro : IServicoFinanceiro
    {
        public void ObterRegistros()
        {
            Console.WriteLine("Retornando registros financeiros");
        }
    }
}
