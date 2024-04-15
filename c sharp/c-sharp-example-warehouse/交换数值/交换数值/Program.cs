namespace 交换数值
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
