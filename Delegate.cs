using System;
delegate int ArthOp(int x, int y);

class MathOperation
{
    public static int Add(int x, int y)
    { return x + y; }
    public static int Subtract(int x, int y) { return x - y; }

}
namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArthOp Operation1 = new ArthOp(MathOperation.Add);
            ArthOp Operation2= new ArthOp(MathOperation.Subtract);  

            int result1=Operation1(200,100);
            int result2=Operation2(200,100);

            Console.WriteLine("RESULT 1="+result1);
            Console.WriteLine("RESULT 2=" + result2);

        }
    }
}
