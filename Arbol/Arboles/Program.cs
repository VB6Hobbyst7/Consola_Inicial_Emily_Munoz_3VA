using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");

            Nodo raiz = new()
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+"
                    },
                };
                Hijos = {
                    new Nodo
                    {
                        Valor = "-"
                    },
                Hijos = {
                    new Nodo
                    {
                        Valor = "8"
                    },
                    new Nodo
                    {
                        Valor = "5"
                    },
                    new Nodo
                    {
                        Valor = "7"
                    },
                    new Nodo
                    {
                        Valor = "4"
                    }
                }
            };

            //Resultado esperado 
            //=> ( 8 + 5 ) * ( 7 - 4 ) = 39

            ManejadorArbol manejadorArbol = new();

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));
        }
    }
}
