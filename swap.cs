namespace generic
{
   
    
    
    internal class Program
    {

        static void Swap<T>(ref T a, ref T b)
        {

            Console.WriteLine("inside Swap Mwthod");
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            Console.WriteLine($"Before Swap: x={x} y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"AfterSwap: x={x} y={y}");
        }
    }
}
