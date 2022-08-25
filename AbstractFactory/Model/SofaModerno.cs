using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class SofaModerno : ISofa
    {
        public void Sentar()
        {
            Console.WriteLine("Sentou no sofá moderno...");
        }
    }
}
