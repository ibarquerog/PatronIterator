using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class NodoAuxiliar : AbstractNodo
    {
        private NodoPrincipal izquierdo;
        private NodoPrincipal derecho;

        internal NodoPrincipal NodoIzquierdo { get => izquierdo; set => izquierdo = value; }
        internal NodoPrincipal NodoDerecho { get => derecho; set => derecho = value; }

        public NodoAuxiliar(int dato)
        {
            this.dato = dato;
        }

        public void agregarNodoIzquierdo(NodoPrincipal nodo)
        {
            if (izquierdo == null)
            {
                izquierdo = nodo;
            }
        }

        public void agregarNodoDerecho(NodoPrincipal nodo)
        {
            if (derecho == null)
            {
                derecho = nodo;
            }
        }

        public override string toString()
        {
            return "NodoAuxiliar(" + "Dato=" + dato + ")";
        }
    }
}