namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            ClassePrototipo2 classePrototipo2 = new();
            classePrototipo2.Nome = "Original";
            classePrototipo2.Idade = 15;
            classePrototipo2.id = new ID(1000);

            Console.WriteLine("Original:");
            classePrototipo2.Exibir();

            //Copia por shallowcopy

            ClassePrototipo2 p2 = classePrototipo2.ShallowCopy();
            Console.WriteLine("ShallowCopy:");
            p2.Exibir();

            //Copia por deepcopy
            ClassePrototipo2 p3 = classePrototipo2.DeepCopy();
            Console.WriteLine("DeepCopy:");
            p3.Exibir();

            Console.WriteLine("Modificando valores....");

            classePrototipo2.Idade = 90;
            classePrototipo2.id.Id = 546;
            Console.WriteLine("Original modificado:");
            classePrototipo2.Exibir();

            //Modifica tipos referência
            Console.WriteLine("ShallowCopy:");
            p2.Exibir();

            Console.WriteLine("DeepCopy:");
            p3.Exibir();
        }
    }
}