using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 文件改名与删除
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/文博/Desktop/c sharp代码操作文件";
            DirectoryInfo root = new DirectoryInfo(path);//实例化这个system中的类
            FileInfo[] file = root.GetFiles();//数组承接root实例化变量中的方法
            List<FileInfo> isfiles = file.ToList();//数组转泛型集合
            for (int i = 0; i < isfiles.Count; i++)
            {
                Console.WriteLine(isfiles[i].Name);//打印存放的文件名
            }
            Console.WriteLine("你想对文件执行什么操作：删除按1，改名按2");
            string input = Console.ReadLine();//输入要执行的操作
            Console.WriteLine("请输入你要操作的文件名(要包含后缀名)：");
            string Yourfile = Console.ReadLine();//输入要操作的文件名
            bool check1 = int.Parse(input) == 1;
            bool check2 = int.Parse(input) == 2;
            bool check3 = int.Parse(input) == 0;
            if(check1)
            {
                for (int i = 0; i < isfiles.Count; i++)
                {

                    Console.WriteLine(isfiles[i].Name);
                    if (isfiles[i].Name == Yourfile)
                    {
                        System.IO.File.Delete(isfiles[i].FullName);
                        Console.WriteLine("文件" + isfiles[i].Name + "已删除");
                    }

                }
                Console.WriteLine("删除操作已结束");
            }
            if (check2)
            {
                for (int i = 0; i < isfiles.Count; i++)
                {
                    Console.WriteLine("请输入改掉的新名字");
                    string Newfile=Console.ReadLine();
                    bool ishave = isfiles[i].Name.Contains(Yourfile); //判断文件集合中是否存在你输入的文件
                    if (ishave)
                    {
                        string secFileName = isfiles[i].FullName;
                        string destFileName = isfiles[i].Directory.FullName + Newfile + isfiles[i].Extension;
                        File.Move(secFileName, destFileName);
                    }
                }
                Console.WriteLine("改名操作已结束");
            }
            Console.ReadKey();

        }

    }
}
