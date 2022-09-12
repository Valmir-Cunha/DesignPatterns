using Command.Receptores;

namespace Command.Commands
{
    public class LigarTelevisaoCommand : ICommand
    {
        private readonly TelevisaoSmart _televisaoSmart;
        public LigarTelevisaoCommand(TelevisaoSmart televisaoSmart)
        {
            _televisaoSmart = televisaoSmart;
        }

        public void Execute()
        {
            _televisaoSmart.Ligar();
        }

        public void Undo()
        {
            _televisaoSmart.Desligar();
        }
    }
}
