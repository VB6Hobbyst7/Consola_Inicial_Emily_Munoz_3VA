using System;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hola.\nMi Nombre es Emily Muñoz\n Curso: Tercero Vespertino A\n");

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
                                Valor = " 1"
                            },
                            new Nodo
                            {
                                Valor = " 2"
                            },
                        }
                    },
                    new Nodo
                    {
                        Valor = " -",
                        Hijos = 
                        {
                            new Nodo
                            {
                                Valor = " 3"
                            },   
                            new Nodo
                            {
                                Valor = " 5"
                            },                            
                        }
                    }
                }
            };

            ManejadorArbol manejadorArbol = new();

            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz) + " => Notación Infija\n") ;
            
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz) + " => Notación Prefija\n");
            
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz) + " => Notación Postfija\n");

            Console.WriteLine($"Número de total de hojas: {manejadorArbol.NumeroHojas(raiz)}\n");

            Console.WriteLine($"Número de total de nodos: {manejadorArbol.NumeroNodos(raiz)}\n");

            Console.WriteLine($"Número de total de niveles: {manejadorArbol.NumeroNiveles(raiz)}\n");
        }
    }
}
