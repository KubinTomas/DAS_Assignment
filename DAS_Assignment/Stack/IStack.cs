using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    interface IStack
    {
        int Top { get; set; }

        void Push(int item);

        object Pop();

        bool IsFull();

        bool IsEmpty();

    }
}
