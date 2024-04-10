namespace ConsoleApp10
{
    internal class Program
    {
        static void Main()
        {
            
        }
    }
    struct Mystr
    {
        int z;
        public Mystr(int z)
        {
            this.z = z;
        }

        public static Mystr2 operator +(Mystr a,  Mystr b)
        {
            return new Mystr2(a.z, b.z);
        }

    }
    struct Mystr2
    {
        
        int x;
        int y;
        public Mystr2(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public Mystr[] division()
        {
            Mystr[] result = new Mystr[2];
            result[0] = new Mystr(x);
            result[1] = new Mystr(y);
            return result;
        }

    }
}
