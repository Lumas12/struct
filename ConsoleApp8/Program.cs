namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
            
            
        }
    }


    struct Struct
    {
        public string str;
        public Struct(string str) { this.str = str; }

        public Mystr create(int x)
        {
            Mystr mystr = new Mystr(str[x]);
            return mystr;   
        }
    }

    struct Mystr
    {
        public char c;
        public Mystr(char c) { this.c = c; }
    }
}
