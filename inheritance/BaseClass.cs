using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    abstract class BaseArray
    {
        protected int n;

        protected bool userInput = false;

        protected BaseArray(int n, bool userInput = false)
        {
            this.n = n;

            this.userInput = userInput;
        }

        abstract public void RandomInput();

        abstract public void UserInput();

        abstract public void PrintArray();

        abstract public double FindAverage();
    }

}