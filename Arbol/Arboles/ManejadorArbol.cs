using System.Linq;

namespace Arboles
{
    class ManejadorArbol
    {
        public string ImprimirArbolInfijo (Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
           
            return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1])} )" ;
        }

        public string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {nodo.Valor} {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])} )";
        }

        public string ImprimirArbolPostfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {ImprimirArbolPostfijo(nodo.Hijos[0])} {ImprimirArbolPostfijo(nodo.Hijos[1])} {nodo.Valor} )";
        }
    }
}
