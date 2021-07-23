using System;
using System.Linq;

namespace Pregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] languages = { "Lisp", "ICI", "C#", "Angular", "F#" };

            var result = string.Join(string.Empty, languages.Reverse().Select(s => s[0]));

            Console.WriteLine (result);
        }
    }
}
