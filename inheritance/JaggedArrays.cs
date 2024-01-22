using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    sealed class JaggedArray : ArrayBase
    {
        private OneDimensionalArray[] array;
        public JaggedArray(int n, bool userInput = false) : base(n, userInput)
        {
            array = new OneDimensionalArray[n];

            if (userInput)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        public void Fill(int n, bool userInput = false)
        {
            this.n = n;

            if (userInput)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        public override void UserInput()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input length of nested array");

                int m = int.Parse(Console.ReadLine());

                OneDimensionalArray nestedArray = new(m, true);

                array[i] = nestedArray;
            }
        }

        public override void RandomInput()
        {
            for (int i = 0; i < n; i++)
            {
                OneDimensionalArray nestedArray = new(rnd.Next(1, 10));

                array[i] = nestedArray;
            }
        }

        public override void PrintArray()
        {
            Console.WriteLine("Printed array:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public override double FindAverage()
        {
            double sum = 0;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            double average = sum / count;
            return average;
        }

        public double[] GetAverageNumInNestedArrays()
        {
            double[] averageArray = new double[n];

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                int count = 0;

                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
                double average = sum / count;
                averageArray[i] = average;
            }
            return averageArray;
        }

        public void ChangeArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }
    }    
}
