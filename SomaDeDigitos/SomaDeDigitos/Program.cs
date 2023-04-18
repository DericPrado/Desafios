namespace SomaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };

            if(comp(a,b))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");

            }
        }

        public static int DigitalRoot(long n)
        {
            string m = n.ToString();
            char[] c = m.ToCharArray();
            int soma = 0;

            if (c.Length == 1)
            {
                return soma = int.Parse(c[0].ToString());
            }

                while (c.Length > 1)
            {
                int s = 0;
                soma = 0;
                foreach (char c2 in c)
                {
                    s += int.Parse(c2.ToString());
                }
                soma += s;
                m = soma.ToString();
                c = m.ToCharArray();
            }


            return soma;
        }

        public static bool comp(int[] a, int[] b)
        {
            bool res = false;
            
            if(a.Length != b.Length || (a.Length < 0 || b.Length < 0))
            {
                return false;
            }

            foreach (int n in b)
            {
                res = false;
                foreach (int c in a)
                {
                    if (n == c * c)
                    {
                        res = true;
                        break;
                    }
                    else res = false;
                }

                if (!res)
                {
                    return false;
                }
            }

            return res;
        }
    }
}