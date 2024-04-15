namespace 输入与输出练习
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name?");
            string name=Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string home = Console.ReadLine();
            Console.WriteLine("What's your hobby?");
            string hobby = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("Your home is:" + home);
            Console.WriteLine("Your hobby is:" + hobby);
            Console.ReadKey();
        }
    }
}
