using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBase[] allArrays = new ArrayBase[3];

            Random rnd = new();

            OneDimensionalArray onedimarray = new();
            allArrays[0] = onedimarray;

            TwoDimensionalArray twodimarray = new();
            allArrays[1] = twodimarray;

            JaggedArray jaggedarray = new();
            allArrays[2] = jaggedarray;

            foreach (ArrayBase array in allArrays)
            {
                Console.WriteLine($"Average: {array.FindAverage()} \n");

                array.PrintArray();

                Console.WriteLine();

                array.Refill();

                Console.WriteLine("Refilled array\n");

                array.PrintArray();

                Console.WriteLine();
            }
        }
    }
}
