namespace Prototype
{
    public class ClassePrototipo2
    {
        public string Nome;
        public int Idade;
        public ID id;

        public ClassePrototipo2 ShallowCopy()
        {
            return (ClassePrototipo2) this.MemberwiseClone(); //Método que realiza uma shallowcopy 
        }

        public ClassePrototipo2 DeepCopy()
        {
            ClassePrototipo2 clone = (ClassePrototipo2) this.MemberwiseClone();
            clone.Nome = "Protótipo clone";
            clone.Idade = 10;
            clone.id = id;
            return clone;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} / Idade: {Idade} / Id: {id.Id} \n");
        }
    }
}
