using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Stack<T>
    {
        private List<T> stack = new List<T> ();
        
        public void Push(T item)
        {
            stack.Add (item);   
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException ("Stack is empty");
            }
            var item = stack[stack.Count - 1];
            stack.RemoveAt (stack.Count - 1);
            return item;
        }

        public T Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");

            }
            return stack[stack.Count - 1];
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
        public override string ToString()
        {
            return "[" + string.Join (", ", stack) + "]";
        }

    }
}
