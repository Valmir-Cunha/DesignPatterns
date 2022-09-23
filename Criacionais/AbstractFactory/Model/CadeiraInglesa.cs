using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class CadeiraInglesa : ICadeira
    {
        public void Sentar()
        {
            Console.WriteLine("Sentou na cadeira inglesa...");
        }
    }
}
