namespace ValidaParenteses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Insira os parenteses: ");
            s = Console.ReadLine();
            if(ValidParentheses(s))
            {
                Console.WriteLine("Quantidade é válida");
            }
            else
            {
                Console.WriteLine("Quantidade inválida");
            }
        }

        public static bool ValidParentheses(string input)
        {
            int parenteses = 0;
            foreach(char c in input)
            {
                if(c == '(')
                {
                    parenteses++;
                }
                else if(c == ')')
                {
                    parenteses--;
                }
                 if(parenteses == -1)
                {
                    return false;
                }
            }
            
            if(parenteses == 0)
            {
                return true;
            }
            
            
            return false;
        }
    }
}