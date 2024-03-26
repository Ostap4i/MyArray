using MyArray;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = { 5, 2, 7, 3, 9 };

           MyArray myarray = new MyArray(inputArray);

           
            ((IOutput)myarray).Print();
            Console.WriteLine("Sum: " + ((IMath)myarray).Sum());
            Console.WriteLine("Average: " + ((IMath)myarray).Average());
            ((ISort)myarray).Sort();
            ((IOutput)myarray).Print();
        }
    }
}
