using System;
using System.Collections;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("Insira o valor: ");
            v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Solution(v));

        }

        public static int Solution(int value)
        {
            int soma = 0;
            int mt;
            int mc;

            for (int i = 0; i < value; i++)
            {
                mt = i % 3;
                mc = i % 5;

                if (mt.Equals(0) && mc.Equals(0))
                {
                    soma = soma + i;
                }

                else if (mt.Equals(0))
                {
                    soma = soma + i;
                }

                else if (mc.Equals(0))
                {
                    soma = soma + i;
                }
            }


            return soma;
        }
    }
}