using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Cliente : IObserver
    {
        string _nome;

        public Cliente(string nome)
        {
            _nome=nome;
        }

        public void Atualizar(string disponibilidade)
        {
            Console.WriteLine($"Olá {_nome},{disponibilidade}");
        }
    }
}
