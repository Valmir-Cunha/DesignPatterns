namespace TemplateMethod
{
    public class VideoMKV : VideoPlayer
    {
        public override void DecodificarVideo()
        {
            Console.WriteLine("O video está sendo processado por um decodificar MKV");
        }
    }
}
