using System.Text.Json.Serialization.Metadata;
using System.Linq;
using System.Data.SqlTypes;

namespace SequenciaTribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] assinatura = new double[3];
            string resposta;
            string[] res = new string[3];
            int n;

            Console.WriteLine("informe a assinatura de 3 numeros, separando-os por vírgula, para iniciar a sequência:");
            resposta= Console.ReadLine();
            res = resposta.Split(',');

            for(int i = 0; i<res.Length; i++)
            {
                assinatura[i] = Convert.ToDouble(res[i]); 
            }

            Console.WriteLine("Insira a quantidade de elementos após a assinatura:");
            n = Convert.ToInt32(Console.ReadLine());
            var resultadoFinal = Tribonacci(assinatura, n);

            Console.WriteLine("-------------------------------------------");

            foreach(var i in resultadoFinal)
            {
                Console.WriteLine(i);
            }

            
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            var empty = Enumerable.Empty<double>();
            double[] ret = new double[n];

           
            if (n >= 0)
            {
                if (n == 0)
                {
                    signature = empty.ToArray();
                    return signature;
                }
                if(n>0 & n<=3)
                {
                    for(int i=0; i<n; i++)
                    {
                        ret[i] = signature[i];
                    }
                }
                if(n>3)
                {
                    for (int i = 0; i < signature.Length; i++)
                    {
                        ret[i] = signature[i];
                    }

                    for (int i = signature.Length; i < ret.Length; i++)
                    {
                        ret[i] = ret[i - 1] + ret[i - 2] + ret[i - 3];
                    }

                }
                return ret;
                
            }
            throw new Exception();
        }
    }
}
