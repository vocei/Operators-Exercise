using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.A method for addition, subtraction, multiplication
            Console.WriteLine("Give me a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The difference of those two numbers are:");
            Console.WriteLine(Subtract(num1, num2));

            Console.WriteLine("The product of those two numbers are:");
            Console.WriteLine(Multiply(num1, num2));

            Console.WriteLine("The sum of those two numbers are:");
            Console.WriteLine(Add(num1, num2));

            Console.WriteLine("The quotient of those two numbers are:");
            Console.WriteLine(Divide(num1, num2));

            Console.WriteLine("The remainder is:");
            Console.WriteLine(Modulus(num1, num2));

            //1.B for division create two integer variables called a and b
            Console.WriteLine("If I had two numbers being 17 and 4...");
            int a = 17;
            int b = 4;
            int quotient = Divide(a, b);
            int remainder = Modulus(a, b);
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} reminader {remainder}");
            }
            //End of exercise 1. Start exercise 2

            Console.WriteLine("What is the radius of your circle ?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");


        }
        
        public static double AreaOfCircle(double radius)
        {
            //return (Math.PI * radius * radius);
            return (Math.PI * Math.Pow(radius, 2));
          

        }

        public static int Subtract(int num1, int num2)
        { 
            return num1 - num2; 
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
