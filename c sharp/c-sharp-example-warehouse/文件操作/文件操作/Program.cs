using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using delete;
using Cancel;
namespace 文件操作//删除文件而用
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/文博/Desktop/c sharp代码操作文件";
            DirectoryInfo root=new DirectoryInfo(path);//实例化这个system中的类
            FileInfo[] file = root.GetFiles();//数组承接root实例化变量中的方法
            List<FileInfo> isfiles = file.ToList();//数组转泛型集合
            Console.WriteLine("你想对文件执行什么操作：删除按1，改名按2，退出按0");
            string input =Console.ReadLine();//输入要执行的操作
            int.Parse(input);
            Console.WriteLine("请输入你要操作的文件名(要包含后缀名)：");
            string Yourfile = Console.ReadLine();//输入要操作的文件名
            Console.ReadKey();
        }
    }
}
