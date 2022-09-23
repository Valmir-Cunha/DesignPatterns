using Proxy;

public class Program
{
    public static void Main()
    {
        Funcionario funcionario = new Funcionario(Cargo.Gestor);
        Funcionario funcionario2 = new Funcionario(Cargo.Programador);

        IServicoFinanceiro servicoFinanceiro = new FinanceiroProxy(funcionario);
        IServicoFinanceiro servicoFinanceiro2 = new FinanceiroProxy(funcionario2);
        Console.WriteLine("Gestor:");
        servicoFinanceiro.ObterRegistros();
        Console.WriteLine();
        Console.WriteLine("Programador:");
        servicoFinanceiro2.ObterRegistros();

    }
}