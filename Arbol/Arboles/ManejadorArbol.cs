using System.Linq;

namespace Arboles
{
    class ManejadorArbol
    {
        public string ImprimirArbol (Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
           
            return ImprimirArbol(nodo.Hijos[0]) + nodo.Valor + ImprimirArbol(nodo.Hijos[1]);
        }
    }
}
