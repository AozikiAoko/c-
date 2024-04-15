using System.Diagnostics.Contracts;

namespace 大象放冰箱
{
    internal class Program
    {

        class Elephants
        {
            public string name { get; set; }
            public string sex { get; set; }
            public int height { get; set; }
            public int weight { get; set; }
            public string breed { get; set; }

            public Elephants(string NAME,string SEX,int HEIGHT,int WEIGHT,string BREED) 
            {
                name = NAME;
                sex = SEX;
                height = HEIGHT;
                weight = WEIGHT;
                breed = BREED;
            }
            public Elephants()
            {
                name = "雾雨魔理沙";
                sex = "女";
                height = 18;
                weight = 18;
                breed = "魔法使";
            }
            
            public void play(){ Console.WriteLine("{0}正在玩耍",name); }
            public void sleep(){Console.WriteLine("{0}正在睡觉",name);}
            public void bath(){Console.WriteLine("{0}正在洗澡",name);}

        }
        class Icebox
        {
            public string brand { get; private set; }
            public int volume { get;private set; }
            public int price {  get;private set; }
            public string color { get;private set; }
            public Icebox(string BRAND,int VOLUME,int PRICE,string COLOR)
            {
                brand = BRAND;
                volume = VOLUME;
                price = PRICE;
                color = COLOR;
            }
            public Icebox()
            {
                brand = "666";
                volume = 999;
                price = 913;
                color = "yellow";
            }
            public void make_ICE()
            {
                Console.WriteLine("制冷中");
            }
            public void open(string name)
            {
                Console.WriteLine("打开冰箱门，把{0}放进去。",name);
            }
            public void close()
            {
                Console.WriteLine("关上冰箱门。");
            }
                
        }

        static void Main(string[] args)
        {
            Elephants elephants = new Elephants();
            Icebox icebox = new Icebox();
            string name=elephants.name;
            icebox.open(name);
            icebox.close();
        }
    }
}