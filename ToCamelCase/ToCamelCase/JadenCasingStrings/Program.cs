using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o texto a ser convertido:");
            string str = Console.ReadLine();
            Console.WriteLine($"Texto convertido: {ToJadenCase(str)}");
        }

        public static string ToJadenCase(this string phrase)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            phrase = ti.ToTitleCase(phrase);
            phrase = Regex.Replace(phrase, " ", " ");
            return phrase;
        }
    }
}
