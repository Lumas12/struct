namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
           
        }
    }

    struct Mystr
    {
        int x;
        int y;

        public Mystr(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public static Mystr operator +(Mystr a, Mystr b)
        {
            Mystr mystr = new Mystr();
            mystr.x = a.x + b.x;
            mystr.y = a.y + b.y;
            return mystr;
        }

        public static Mystr operator *(Mystr a, Mystr b)
        {
            Mystr mystr = new Mystr();
            mystr.x = a.x * b.x;
            mystr.y = a.y * b.y;
            return mystr;
        }

        public static Mystr operator -(Mystr a, Mystr b)
        {
            Mystr mystr = new Mystr();
            mystr.x = a.x - b.x;
            mystr.y = a.y - b.y;
            return mystr;
        }

        public static Mystr operator ++(Mystr a)
        {
            if (a.x>a.y)
            {
                return new Mystr(a.x, a.x);
            }
            return new Mystr(a.y, a.y);
        }

        public static Mystr operator --(Mystr a)
        {
            if (a.x > a.y)
            {
                return new Mystr(a.y, a.y);
            }
            return new Mystr(a.x, a.x);
        }

    }
}
