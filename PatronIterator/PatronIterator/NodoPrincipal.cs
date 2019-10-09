using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class NodoPrincipal:AbstractNodo, IContainer<AbstractNodo>
    {
        private NodoAuxiliar izquierdaArriba;
        private NodoAuxiliar izquierdaAbajo;
        private NodoAuxiliar derechaArriba;
        private NodoAuxiliar derechaAbajo;

        internal NodoAuxiliar IzquierdaArriba { get => izquierdaArriba; set => izquierdaArriba = value; }
        internal NodoAuxiliar IzquierdaAbajo { get => izquierdaAbajo; set => izquierdaAbajo = value; }
        internal NodoAuxiliar DerechaArriba { get => derechaArriba; set => derechaArriba = value; }
        internal NodoAuxiliar DerechaAbajo { get => derechaAbajo; set => derechaAbajo = value; }

        public NodoPrincipal(int dato)
        {
            this.dato = dato;
        }

        public void agregarNodoDerechaArriba(NodoAuxiliar nodo)
        {
            if (derechaArriba == null)
            {
                derechaArriba = nodo;
            }
        }
        public void agregarNodoDerechaAbajo(NodoAuxiliar nodo)
        {
            if (derechaAbajo == null)
            {
                derechaAbajo = nodo;
            }
        }
        public void agregarNodoIzquierdaArriba(NodoAuxiliar nodo)
        {
            if (izquierdaArriba == null)
            {
                izquierdaArriba = nodo;
            }
        }
        public void agregarNodoIzquierdaAbajo(NodoAuxiliar nodo)
        {
            if (izquierdaAbajo == null)
            {
                izquierdaAbajo = nodo;
            }
        }

        public IIterator<AbstractNodo> createIterator()
        {
            return new TreeNodeIterator(this);
        }

        public override string toString()
        {
            return "NodoPrincipal(" + "Dato=" + dato + ")";
        }

        private class TreeNodeIterator : IIterator<AbstractNodo>
        {
            private LinkedList<AbstractNodo> list = new LinkedList<AbstractNodo>();
            private int index = 0;

            public TreeNodeIterator(NodoPrincipal nodo)
            {
                aplanar(nodo);
            }

            private void aplanar(NodoPrincipal nodo)
            {
                if (nodo.izquierdaArriba != null)
                {
                    list.AddLast(nodo.izquierdaArriba);
                }
                if (nodo.izquierdaAbajo != null)
                {
                    list.AddLast(nodo.izquierdaAbajo);
                }

                aplanarPrincipal(nodo);
            }

            private void aplanarPrincipal(NodoPrincipal nodo)
            {
                list.AddLast(nodo);
                if (nodo.derechaArriba != null)
                {
                    if (nodo.derechaAbajo != null)
                    {
                        list.AddLast(nodo.derechaArriba);
                        aplanarAuxiliar(nodo.derechaAbajo);
                    }
                    else
                    {
                        aplanarAuxiliar(nodo.derechaArriba);
                    }
                }else if (nodo.derechaAbajo != null)
                {
                    aplanarAuxiliar(nodo.derechaAbajo);
                }
                
            }

            private void aplanarAuxiliar(NodoAuxiliar nodo)
            {
                list.AddLast(nodo);
                if (nodo.NodoDerecho != null)
                {
                    aplanarPrincipal(nodo.NodoDerecho);
                }
            }

            public bool hasNext()
            {
                if (list.Count() == 0)
                {
                    return false;
                }
                return index < list.Count();
            }

            public AbstractNodo next()
            {
                if (!hasNext())
                {
                    Debug.WriteLine("No hay más elementos.");
                }
                return list.ElementAt(index++); 
            }
        }
    }
}
