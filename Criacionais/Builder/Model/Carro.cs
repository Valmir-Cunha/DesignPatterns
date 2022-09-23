namespace Builder.Model
{
    public class Carro : Veiculo
    {
        public override void AdicionarComponente(string componente)
        {

            componentes.Add(componente);
        }

        public override void ListaComponentes()
        {
            Console.WriteLine("Componentes presentes no carro:");
            foreach (var componente in componentes)
            {
                Console.WriteLine(componente);
            }
        }
    }
}
