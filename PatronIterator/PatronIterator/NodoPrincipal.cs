using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class NodoPrincipal:AbstractNodo
    {
        private NodoAuxiliar izquierdaArriba;
        private NodoAuxiliar izquierdaAbajo;
        private NodoAuxiliar derechaArriba;
        private NodoAuxiliar derechaAbajo;
        public NodoPrincipal() { }

        internal NodoAuxiliar IzquierdaArriba { get => izquierdaArriba; set => izquierdaArriba = value; }
        internal NodoAuxiliar IzquierdaAbajo { get => izquierdaAbajo; set => izquierdaAbajo = value; }
        internal NodoAuxiliar DerechaArriba { get => derechaArriba; set => derechaArriba = value; }
        internal NodoAuxiliar DerechaAbajo { get => derechaAbajo; set => derechaAbajo = value; }

        private class IteratorNodoPrincipal : IIterator<NodoPrincipal>
        {
            public bool hasNext()
            {
                throw new NotImplementedException();
            }

            public NodoPrincipal next()
            {
                throw new NotImplementedException();
            }
        }

    }
}
