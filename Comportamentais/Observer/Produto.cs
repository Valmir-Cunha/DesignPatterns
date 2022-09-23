using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Produto : IObservable
    {
        List<IObserver> _clientesInteressados = new List<IObserver>();
        bool _temEstoque = false;
        int _estoque;
        string _nome;

        public int Estoque { get
            {
                return _estoque;
            }
            set
            {
                _estoque = value;
                if(_temEstoque == false && _estoque > 0)
                {
                    _temEstoque = true;
                    NotificarObserver();
                }
            }
        }

        public Produto(int estoque, string nome)
        {
            _estoque=estoque;
            _nome=nome;
        }

        

        public void NotificarObserver()
        {
            string disponibilidade = "";
            if (_temEstoque)
            {
                Console.WriteLine($"O produto {_nome} agora tem estoque!!");
                Console.WriteLine($"Notificando interessados");
                disponibilidade = $"o produto {_nome} que voê desmontrou interesse acabou de chegar, corra para adiquiri-lo";
            } 
            foreach (Cliente cliente in _clientesInteressados)
            {
                cliente.Atualizar(disponibilidade);
            }
        }

        public void RegistrarObserver(IObserver observer)
        {
            _clientesInteressados.Add(observer);
        }

        public void RemoverObserver(IObserver observer)
        {
            _clientesInteressados.Remove(observer);
        }
    }
}
