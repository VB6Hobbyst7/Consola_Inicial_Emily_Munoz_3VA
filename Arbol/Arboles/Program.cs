using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola\n");

            Nodo raiz = new()
            {
                Valor = " *",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = " +",
                        Hijos = 
                        {
                            new Nodo
                            {
                                Valor = " 8"
                            },
                            new Nodo
                            {
                                Valor = " 5"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor = " -",
                        Hijos = 
                        {
                            new Nodo
                            {
                                Valor = " 7"
                            },   
                            new Nodo
                            {
                                Valor = " 4"
                            }
                        }
                    }
                }
            };

            ManejadorArbol manejadorArbol = new();

            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz) + " => Notación Infija\n") ;
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz) + " => Notación Prefija\n");
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz) + " => Notación Postfija\n");
        }
    }
}
