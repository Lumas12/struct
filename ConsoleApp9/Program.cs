namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            
        }

        public static Mystr maks(int[] ints)
        {
            
            int max = ints.Max();
            int index = Array.IndexOf(ints, max);
            return new Mystr(max, index);
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

    }
}
