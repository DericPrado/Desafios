namespace CategorizandoMenbros
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] candidatos = new[] { new[] { 45, 12 }, new[] { 56, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
            Console.WriteLine($"O resultado foi: {OpenOrSenior(candidatos)}");
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            string[] ret = new string[data.Length];
            IEnumerable<string> list = new List<string>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i][0] >= 55 && data[i][1] >= 7)
                {
                    ret[i] = "Senior";
                }
                else
                {
                    ret[i] = "Open";
                }
            }
            list = ret;
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            return list;
        }
    }
}
