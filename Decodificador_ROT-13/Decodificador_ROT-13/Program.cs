using System.Collections.Generic;

namespace Decodificador
{
    class Program
    {
        static Dictionary <char, char> tradutor;
        static void Main(string[] args)
        {
            string s = "This is my first ROT13 excercise!";
            Console.WriteLine($"O resultado é: {Rot13(s)}");
        }

        public static string Rot13(string input)
        {
            Dictionary();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in input)
            {
                if(tradutor.ContainsKey(c))
                {
                    sb.Append(tradutor[c]);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private static void Dictionary()
        {
            tradutor = new Dictionary<char, char>()
            {
                {'a', 'n' },
                {'b', 'o' },
                {'c', 'p' },
                {'d', 'q' },
                {'e', 'r' },
                {'f', 's' },
                {'g', 't' },
                {'h', 'u' },
                {'i', 'v' },
                {'j', 'w' },
                {'k', 'x' },
                {'l', 'y' },
                {'m', 'z' },
                {'n', 'a' },
                {'o', 'b' },
                {'p', 'c' },
                {'q', 'd' },
                {'r', 'e' },
                {'s', 'f' },
                {'t', 'g' },
                {'u', 'h' },
                {'v', 'i' },
                {'w', 'j' },
                {'x', 'k' },
                {'y', 'l' },
                {'z', 'm' },
                {'A', 'N' },
                {'B', 'O' },
                {'C', 'P' },
                {'D', 'Q' },
                {'E', 'R' },
                {'F', 'S' },
                {'G', 'T' },
                {'H', 'U' },
                {'I', 'V' },
                {'J', 'W' },
                {'K', 'X' },
                {'L', 'Y' },
                {'M', 'Z' },
                {'N', 'A' },
                {'O', 'B' },
                {'P', 'C' },
                {'Q', 'D' },
                {'R', 'E' },
                {'S', 'F' },
                {'T', 'G' },
                {'U', 'H' },
                {'V', 'I' },
                {'W', 'J' },
                {'X', 'K' },
                {'Y', 'L' },
                {'Z', 'M' }
            };
        }
    }
}