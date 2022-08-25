using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class EstanteModerna : IEstante
    {
        public void Mobiliar()
        {
            Console.WriteLine("Mobiliou a estante moderna...");
        }
    }
}
