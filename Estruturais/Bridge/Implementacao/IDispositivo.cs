namespace Bridge.Implementacao
{
    public interface IDispositivo
    {
        int Volume { get; }
        void DiminuirVolume();
        void AumentarVolume();
        void AumentarCanal();
        void DiminuirCanal();
        void Mutar();
        void Desmutar();
    }
}