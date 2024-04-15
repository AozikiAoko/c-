using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using 输出处理;
using game模板;

namespace mygame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("？？？：你是谁？");
            Console.ReadKey();
            Console.WriteLine("你告诉了那个人自己的名字(输入你的名字)");
            Devilhurter dt=new Devilhurter();
            dt.name=Console.ReadLine();
            Console.WriteLine("恶魔剑士：你就是" + dt.name + "啊，我是恶魔剑士，你就是为了寻求恶魔的力量而来的吧。");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：那好吧，我就看在你远道而来的份上，将这份力量赐予给你。");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：现在，把你的一切告诉我，我会根据你的身体给予你相应的力量。");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：你的性别是？");
            dt.sex = Console.ReadLine();
            Console.WriteLine("恶魔剑士：你现在携带的武器是？");
            dt.weapon = Console.ReadLine();
            Console.WriteLine("恶魔剑士：你擅长的能力名字是？");
            dt.oldstill = Console.ReadLine();//以后可能会觉醒。
            Console.WriteLine("恶魔剑士：这些过去的力量已经不需要了.");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：我会给予你新的力量！");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：来，把手伸出来。");
            Console.ReadKey();
            Console.WriteLine("你伸出了手，握住恶魔剑士的手，你感到有一阵暖流钻入你的手中，使你沉睡的血脉彻底觉醒。");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：这就是你的新力量了，来查看一下你的资料吧。");
            Console.ReadKey();
            Console.WriteLine("资料列表");
            dt.newstill = "恶魔之手";
            dt.HP = 100;
            dt.DP = 100;
            dt.ATK = 100;
            Showinfo.Infohero(dt);
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：我已经将力量交给了你。");
            Console.ReadKey();
            Console.WriteLine("恶魔剑士：去吧，开始你的冒险吧。");
            Console.ReadKey();
      
         }


    }

}
