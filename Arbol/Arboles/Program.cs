using System;
using System.Collections;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: Emily Muñoz. \nCurso: Tercero Vespertino A\n\n");

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
                                Valor = " 15"
                            },
                            new Nodo
                            {
                                Valor = " 24"
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
                                Valor = " 3x"
                            },   
                            new Nodo
                            {
                                Valor = " 5y"
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

            Queue queue = new Queue();

            queue.Enqueue(new Nodo());
            Nodo nodo = (Nodo)queue.Dequeue();
        }
    }
}
