using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    abstract class ArrayBase
    {
        protected bool userInput = false;

        protected static Random rnd = new();

        protected ArrayBase(bool userInput = false)
        {
            this.userInput = userInput;

            if (userInput)
            {
                UserInput();
            }
            else
            {
                RandomInput();
            }
        }

        protected abstract void RandomInput();

        protected abstract void UserInput();

        public abstract void PrintArray();

        public abstract double FindAverage();

        public abstract void Refill(bool userInput = false);
    }
}
