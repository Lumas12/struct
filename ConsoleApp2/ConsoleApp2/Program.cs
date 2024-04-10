namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Mystrct mystrct = new Mystrct(5, "zxc", 'M');
            mystrct.Show();
        }
    }

    struct Mystrct
    {
        int x;
        string str;
        char c;

        public Mystrct(int x, string str, char c)
        {
            this.x = x;
            this.str = str;
            this.c = c;
        }
        public Mystrct(int x, string str)
        {
            this.x = x;
            this.str = str;
        }
        public Mystrct(string str)
        {
            this.str = str;
        }

        public void Show()
        {
            Console.WriteLine("int : {0},  str : {1} , char: {2}", x, str, c);
        }
    }
}
