using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int number;
        int count = 0;
        int randomindex = random.Next(1, 11);
        while (true)
        {
            Console.WriteLine("请输入你猜测的1~10的数字");
            bool success = int.TryParse(Console.ReadLine(), out number);
            if (!success||number>10||number<0)
            {
                Console.WriteLine("输入错误，请重新输入");
                Console.ReadKey();
                continue;
            }
            else
            {
                Console.ReadKey();
            }
            if (number>randomindex)
            {
                Console.WriteLine("你猜大了，重新猜吧");
                count++;
                continue;
            }
            else if (number<randomindex) 
            {
                Console.WriteLine("你猜小了，重新猜吧");
                count++;
            }
            else
            {
                Console.WriteLine("你猜对了,使用了{0}次机会，想退出就扣0",count);
                success= int.TryParse(Console.ReadLine(), out number);
                if (success&&number==0)
                {
                    count = 0;
                    break;
                }
                count = 0;
                continue;
            }

        }
    }
}
