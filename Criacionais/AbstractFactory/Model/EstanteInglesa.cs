using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class EstanteInglesa : IEstante
    {
        public void Mobiliar()
        {
            Console.WriteLine("Mobiliou a estante inglesa...");
        }
    }
}
