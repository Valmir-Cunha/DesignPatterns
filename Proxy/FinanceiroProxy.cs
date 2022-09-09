namespace Proxy
{
    public class FinanceiroProxy : IServicoFinanceiro
    {
        Financeiro _financeiro;
        Funcionario _funcionario;

        public FinanceiroProxy(Funcionario funcionario)
        {
            _financeiro = new Financeiro();
            _funcionario=funcionario;
        }

        public void ObterRegistros()
        {
            if(_funcionario._cargo != Cargo.Gestor)
            {
                Console.WriteLine("Você não possui acesso aos registros financeiros");
            }
            else
            {
                _financeiro.ObterRegistros();
            }

        }
    }
}
