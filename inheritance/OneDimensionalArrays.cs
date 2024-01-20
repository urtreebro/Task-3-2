﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    sealed class OneDimensionalArray : BaseArray
    {
        int[] array;
        public int[] Array
        {
            get { return array; }
        }

        public int this[int index]
        {
            get { return array[index]; }
        }

        public OneDimensionalArray(int n, bool userInput = false) : base(n, userInput)
        {
            if (userInput)
            {
                Console.WriteLine($"Input {n} numbers");
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        public override void RandomInput()
        {
            array = new int[n];

            Random rnd = new();

            for (int i = 0; i < array.Length; i++)
            {
                int value = rnd.Next(0, 1000);
                array[i] = value;
            }
        }

        public override void UserInput()
        {
            array = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    array[i] = num;
                }
                else
                {
                    Console.WriteLine("Couldn't convert into int");
                }
            }
        }
        public void Fill(int n, bool userInput = false)
        {
            this.n = n;

            if (userInput)
            {
                Console.WriteLine($"Input {n} numbers");
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        public override void PrintArray()
        {
            Console.WriteLine("Printed array:");
            Console.WriteLine(string.Join(" ", array));
        }

        public override double FindAverage()
        {
            double sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }
            double average = sum / n;
            return average;
        }

        public int[] GetArrayAbs100()
        {
            int newLength = n;

            foreach (int num in array)
            {
                if (Math.Abs(num) > 100)
                {
                    newLength--;
                }
            }

            int[] newArray = new int[newLength];

            int newIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            return newArray;
        }

        public int[] GetArrayWithoutDuplicates()
        {
            int newLength = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        newLength--;
                        break;
                    }
                }
            }

            int[] newArray = new int[newLength];

            int newIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (!newArray.Contains(array[i]))
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            return newArray;
        }
    }
}