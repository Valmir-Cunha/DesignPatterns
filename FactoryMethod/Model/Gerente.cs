namespace FactoryMethod.Model
{
    public class Gerente : Funcionario
    {
        public Gerente (string nome, int idade, int salario) : base(nome, idade, salario)
        {
        }
    }
}
