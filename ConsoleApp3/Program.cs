namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Mystrct mystrct = new Mystrct("asdf");
            Console.WriteLine(mystrct.ToString());
            mystrct.Revers();
           // mystrct[0] = 't';
            Console.WriteLine(mystrct.ToString());
            
        }
    }

    struct Mystrct
    {
        char[] chars;
        public Mystrct(string str)
        {
            chars = new char[str.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = str[i];
            }
        }
        public Mystrct(int x, char c)
        {
            chars = new char[x];
            for (int i = 0; x < chars.Length; x++)
            {
                chars[x] = c;
            }
        }

        public char this[int index]
        {
            get
            {
                return chars[index];
            }
            set
            {
                chars[index] = value;
            }
        }

        public void Revers()
        {
            char copy;
            for (int i = 0;i < chars.Length/2;i++)
            {
                copy = chars[i];
                chars[i] = chars[chars.Length-i - 1];
                chars[chars.Length - i - 1] = copy;
            }
        }
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < chars.Length ; i++)
            {
                result += chars[i] + "-" + (int)chars[i] + " ";
            }
            return result;
        }
    }

}
