namespace Bridge.Implementacao
{
    internal class Televisao : IDispositivo
    {
        private int _volume;
        private int _canal;
        private int _volumeTemporario;

        public int Volume
        {
            get => _volume;
        }

        public int Canal
        {
            get => _canal;
        }

        public Televisao()
        {
            _volume = 0;
            _canal = 1; 
        }

        public void AumentarVolume()
        {
            _volume++;
        }

        public void DiminuirVolume()
        {
            _volume--;
        }

        public void Mutar()
        {
            _volumeTemporario = _volume;
            _volume = 0;
        }
        public void Desmutar()
        {
            _volume = _volumeTemporario;
        }

        public void AumentarCanal()
        {
            _canal++;
        }

        public void DiminuirCanal()
        {
            _canal--;
        }
        public void MudarCanal(int canal)
        {
            _canal = canal;
        }
    }
}
