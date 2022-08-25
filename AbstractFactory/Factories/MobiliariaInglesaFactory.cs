using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Factories
{
    public class MobiliariaInglesaFactory : MobiliariaFactory
    {
        public override ICadeira CriarCadeira()
        {
            return new CadeiraInglesa();
        }

        public override IEstante CriarEstante()
        {
            return new EstanteInglesa();
        }

        public override ISofa CriarSofa()
        {
            return new SofaIngles();
        }
    }
}
