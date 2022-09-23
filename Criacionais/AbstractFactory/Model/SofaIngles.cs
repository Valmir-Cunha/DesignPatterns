using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class SofaIngles : ISofa
    {
        public void Sentar()
        {
            Console.WriteLine("Sentou no sofá inglês...");
        }
    }
}
