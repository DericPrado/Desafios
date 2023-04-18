using System.Text;

namespace DeMorse
{
    class Program
    {
        static Dictionary<char, string> translator;
        static Dictionary<string, char> tradutor;
        static void Main(string[] args) 
        {
            Console.WriteLine("Insira o código Morse:");
            string mo = Console.ReadLine();
            Console.WriteLine($"A codificação do código Morse é: {Code(mo)}");

            Console.WriteLine($"A decodificação do código Morse é: {Decoder(Code(mo))}");

        }

        public static string Code (string morseCode)
        {
            InitialiseDictionary();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char c in morseCode)
            {
                if(translator.ContainsKey(c))
                {
                    sb.Append(translator[c] + " ");
                }
                else if(c == ' ')
                {
                    sb.Append("/ ");
                }
                else
                {
                    sb.Append(c + " ");
                }
            }
            return sb.ToString();
        }

        public static string Decoder(string code)
        {
            InitialiseDictionary();
            System.Text.StringBuilder sb = new StringBuilder();
            foreach(string c in code.Split(" "))
            {
                if (tradutor.ContainsKey(c))
                {
                    sb.Append(tradutor[c]);
                }
                else if (c == "/ ")
                {
                    sb.Append(' ');
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
       

        private static void InitialiseDictionary()
        {
            char dot = '.';
            char dash = '−';

            translator = new Dictionary<char, string>()
            {
                {'a', string.Concat(dot, dash)},
                {'b', string.Concat(dash, dot, dot, dot)},
                {'c', string.Concat(dash, dot, dash, dot)},
                {'d', string.Concat(dash, dot, dot)},
                {'e', dot.ToString()},
                {'f', string.Concat(dot, dot, dash, dot)},
                {'g', string.Concat(dash, dash, dot)},
                {'h', string.Concat(dot, dot, dot, dot)},
                {'i', string.Concat(dot, dot)},
                {'j', string.Concat(dot, dash, dash, dash)},
                {'k', string.Concat(dash, dot, dash)},
                {'l', string.Concat(dot, dash, dot, dot)},
                {'m', string.Concat(dash, dash)},
                {'n', string.Concat(dash, dot)},
                {'o', string.Concat(dash, dash, dash)},
                {'p', string.Concat(dot, dash, dash, dot)},
                {'q', string.Concat(dash, dash, dot, dash)},
                {'r', string.Concat(dot, dash, dot)},
                {'s', string.Concat(dot, dot, dot)},
                {'t', string.Concat(dash)},
                {'u', string.Concat(dot, dot, dash)},
                {'v', string.Concat(dot, dot, dot, dash)},
                {'w', string.Concat(dot, dash, dash)},
                {'x', string.Concat(dash, dot, dot, dash)},
                {'y', string.Concat(dash, dot, dash, dash)},
                {'z', string.Concat(dash, dash, dot, dot)},
                {'0', string.Concat(dash, dash, dash, dash, dash)},
                {'1', string.Concat(dot, dash, dash, dash, dash)},
                {'2', string.Concat(dot, dot, dash, dash, dash)},
                {'3', string.Concat(dot, dot, dot, dash, dash)},
                {'4', string.Concat(dot, dot, dot, dot, dash)},
                {'5', string.Concat(dot, dot, dot, dot, dot)},
                {'6', string.Concat(dash, dot, dot, dot, dot)},
                {'7', string.Concat(dash, dash, dot, dot, dot)},
                {'8', string.Concat(dash, dash, dash, dot, dot)},
                {'9', string.Concat(dash, dash, dash, dash, dot)}
            };

            tradutor = new Dictionary<string, char>()
            {
                {string.Concat(dot, dash), 'a' },
                {string.Concat(dash, dot, dot, dot), 'b' },
                {string.Concat(dash, dot, dash, dot) , 'c'},
                {string.Concat(dash, dot, dot), 'd'},
                {dot.ToString(), 'e'},
                {string.Concat(dot, dot, dash, dot), 'f'},
                {string.Concat(dash, dash, dot), 'g'},
                {string.Concat(dot, dot, dot, dot), 'h'},
                {string.Concat(dot, dot), 'i'},
                {string.Concat(dot, dash, dash, dash), 'j'},
                {string.Concat(dash, dot, dash), 'k'},
                {string.Concat(dot, dash, dot, dot), 'l'},
                {string.Concat(dash, dash), 'm'},
                {string.Concat(dash, dot), 'n'},
                {string.Concat(dash, dash, dash), 'o'},
                {string.Concat(dot, dash, dash, dot), 'p'},
                {string.Concat(dash, dash, dot, dash), 'q'},
                {string.Concat(dot, dash, dot), 'r'},
                {string.Concat(dot, dot, dot), 's'},
                {string.Concat(dash), 't'},
                {string.Concat(dot, dot, dash), 'u'},
                {string.Concat(dot, dot, dot, dash), 'v'},
                {string.Concat(dot, dash, dash), 'w'},
                {string.Concat(dash, dot, dot, dash), 'x'},
                {string.Concat(dash, dot, dash, dash), 'y'},
                {string.Concat(dash, dash, dot, dot), 'z'},
                {string.Concat(dash, dash, dash, dash, dash), '0'},
                {string.Concat(dot, dash, dash, dash, dash), '1'},
                {string.Concat(dot, dot, dash, dash, dash), '2'},
                {string.Concat(dot, dot, dot, dash, dash), '3'},
                {string.Concat(dot, dot, dot, dot, dash), '4'},
                {string.Concat(dot, dot, dot, dot, dot), '5'},
                {string.Concat(dash, dot, dot, dot, dot), '6'},
                {string.Concat(dash, dash, dot, dot, dot), '7'},
                {string.Concat(dash, dash, dash, dot, dot), '8'},
                {string.Concat(dash, dash, dash, dash, dot), '9'}
            };
        }

       
    }

}
