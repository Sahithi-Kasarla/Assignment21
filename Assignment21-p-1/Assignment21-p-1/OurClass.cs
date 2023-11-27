using System;
namespace Assignment21_p_1
{
    public delegate int ArithmeticOperation(int num1, int num2);
    public class OurClass
    {
        public ArithmeticOperation AdditionDelegate { get; } = new ArithmeticOperation(Add);
        public ArithmeticOperation SubtractionDelegate { get; } = new ArithmeticOperation(Sub);
        public ArithmeticOperation MultiplicationDelegate { get; } = new ArithmeticOperation(Multi);
        public ArithmeticOperation DivisionDelegate { get; } = new ArithmeticOperation(Div);
        private static int Add(int n1, int n2)
        {
            return n1 + n2;
           // Console.WriteLine("after addition of {0} and {1}=\t{2}", n1, n2, n1 + n2);
        }
        private static int Sub(int n1,int n2)
        {
            return n1 - n2;
            //Console.WriteLine("after subtraction of {0} and {1}=\t{2}", n1, n2, n1 - n2);
        }
        private static int Multi(int n1,int n2)
        {
            return n1 * n2;
            Console.WriteLine("after  multiplication {0} and {1}=\t{2}", n1, n2, n1 * n2);
        }
        private static int Div(int n1, int n2)
        {
            return n1/n2;
            Console.WriteLine("after division of {0} and {1}=\t{2}", n1, n2, n1 / n2);
        }
    }
}
