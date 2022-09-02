namespace Bridge.Implementacao
{
    public class Radio : IDispositivo 
    {
        private int _volumeTemporario;
        private int _volume;
        private int _canal;

        public int Volume
        {
            get => _volume;
        }
        public int Canal
        {
            get => _canal;
        }

        public void AumentarCanal()
        {
            _canal++;
        }

        public void AumentarVolume()
        {
            _volume++;
        }

        public void Desmutar()
        {
            _volumeTemporario = _volume;
            _volume = 0;
        }

        public void DiminuirCanal()
        {
            _canal--;
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
    }
}
