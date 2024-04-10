namespace ConsoleApp1
{

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    internal class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            Days s = (Days)(x%7);
            Console.WriteLine(s);
        }


    }
}
