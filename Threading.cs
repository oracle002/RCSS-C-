using System;
using System.Threading.Tasks;

namespace generic
{
    internal class Program
    {
        // Define a delegate that takes two parameters of type T and returns a T
        delegate T SumDelegate<T>(T a, T b);

        // Define a method that matches the delegate signature
        static T Add<T>(T a, T b)
        {
            Console.WriteLine("inside Add Method");
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            return sum;
        }

        static async Task Main(string[] args)
        {
            int x = 1;
            int y = 2;

            Console.WriteLine($"Before: x={x} y={y}");

            // Create an instance of the delegate, pointing to the Add method
            SumDelegate<int> sumDelegate = Add;

            // Create and start a task to run the delegate
            Task<int> task = Task.Run(() => sumDelegate(x, y));

            // Wait for the task to complete and get the result
            int result = await task;

            Console.WriteLine($"Result of adding {x} and {y}: {result}");
            Console.WriteLine($"After: x={x} y={y}");
        }
    }
}
