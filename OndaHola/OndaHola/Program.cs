namespace CodeWars
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = " gap ";
            List<string> list = new List<string>();
            list = Wave(s);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> Wave(string str)
        {
            char[] chars = str.ToCharArray();
            List<string> list = new List<string>();
            string s = "";

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    s = s + chars[i].ToString();
                }

                else
                {
                    chars[i] = Convert.ToChar(chars[i].ToString().ToUpper());
                    s = "";
                    for (int n = 0; n < chars.Length; n++)
                    {
                        s = s + chars[n].ToString();
                    }
                    list.Add(s);
                    chars[i] = Convert.ToChar(chars[i].ToString().ToLower());
                }
            }

            return list;
        }
    }
}