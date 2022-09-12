namespace Strategy
{
    public class CompressaoRar : ICompressor
    {
        public void Comprimir(string arquivo)
        {
            Console.WriteLine($"O arquivo {arquivo} foi comprimido no formato Rar");
        }
    }
}
