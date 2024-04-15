using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp4
{
    class Character
    {
        public string name { get; private set; }
        public int HP {
            get; set;
        }
        public int ATK 
        {
            get; set;
        }

        public Character(string Name,int a,int b)
        {
            name = Name;
            if (a <= 0 || a > 100)
            {
                HP = 0;
            }
            else 
            { 
                HP = a;
            }
            ATK=b;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Character character=new Character("vegil",50,114514);
            Console.WriteLine("我的名字是：{0}",character.name);
            Console.WriteLine("我的生命值：{0}",character.HP);
            Console.WriteLine("我的攻击力：{0}",character.ATK);
            Console.ReadKey();
        }
    }
}
