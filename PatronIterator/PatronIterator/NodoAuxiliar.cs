using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class NodoAuxiliar:AbstractNodo
    {
        private NodoPrincipal izquierdo;
        private NodoPrincipal derecho;

        internal NodoPrincipal NodoIzquierdo { get => izquierdo; set => izquierdo = value; }
        internal NodoPrincipal NodoDerecho { get => derecho; set => derecho = value; }

        private class IteratorNodoAuxiliar : IIterator<NodoAuxiliar>
        {
            public bool hasNext()
            {
                throw new NotImplementedException();
            }

            public NodoAuxiliar next()
            {
                throw new NotImplementedException();
            }
        }
    }
}