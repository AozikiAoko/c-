namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=new int();
            Console.WriteLine("请输入三位整数");
            num=int.Parse(Console.ReadLine());
            int hun = num / 100 % 10;
            int ten =num/10%10;
            int single = num % 10;
            Console.ReadKey();
            int sum=hun+ten+single;
            Console.WriteLine("三位数相加总计为:{0}",sum);
            Console.WriteLine("百位是:{0}",hun);
            Console.WriteLine("十位是:{0}", ten);
            Console.WriteLine("个位是:{0}",single);
            Console.ReadKey();
        }
    }
}
