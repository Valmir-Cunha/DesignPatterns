namespace TemplateMethod
{
    public class VideoMP4 : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("O video está sendo processado por um decodificar MP4");
        }
    }
}
