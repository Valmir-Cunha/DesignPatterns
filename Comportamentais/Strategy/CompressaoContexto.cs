namespace Strategy
{
    public class CompressaoContexto : ICompressor
    {
        ICompressor _compressor;
        public CompressaoContexto(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void DefinirCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void Comprimir(string arquivo)
        {
            _compressor.Comprimir(arquivo);
        }

    }
}
