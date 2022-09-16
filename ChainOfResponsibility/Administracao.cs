namespace ChainOfResponsibility
{
    public class Administracao : Autorizador
    {

        public override void AprovarProjeto(string nome, decimal orcamento)
        {
            if (orcamento < 50000)
            {
                Console.WriteLine($"O projeto {nome} de custo {orcamento} foi aprovado pela administração");
            }
            else
            {
                Console.WriteLine($"O projeto {nome} de custo {orcamento} foi negado por falta de recursos");
            }
        }
    }
}
