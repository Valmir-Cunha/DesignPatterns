namespace Command.Receptores
{
    public class TelevisaoSmart
    {
        bool _ligada = false;

        public bool Ligada { get => _ligada; }

        public void Ligar()
        {
            _ligada = true;
            Console.WriteLine("TV ligada");
        }

        public void Desligar()
        {
            _ligada = false;
            Console.WriteLine("TV desligada");
        }
    }
}
