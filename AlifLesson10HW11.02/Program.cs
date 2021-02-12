using System;

namespace AlifLesson10HW11._02
{
    
    class Program
    {
        delegate decimal Operation(decimal x , decimal y);
        static void Main(string[] args)
        {
            Calculator<double> Operation = new Calculator<double>();
            
            System.Console.WriteLine(Operation.opSum(2, 2));
            System.Console.WriteLine(Operation.opMin(2, 2));
            System.Console.WriteLine(Operation.opMul(2, 2));
            System.Console.WriteLine(Operation.opDiv(2, 2));
        }
        class Calculator<T>
        {
            public delegate T Operation(T x, T y);
            public Operation opSum = Sum;
            public Operation opMin = Sub;
            public Operation opMul = Mul;
            public Operation opDiv = Div;
            public static T Sum(T x, T y)
            {
                return (dynamic)x + (dynamic)y;
            }
            public static T Sub(T x, T y)
            {
                return (dynamic)x - (dynamic)y;
            }
            public static T Mul(T x, T y)
            {
                return (dynamic)x * (dynamic)y;
            }
            public static T Div(T x, T y)
            {
                return (dynamic)x / (dynamic)y;
            }
        }
    }
}
