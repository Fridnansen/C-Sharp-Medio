using System;
using System.Text.RegularExpressions;

namespace expresiones70
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y n° de telefono es 8235482542  3836478623874";
            string patron = @"\82|\ 38";
            Regex miRegex = new Regex(patron);
            MatchCollection elMatch = miRegex.Matches(frase);
            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado numeros");
            else Console.WriteLine("no se ha encovtado numeros");

            Console.WriteLine("Hello World!");
        }
    }
}
