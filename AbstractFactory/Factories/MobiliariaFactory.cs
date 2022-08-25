using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public abstract class MobiliariaFactory
    {
        public abstract ICadeira CriarCadeira();
        public abstract ISofa CriarSofa();
        public abstract IEstante CriarEstante();
    }
}
