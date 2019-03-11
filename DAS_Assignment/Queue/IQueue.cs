using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    interface IQueue
    {
        bool IsEmpty();
        bool IsFull();
        void Push(int? number);
        int? Pop();
    }
}
