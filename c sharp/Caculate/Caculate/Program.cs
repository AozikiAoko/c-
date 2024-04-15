namespace Caculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1 = 1;
            float number2 = 5;
            Calculate calculate=Calculate.Calculate_Creat(number1,number2);
            Console.WriteLine(calculate.Add(number1,number2));
            Console.WriteLine(calculate.Subtract(number1,number2));
            Console.WriteLine(calculate.Multiply(number1, number2));
            Console.WriteLine(calculate.Divide(number1, number2));
        }
    }
    class Calculate
    {
        private float number1 { get; set; }
        private float number2 { get; set; }

        Calculate(float value1,float value2) 
        {
            number1 = value1;
            number2 = value2;
        }
        public static Calculate Calculate_Creat(float value1,float value2) 
        {
            return new Calculate(value1,value2);
        }
        public float Add(float value1,float value2) 
        {
            return value1 + value2;
        }

        public float Subtract(float value1,float value2) 
        {  
            return value1 - value2; 
        }
        public float Multiply(float value1,float value2) 
        { 
            return value1 * value2; 
        }
        public float Divide(float value1,float value2) 
        { 
            return value1 / value2; 
        }
    }

}
