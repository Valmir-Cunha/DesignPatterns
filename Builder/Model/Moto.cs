namespace Builder.Model
{
    public class Moto : Veiculo
    {
        public override void AdicionarComponente(string componente)
        {
            
            componentes.Add(componente);
        }

        public override void ListaComponentes()
        {
            Console.WriteLine("Componentes presentes na moto:");
            foreach (var componente in componentes)
            {
                Console.WriteLine(componente);
            }
        }
    }
}
