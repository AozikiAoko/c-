namespace 收银台练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入单价（￥）");
            double Price= double.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("请输入数量：");
            int Num=int.Parse(Console.ReadLine());
            Console.ReadKey();
            double AllPrice = 0;
            AllPrice = Price * Num;
            Console.WriteLine("您向柜台支付金额：");
            double Total= double.Parse(Console.ReadLine()); 
            Console.ReadKey();
            if (Total < AllPrice)
                Console.WriteLine("金额不足");
            else if (AllPrice >= 500 && Total >= AllPrice)
                Console.WriteLine("开启8折优惠，原本价格：{0}，折后价格：{1},找零为：{2}",AllPrice,AllPrice*0.8,Total-AllPrice*0.8);

            else
                Console.WriteLine("应收金额为：{0},找零为：{1}", AllPrice, Total - AllPrice);
            Console.ReadKey();
        }
    }
}
