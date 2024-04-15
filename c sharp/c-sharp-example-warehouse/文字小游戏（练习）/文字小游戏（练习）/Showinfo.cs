using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mygame.Program;
using game模板;


namespace 输出处理
{
    public class Showinfo
    {
        public static void Infohero(Devilhurter dh)//用这个方法输出角色信息
        {
            Console.WriteLine("你的名字" + dh.name);
            Console.WriteLine("你的性别" + dh.sex);
            Console.WriteLine("你的武器" + dh.weapon);
            Console.WriteLine("你的技能:" + dh.oldstill + " " + dh.newstill);
            Console.WriteLine("你的攻击力：" + dh.HP);
            Console.WriteLine("你的魔力值：" + dh.DP);
            Console.WriteLine("你的攻击力：" + dh.ATK);
        }
    }
}
