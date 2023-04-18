namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = -3;
            Console.WriteLine($"{GetSum(a,b)}");
        }

        public static int GetSum(int a, int b)
        {
            int ret = 0;

            if(a==b)
            {
                ret = a;
            }
           if(a < b)
            {
                for(int i= a; i<=b; i++)
                {
                    ret = i + ret;
                }
            }
           if(a > b)
            {
                for(int i = b; i <=a; i++)
                {
                    ret = i + ret;
                }
            }

            return ret;
        }
    }
}