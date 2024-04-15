using System.Security.Cryptography.X509Certificates;

namespace 奶茶店
{
    internal class Program
    {
        class 奶茶店
        {
            public string 环境;
            public string 价格;
            public string 服务;
            public void message()
            {
                Console.WriteLine("这里的环境：{0}", 环境);
                Console.WriteLine("这里的价格：{0}",价格);
                Console.WriteLine("这里的服务：{0}",服务);
            }
        }
        
        static void Main(string[] args)
        {
            奶茶店 奶茶店实例化=new 奶茶店();
            奶茶店实例化.环境 = "好";
            奶茶店实例化.价格 = "贵";
            奶茶店实例化.服务 = "很棒";
            奶茶店实例化.message();
        }

    }
}
