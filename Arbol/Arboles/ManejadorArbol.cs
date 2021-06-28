using System.Linq;

namespace Arboles
{
    class ManejadorArbol
    {
        internal string ImprimirArbolInfijo (Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
           
            return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])} )" ;
        }

        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])} )";
        }

        internal string ImprimirArbolPostfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {ImprimirArbolPostfijo(nodo.Hijos[0])} {ImprimirArbolPostfijo(nodo.Hijos[1])} {nodo.Valor} )";
        }

        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalHojas = 0;

            foreach ( Nodo hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }

            return totalHojas;
        }

        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }

        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;

            foreach (Nodo nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;
        }

        internal int NumeroNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            var nivelHijos = 0;
            foreach (Nodo nodoActual in nodo.Hijos)
            {
                var nivelActual = NumeroNiveles(nodoActual);
                if (nivelHijos < nivelActual)
                    nivelHijos = nivelActual;
            }
            return ++nivelHijos;
        }
    }
}
