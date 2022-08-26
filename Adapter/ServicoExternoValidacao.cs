
//Essa classe é utilizada para representar a utilização de um serviço externo, incompatível com o código cliente. Por mais que não seja, pense que sim.

using System.ComponentModel.DataAnnotations;

namespace Adapter
{
    public class ServicoExternoValidacao
    {
        public bool EmailIsOk(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
            //Novamente, pense que essa clase pertence a um código externo
        }
    }
}
