namespace 构造方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher( "Gandom_Driver", "old","amuro", 30);
            Student student = new Student(114514, "下北泽的课", "田所浩二", 24);
            Person.Print_All(student.Name, student.Age,student.Grade,student.Course);
            Person.Print_All(teacher.Name,teacher.Age,teacher.Department,teacher.Teaching);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age) 
        {
            Name = name;
            Age = age;
        }
        public static void Print_All(string name, int age, string department, string teaching)
        {
            Console.WriteLine("name is {0}", name);
            Console.WriteLine("age is {0}", age);
            Console.WriteLine("department is {0}", department);
            Console.WriteLine("teaching is {0}", teaching);
        }
        public static void Print_All(string name, int age, int grade, string course)
        {
            Console.WriteLine("name is {0}", name);
            Console.WriteLine("age is {0}", age);
            Console.WriteLine("grade is {0}", grade);
            Console.WriteLine("course is {0}", course);
        }


    }

    class Student : Person 
    {

        public int Grade { get; set; }
        public string Course { get; set; }

        public Student(int GRADE,string COURSE,string name,int age):base(name,age)
        {
            Grade = GRADE;
            Course = COURSE;
            Name = name;
            Age = age;
        }



    }


    class Teacher:Person
    {
        public string Department { get; set; }
        public string Teaching { get; set; }

        public Teacher(string department, string teaching,string name,int age):base(name,age)
        {
            Department = department;
            Teaching = teaching;
            Name = name;
            Age = age;
        }

    }

   


}
