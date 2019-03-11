using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProject
{
    public class Queue
    {

        private string[] _queue;

        private int _size;

        private int _start;
        private int _end;

        public Queue(int size)
        {
            this._size = size - 1;
            _queue = new string[size - 1];

            Init();
        }
        private void Init()
        {
            _start = 0;
            _end = 0;
        }

        public string Pop()
        {

            var element = _queue[_start];
            _queue[_start] = "";
            _start = (_start + 1) % _size;

            return element;
        }

        public void Push(string number)
        {
            _queue[_end] = number;
            _end = (_end + 1) % _size;
        }

        public bool IsFull()
        {
            return !((_end + 1) % _size != _start);
        }

        public bool IsEmpty()
        {
            return !(_start != _end);
        }

        public override string ToString()
        {
            return "|| Start || " + _start + "|| End || " + _end + "|| Numbers in queue || " + GetStackContentAsString();
        }
        private string GetStackContentAsString()
        {
            var info = "";
            for (int i = 0; i < _queue.Length; i++)
            {
                info += String.Format("[{0}]", _queue[i]);
            }

            return info;
        }
    }
}
