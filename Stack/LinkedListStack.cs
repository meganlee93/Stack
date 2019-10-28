using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class LinkedListStack<T>
    {
        public int Count => data.Count;
        private LinkedList<T> data;

        public LinkedListStack()
        {
            data = new LinkedList<T>();
            //Count = data.Count;
        }

        public void Push(T value)
        {
            data.AddFirst(value);
        }

        public T Pop()
        {
            T value = data.Last.Value;
            data.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            return data.First.Value;
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

    }
}
