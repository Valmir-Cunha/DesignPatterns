namespace Strategy
{
    public class CompressaoZip : ICompressor
    {
        public void Comprimir(string arquivo)
        {
            Console.WriteLine($"O arquivo {arquivo} foi comprimido no formato Zip");
        }
    }
}
