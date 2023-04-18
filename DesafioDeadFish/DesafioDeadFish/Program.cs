using System.Collections;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = Deadfish.Parse("iiisdosodddddiso");
            foreach (int x in i)
            {
                Console.WriteLine(x);
            }
        }
    }

    public class Deadfish
    {
        public static int[] Parse(string str)
        {
            List<int> ret = new System.Collections.Generic.List<int>();
            int i = 0;
            char[] chars = str.ToCharArray();
            foreach (char c in chars)
            {
                if (c == 'i') i++;
                else if (c == 'd') i--;
                else if (c == 's') i = i * i;
                else if (c == 'o') ret.Add(i);
            }
            return ret.ToArray();
        }
    }
}