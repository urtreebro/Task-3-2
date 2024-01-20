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
            BaseArray[] allArrays = new BaseArray[3];

            Random rnd = new();

            OneDimensionalArray onedimarray = new(rnd.Next(2, 10));
            allArrays[0] = onedimarray;

            TwoDimensionalArray twodimarray = new(rnd.Next(2, 10), rnd.Next(2, 10));
            allArrays[1] = twodimarray;

            JaggedArray jaggedarray = new(rnd.Next(2, 10));
            allArrays[2] = jaggedarray;

            foreach (BaseArray array in allArrays)
            {
                Console.WriteLine($"Average: {array.FindAverage()}");

                array.PrintArray();

                Console.WriteLine();
            }
        }
    }
}