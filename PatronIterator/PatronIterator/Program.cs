using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterator");

            NodoAuxiliar nodoAuxiliar1 = new NodoAuxiliar(1);
            NodoAuxiliar nodoAuxiliar2 = new NodoAuxiliar(2);
            NodoPrincipal nodoPrincipal3 = new NodoPrincipal(3);
            NodoAuxiliar nodoAuxiliar4 = new NodoAuxiliar(4);
            NodoAuxiliar nodoAuxiliar5 = new NodoAuxiliar(5);
            NodoPrincipal nodoPrincipal6 = new NodoPrincipal(6);
            NodoAuxiliar nodoAuxiliar7 = new NodoAuxiliar(7);
            NodoAuxiliar nodoAuxiliar8 = new NodoAuxiliar(8);
            NodoPrincipal nodoPrincipal9 = new NodoPrincipal(9);
            NodoAuxiliar nodoAuxiliar10 = new NodoAuxiliar(10);

            nodoAuxiliar1.agregarNodoDerecho(nodoPrincipal3);
            nodoAuxiliar2.agregarNodoDerecho(nodoPrincipal3);

            nodoPrincipal3.agregarNodoIzquierdaArriba(nodoAuxiliar1);
            nodoPrincipal3.agregarNodoIzquierdaAbajo(nodoAuxiliar2);
            nodoPrincipal3.agregarNodoDerechaArriba(nodoAuxiliar4);
            nodoPrincipal3.agregarNodoDerechaAbajo(nodoAuxiliar5);

            nodoAuxiliar4.agregarNodoIzquierdo(nodoPrincipal3);
            nodoAuxiliar5.agregarNodoIzquierdo(nodoPrincipal3);
            nodoAuxiliar4.agregarNodoDerecho(nodoPrincipal6);
            nodoAuxiliar5.agregarNodoDerecho(nodoPrincipal6);

            nodoPrincipal6.agregarNodoIzquierdaArriba(nodoAuxiliar4);
            nodoPrincipal6.agregarNodoIzquierdaAbajo(nodoAuxiliar5);
            nodoPrincipal6.agregarNodoDerechaArriba(nodoAuxiliar7);
            nodoPrincipal6.agregarNodoDerechaAbajo(nodoAuxiliar8);

            nodoAuxiliar7.agregarNodoIzquierdo(nodoPrincipal6);
            nodoAuxiliar8.agregarNodoIzquierdo(nodoPrincipal6);
            nodoAuxiliar7.agregarNodoDerecho(nodoPrincipal9);
            nodoAuxiliar8.agregarNodoDerecho(nodoPrincipal9);

            nodoPrincipal9.agregarNodoIzquierdaArriba(nodoAuxiliar7);
            nodoPrincipal9.agregarNodoIzquierdaAbajo(nodoAuxiliar8);
            nodoPrincipal9.agregarNodoDerechaArriba(nodoAuxiliar10);

            nodoAuxiliar10.agregarNodoIzquierdo(nodoPrincipal9);

            IIterator<AbstractNodo> nodeIterator = nodoPrincipal3.createIterator();

            while (nodeIterator.hasNext())
            {
                AbstractNodo nodo = nodeIterator.next();
                Debug.WriteLine(nodo.toString());
            }
        }
    }
}
