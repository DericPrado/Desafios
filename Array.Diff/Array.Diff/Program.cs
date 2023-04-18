using System.Linq;
using System.Net.Http.Headers;

namespace Array.Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,2,3,4,5};
            int[] b = {2};
            Console.WriteLine($"O retorno é igual a: {ArrayDiff(a, b)}");
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var lista = a.ToList();
            int[] ret;
            if (b.Length < 1 || a.Length < 1)
            {
                foreach (int i in a)
                {
                    Console.WriteLine(i);
                }
                return a.ToArray();
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int e = 0; e < b.Length; e++)
                    {
                        if (lista[i] == b[e])
                        {
                            lista.RemoveAt(i);
                            if(i>0)i--;
                            if (e > 0) e--;
                        }
                    }

                }
                ret = lista.ToArray();
                foreach (var i in ret)
                {
                    Console.WriteLine(i);
                }
                return ret;
            }
        }
    }
}