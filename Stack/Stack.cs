using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T>
    {
        public int Count { get; private set; }
        int Head;
        T[] data;
        int index;
        int Size;

        public Stack(int capacity = 10)
        {
            Size = capacity;
            data = new T[Size];
            index = 0;
            Head = index;
        }

        public void Resize(int size)
        {
            T[] newData = new T[data.Length * size];
            for(int i = 0; i < Count; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }

        public void Push(T value)
        {
            if (index == data.Length)
            {
                Resize(2);
            }

            data[index] = value;
            Head = index;
            index++;
            Count++;
        }

        public T Pop()
        {
            //1 2 3 4 5
            if (Head > 0)
            {
                T value = data[Head];
                Head--;
                Count--;
                index--;
                return value;
            }

            else
            {
                throw new Exception("Can't pop from empty stack");
            }
        }

        public T Peek()
        {
            return data[Head];
        }

        public void Clear()
        {
            Count = 0;
            index = 0;
            data = new T[Size];
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
