namespace Command.Receptores
{
    public class LuzSmart
    {
        bool _ligada = false;

        public bool Ligada { get => _ligada; }

        public void Ligar()
        {
            _ligada = true;
            Console.WriteLine("Luz ligada");
        }

        public void Desligar()
        {
            _ligada = false;
            Console.WriteLine("Luz desligada");
        }

    }
}
