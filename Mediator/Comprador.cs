using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Comprador
    {
        Mediator _mediator;

        public Comprador(Mediator mediator)
        {
            _mediator=mediator;
        }

        public void Comprar(int id)
        {
            _mediator.Vender(id);
        }
    }
}
