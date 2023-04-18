namespace DNA
{
    class Program
    {
        static void Main(string[] args) 
        {
            string dna = "AAAA";
            Console.WriteLine($"O resultado é: {MakeComplement(dna)}");
        }

        public static string MakeComplement(string dna)
        {
            char[] chars= dna.ToCharArray();
            string[] ret = new string[dna.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'A')
                {
                    ret[i] = "T";
                }
                else if(chars[i] == 'T')
                {
                    ret[i] = "A";
                }
                else if (chars[i] == 'C')
                {
                    ret[i] = "G";
                }
                else if(chars[i] == 'G')
                {
                    ret[i] = "C";
                }
            }
            return string.Join("", ret);
        }
    }
}
