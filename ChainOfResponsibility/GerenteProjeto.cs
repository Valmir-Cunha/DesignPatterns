namespace ChainOfResponsibility
{
    public class GerenteProjeto : Autorizador
    {
        public override void AprovarProjeto(string nome, decimal orcamento)
        {
            if(orcamento < 5000)
            {
                Console.WriteLine($"O projeto {nome} de custo {orcamento} foi aprovado pelo gerente de projetos");
            }
            else
            {
                Console.WriteLine($"O projeto {nome} de custo {orcamento} não pode ser aprovado pelo gerente de projetos, repassando para os seus superiores");
                _autorizador?.AprovarProjeto(nome,orcamento);
            }
        }
    }
}
