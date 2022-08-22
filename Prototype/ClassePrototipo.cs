namespace Prototype
{
    public class ClassePrototipo : IPrototype
    {
        private string _nome;
        private int _idade;

        public ClassePrototipo()
        {
           
        }

        public ClassePrototipo(ClassePrototipo classePrototipo)
        {
            _nome = classePrototipo._nome;
            _idade = classePrototipo._idade;
        }

        public IPrototype clonar()
        {
            return new ClassePrototipo(this);
        }
    }
}
