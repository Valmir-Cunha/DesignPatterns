using AbstractFactory.Interfaces;
using AbstractFactory.Model;

namespace AbstractFactory.Factories
{
    public class MobiliariaModernaFactory : MobiliariaFactory
    {
        public override ICadeira CriarCadeira()
        {
            return new CadeiraModerna();
        }

        public override IEstante CriarEstante()
        {
            return new EstanteModerna();
        }

        public override ISofa CriarSofa()
        {
            return new SofaModerno();
        }
    }
}
