using AbstractFactory.Interfaces;

namespace AbstractFactory.Model
{
    public class CadeiraModerna : ICadeira
    {
        public void Sentar()
        {
            Console.WriteLine("Sentou na cadeira moderna...");
        }
    }
}
