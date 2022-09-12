using Command.Commands;
using Command.Invoker;
using Command.Receptores;

namespace Command
{
    public class Program
    {
        public static void Main()
        {
            // Receiver
            LuzSmart luzSmart = new LuzSmart();
            TelevisaoSmart televisaoSmart = new TelevisaoSmart();

            //Commands
            LigarLuzCommand ligarLuzCommand = new LigarLuzCommand(luzSmart);
            LigarTelevisaoCommand ligarTelevisaoCommand = new LigarTelevisaoCommand(televisaoSmart);

            //Invoker
            CasaApp casaApp = new CasaApp();

            casaApp.AdicionarCommand(ligarLuzCommand);
            casaApp.AdicionarCommand(ligarTelevisaoCommand);

            casaApp.ExecuteCommand(0);
            casaApp.ExecuteCommand(1);
            casaApp.UndoCommand(0);
        }
    }
}