using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0) return true;
            else return false;

            
        }
        public void AddRange(Stack<string> range)
        {
            foreach (string item in range)
            {
                this.Push(item);
            }
        }
    }
}
