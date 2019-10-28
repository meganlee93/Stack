using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListStack<int> linkedListStack = new LinkedListStack<int>();
            //for(int i = 0; i < 10; i++)
            //{
            //    linkedListStack.Push(i);

            //}

            //Console.WriteLine(linkedListStack.Count);
            //Console.WriteLine(linkedListStack.Peek());

            //linkedListStack.Pop();
            //Console.WriteLine(linkedListStack.Count);
            //Console.WriteLine(linkedListStack.Peek());
            //linkedListStack.Push(100);
            //Console.WriteLine(linkedListStack.Count);
            //Console.WriteLine(linkedListStack.Peek());

            Stack<int> myStack = new Stack<int>();
            for (int i = 0; i < 12; i++)
            {
                myStack.Push(i);
            }
            Console.WriteLine(myStack.Count);
            for(int i = 0; i < 10; i++)
            {
                myStack.Pop();
            }
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Count);
            myStack.Clear();
            Console.WriteLine(myStack.Count);
            myStack.Push(10);
            for(int i = 0; i < myStack.Count; i++)
            {
                Console.WriteLine(myStack.Peek());
            }
        }
    }
}
