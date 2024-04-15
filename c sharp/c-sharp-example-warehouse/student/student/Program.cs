namespace student
{
    internal class Program
    {
        class Student
        {
            public string name { get; private set; }
            public int score { get; set; }
            public Student(string NAME,int SCORE) 
            {
                name = NAME;
                score = SCORE;
            }
            public Student() 
            {
                name = "张三";
                score = 0;
            }
            public void print()
            {
                Console.WriteLine("名字是{0}", name);
                Console.WriteLine("分数是{0}",score);
            }
            static void Main(string[] args)
            {
                Student std = new Student();
                Student student = new Student("田所浩二",114514);
                std.print();
                student.print();
            }
        }
    }
}