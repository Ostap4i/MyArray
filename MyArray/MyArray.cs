using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class MyArray : IOutput, IMath, ISort
    {

        private int[] array;

        public MyArray(int[] inputArray)
        {
            array = inputArray;
        }

        public void Print()
        {
            Console.WriteLine("Array elements:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

  
        public double Average()
        {
            if (array.Length == 0)
                return 0;

            return (double)Sum() / array.Length;
        }

       
        public void Sort()
        {
            Array.Sort(array);
        }
    }

}


