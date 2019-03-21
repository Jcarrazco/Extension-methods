using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string on;
            char[] special = { '@','#' };
            bool est = true;
            char del;
            List<char> lscha;
            Console.WriteLine("Escriba una cadena");
            on = Console.ReadLine();
            Console.WriteLine("Escriba el caracter de la cadena a eliminar");
            del = Convert.ToChar(Console.ReadLine());

            //Metodo de extension usado para eliminar un caracter
            Console.WriteLine(on.DelCha(del));
            Console.ReadKey();

            //Metodo validar string si no tiene caracteres especiales
            Console.WriteLine("Validar que sea alphanumeric");
            on = Console.ReadLine();
            est = on.ValidateStringAlpha(est);
            Console.WriteLine("La cadena es alphanumerica: "+Convert.ToString(est));
            Console.ReadKey();

            //Metodo validar string es numerico o no
            Console.WriteLine("Validar que sea numerica");
            on = Console.ReadLine();
            est = on.ValidateStringNumeric(est);
            Console.WriteLine("La cadena es numerica: " + Convert.ToString(est));
            Console.ReadKey();

            //Metodo para las listas de char para convertirlo a string
            Console.WriteLine("Escriba una cadena de caracteres");
            on = Console.ReadLine();
            lscha = on.ToList();
            on = lscha.ConvertCharListToString();
            Console.WriteLine(on);
            Console.ReadKey();

        }
    }
}
