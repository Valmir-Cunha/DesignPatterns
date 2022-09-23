namespace Command.Invoker
{
    public class CasaApp
    {
        List<ICommand> _commands;

        public CasaApp()
        {
            _commands = new List<ICommand>();
        }

        public void AdicionarCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommand(int chave)
        {
            _commands[chave].Execute();
        }

        public void UndoCommand(int chave)
        {
            _commands[chave].Undo();
        }
    }
}
