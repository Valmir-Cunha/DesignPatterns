using Bridge.Implementacao;

namespace Bridge.Abstracao
{
    public  class Controle
    {
        protected IDispositivo dispositivo;

        public Controle(IDispositivo dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        public void AumentarVolume()
        {
            dispositivo.AumentarVolume();
        }

        public void DiminuirVolume()
        {
            dispositivo.DiminuirVolume();
        }

        public void AumentarCanal()
        {
            dispositivo.AumentarCanal();
        }

        public void DiminuirCanal()
        {
            dispositivo.DiminuirCanal();
        }
    }
}
