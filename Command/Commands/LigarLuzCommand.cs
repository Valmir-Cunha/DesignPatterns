using Command.Receptores;

namespace Command.Commands
{
    public class LigarLuzCommand : ICommand
    {
        private readonly LuzSmart _luzSmart;
        public LigarLuzCommand(LuzSmart luzSmart)
        {
            _luzSmart = luzSmart;
        }

        public void Execute()
        {
            _luzSmart.Ligar();
        }

        public void Undo()
        {
            _luzSmart.Desligar();
        }
    }
}
