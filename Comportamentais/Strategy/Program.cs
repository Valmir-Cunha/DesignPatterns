namespace Strategy
{
    public class Program
    {
        public static void Main()
        {
            CompressaoContexto compressaoContexto = new CompressaoContexto(new CompressaoZip());
            Console.WriteLine("Digite o nome do arquivo a ser comprimido:");
            var arquivo = Console.ReadLine();
            Console.WriteLine("Escolha o tipo de compressão:");
            Console.WriteLine("1 - Zip | 2 - Rar");
            var tipo = Convert.ToInt32(Console.ReadLine());
            if (tipo == 2)
            {
                compressaoContexto.DefinirCompressor(new CompressaoRar());
                compressaoContexto.Comprimir(arquivo);
            }
            else
            {
                compressaoContexto.Comprimir(arquivo);
            }
        }
    }

}