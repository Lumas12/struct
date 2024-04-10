namespace ConsoleApp7
{
    internal class Program
    {
        static void Main()
        {
            string str = "zxc";
            string x = null;
            x = Str(Mas(str));
            Console.WriteLine(x);
        }
        public static Mystr[] Mas(string str)
        {
            Mystr[] mystrs = new Mystr[str.Length];
            for (int i = 0; i< str.Length; i++)
            {
                mystrs[i] = new Mystr(str[i]);
            }
            return mystrs;
        }

        public static string Str(Mystr[] mystrs)
        {
            string str = null;
            for (int i = 0; i < mystrs.Length; i++)
            {
                str += mystrs[i].c;
            }
            return str;
        }
    }

    struct Mystr
    {
        public char c;
        public Mystr(char c) { this.c = c;}        
    }
    
}