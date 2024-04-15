using System.Runtime.InteropServices;

namespace 鲁棒性强的输入程序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool ischeck = true;
            for (;ischeck ; )
            {
                Console.WriteLine("请输入你的年龄：");
                string str = Console.ReadLine();  
                try 
                {
                age=int.Parse(str);
                    ischeck = false;    
                }
                catch 
                { 
                    Console.WriteLine("输入错误，重新输入");   
                }
            }
            Console.WriteLine("你的年龄是"+age+"岁");
        }
    }
}
