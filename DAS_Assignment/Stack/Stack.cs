using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class Stack : IStack
    {
        private int?[] _stack;
        private readonly int EmptyStack = -1;

        public Stack(int size)
        {
            _stack = new int?[size];
            Top = EmptyStack;
        }

        public int Top { get; set; }

        public bool IsEmpty()
        {
            return Top == EmptyStack; 
        }

        public bool IsFull()
        {
            return Top == _stack.Length - 1;
        }

        public object Pop()
        {
            var popedItem = _stack[Top];

            AfterPop();

            return popedItem;
        }
        private void AfterPop()
        {
            _stack[Top] = null;
            Top--;
        }

        /// <summary>
        /// First check if stack is not full
        /// If is not full add element
        /// </summary>
        public void Push(int item)
        {
            Top++;
            _stack[Top] = item;
        }
        private void AfterPush()
        {
            _stack[Top] = null;
            Top--;
        }

        public override string ToString()
        {
            return "Top: " + Top + " || Numbers in stack || " + GetStackContentAsString();
        }
        private string GetStackContentAsString()
        {
            var info = "";

            foreach(var item in _stack)
            {
                if (item == null)
                    return info;

                info += item.ToString() + " ";
            }

            return info;
        }
    }
}
