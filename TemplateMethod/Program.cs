namespace TemplateMethod
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------------Player MP4------------------");
            VideoPlayer player = new VideoMP4();
            player.ExecutarVideo();

            Console.WriteLine("------------------Player MKV------------------");
            player = new VideoMKV();
            player.ExecutarVideo();
        }
    }

}