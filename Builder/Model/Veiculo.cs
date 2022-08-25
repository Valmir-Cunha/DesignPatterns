namespace Builder.Model
{
    public abstract class Veiculo
    {
        protected List<object> componentes = new List<object>();

        public abstract void AdicionarComponente(string componente);
        public abstract void ListaComponentes();
    }
}
