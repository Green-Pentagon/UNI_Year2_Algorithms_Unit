using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2_Stakcs___Queues
{
    partial class JobStack
    {
        private const int maxsize = 10;
        private int top = 0;
        private Job[] array = new Job[maxsize];

        public void Push(Job value)
        {
            array[top++] = value;
        }

        public Job Pop()
        {

            return array[--top];
        }

        public Job Peek()
        {
            return array[top - 1];
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxsize;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }

    }
}
