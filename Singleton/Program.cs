namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            var i1 = Singleton.Instance;
            var i2 = Singleton.Instance;

            Console.WriteLine(i1 == i2);
        }
    }
}