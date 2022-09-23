
// Classe adapter que impementa a interface do usuário
namespace Adapter
{
    public class ValidacoesUsuarioAdapter : IValidacoesUsuario
    {
        private ServicoExternoValidacao servicoExterno;

        public ValidacoesUsuarioAdapter(ServicoExternoValidacao servicoExterno)
        {
            this.servicoExterno=servicoExterno;
        }

        public bool ValidarEmail(string email)
        {
            return servicoExterno.EmailIsOk(email);
        }
    }
}
