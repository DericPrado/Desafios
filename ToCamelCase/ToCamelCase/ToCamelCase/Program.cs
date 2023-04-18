

using System.Globalization;
using System.Text.RegularExpressions;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Digite o texto a ser convertido:");
            str = Console.ReadLine();
            Console.WriteLine($"Texto convertido: {ToCamelCase(str)}");
        }

        public static string ToCamelCase(string str)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            str = ti.ToTitleCase(str);
            str = Regex.Replace(str, @"[-_]", "");
            return str;
        }
    }
}