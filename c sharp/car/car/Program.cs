using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car=Car.initi_Car(90, 5);
            car.Move();
            car.Set_Speed(80);
            car.Move();
            car.Speed_UP();
            car.Speed_DOWN();
            

        }

    }


    class Car
    {
        private int Speed { get; set; }
        private int _valume; 
        public int Valume//使用Set的时候建立一个私有的变量，赋值就使用这个
        { 
            get 
            {
                if (_valume > 5 || _valume < 1)
                {
                    Console.WriteLine("throw new Exception");
                    return -1;
                }
                return _valume;

            }
            private set 
            {
                _valume = value;        
            } 
        }

        Car(int SPEED,int VALUME) 
        {
            Speed = SPEED;
            Valume = VALUME;
            Console.WriteLine("速度是:{0}", Speed);
            if (Valume > 0)
            {
                Console.WriteLine("重量是:{0}", Valume);
            }
        }

        public void Move()
        {
            if(Speed<=80&&Speed>0)
            {
                Console.WriteLine("低速行驶");
            }
            else if(Speed>80&&Speed<=120)
            {
                Console.WriteLine("高速行驶");
            }
            else if (Speed > 120)
            {
                Console.WriteLine("超速行驶");
            }
            else
            {
                Console.WriteLine("错误");
            }

        }

        public static Car initi_Car(int Speed,int valume)
        {
            return new Car(Speed,valume);
        }

        public void Set_Speed(int SPEED)
        {
            Speed=SPEED;
            Console.WriteLine("现在的速度是：{0}",Speed);
            
        }

        public void Speed_UP()
        {
            Speed += 5;
            Console.WriteLine("现在的速度是：{0}",Speed);
           
        }

        public void Speed_DOWN()
        {
            Speed -= 5;
            Console.WriteLine("现在的速度是：{0}",Speed);
        }

    }
}
