namespace class_used
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            string breed = "暹罗猫";
            string color = "橙色";
            int age = 3;
            cat.Cat_Speak(breed, color, age);
        }
    }


    class Cat
    {
        public string breed {  get; set; } 
        public string color {  get; set; } 
        public int age {  get; set; }
        
        public void Cat_Speak(string breed, string color,int age)
        {
            Console.WriteLine("{0}岁的{1}的{2}正在叫",age,color,breed);
        } 
    }
}
