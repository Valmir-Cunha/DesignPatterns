using Bridge.Implementacao;

namespace Bridge.Abstracao
{
    public class ControleRemoto : Controle
    {
        public ControleRemoto(IDispositivo dispositivo) : base(dispositivo)
        {
        }

        public void MutarDesmutar()
        {
            if (dispositivo.Volume == 0)
            {
                dispositivo.Desmutar();
            }
            else
            {
                dispositivo.Mutar();
            }
        }
    }
}
