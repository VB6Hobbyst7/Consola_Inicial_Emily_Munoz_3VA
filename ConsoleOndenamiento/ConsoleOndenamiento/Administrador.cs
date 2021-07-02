namespace ConsoleOrdenamiento
{
    partial class Program
    {
        class Administrador
        {
            public int[] Ordenar(int[] desordenados)
            {
                for (int i = 0; i < desordenados.Length - 1; i++)
                {
                    int posicionMenor = ObtenerPosicionDelMenor(desordenados, i);
                    var intercambio = desordenados[i];
                    desordenados[i] = desordenados[posicionMenor];
                    desordenados[posicionMenor] = intercambio;
                }
                return desordenados;                
            }

            private  int ObtenerPosicionDelMenor(int[] desordenados, int inicio)
            {
                int posicionMenor = inicio;
                for (int posicionActual = inicio; posicionActual < desordenados.Length; posicionActual++)
                    if (desordenados[posicionMenor] < desordenados[posicionActual])
                        posicionMenor = posicionActual;
                return posicionMenor;
            }
        }
    }
}
