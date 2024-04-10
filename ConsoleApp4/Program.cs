namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    struct Mystr
    {
        int[] x;
        int max = 0;
        int min = 12;
        int avg = 0;
        public Mystr(int l)
        {
            x = new int[l];
            Random random = new Random();
            for (int i = 0; i < l; i++)
            {
                x[i] = random.Next(11);

                if (x[i] > max)
                {
                    max = x[i];
                }

                if (x[i] < min)
                {
                    min = x[i];
                }

                avg += x[i];
            }
            avg /= l;
        }

        public int maks()
        {
            return max;
        }
        public int minim() { return min; }
        public int ave() { return avg; }

    }
}
