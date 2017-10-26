using System;

namespace FunctionClass
{
    public class Stack<T>
    {
        private int size;
        private T[] stack;
        private int top;

        public Stack(int length)
        {
            size = length;
            stack = new T[size];

            //initialize top with -1
            top = -1;
        }


        public void Push(T Data)
        {
            //push if it's not full
            if (top < size)
            {
                // insert data into stack
                top = top + 1;
                stack[top] = Data;
            }
        }

        public void Pop()
        {
            T DataToPop;

            //pop if it's not empty 
            if (top >= 0)
            {
                DataToPop = stack[top];
                top = top - 1;
            }
        }

        public int Size()
        {
            if (top < -1)
                return -1;
            else if (top == -1)
                return 0;
            else
                return top + 1;
        }

        public bool isEmpty()
        {
            if (Size() == 0)
                return true;
            else
                return false;
        }

        public T[] GetAllStackDatas()
        {
            T[] Datas = new T[top + 1];

            Array.Copy(stack, 0, Datas, 0, top + 1);

            return Datas;
        }
    }
}
