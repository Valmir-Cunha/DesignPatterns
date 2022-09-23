namespace Facade.SubSistemas
{
    public class FornecedorBebidas : IBebidas
    {
        public void ObterCervejaOriginal()
        {
            Console.WriteLine("Buscando cerveja Original");
        }

        public void ObterCervejaSkol()
        {
            Console.WriteLine("Buscando cerveja Skol");
        }

        public void ObterRefrigeranteCocaCola()
        {
            Console.WriteLine("Buscando Coca-Cola");
        }

        public void ObterRefrigeranteGuarana()
        {
            Console.WriteLine("Buscando Guaraná");
        }
    }
}
