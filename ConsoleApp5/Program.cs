namespace ConsoleApp5
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
        private int value1;
        private int value2;
        private int value3;

        public Mystr(int value1, int value2, int value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }
        public Mystr(int value1, int value2)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value1 + value2;
        }
        public Mystr(int value1)
        {
            this.value1 = value1;
            this.value2 = value1%10;
            this.value3 = value1/3;
        }

        public int mini
        {
            get
            {
                if (value1 <= value2 && value1 <= value3)
                {
                    return value1;
                }
                else if (value2 <= value1 && value2 <= value1)
                {
                    return value2;
                }
                else
                {
                    return value3;
                }
            }

            set
            {
                if (value < value1)
                {
                    value1 = value;
                }
            }
        }

        public int maks
        {
            get
            {
                if (value1 >= value2 && value1 >= value3)
                {
                    return value1;
                }
                else if (value2 >= value1 && value2 >= value1)
                {
                    return value2;
                }
                else
                {
                    return value3;
                }
            }

            set
            {
                if (value > value1)
                {
                    value1 = value;
                }
            }
        }
    }
}