namespace TemplateMethod
{
    public abstract class VideoPlayer
    {
        //Template Method
        public void ExecutarVideo()
        {
            CarregarArquivo();
            DecodificarVideo();
            IniciarVideo();
        }


        public void CarregarArquivo()
        {
            Console.WriteLine("Arquivo de video carregado");
        }

        public abstract void DecodificarVideo();

        public void IniciarVideo()
        {
            Console.WriteLine("Video iniciado");
        }
    }
}
