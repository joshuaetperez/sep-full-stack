using System;
using System.Collections;

namespace ConsoleApp
{
    public class MyList<T>
    {
        private T[] list = new T[4];
        private int length = 0;

        public void Add(T element)
        {
            if (length == list.Length)
            {
                T[] newList = new T[list.Length * 2];
                for (int i = 0; i < length; i++)
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
            list[length] = element;
            length++;
        }

        public T Remove(int index)
        {
            if (index < 0 || index > length - 1)
            {
                return default(T);
            }

            T returnElement = list[index];
            for (int i = index; i < length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[length - 1] = default(T);
            length--;

            return returnElement;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < length; i++)
            {
                if (list[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            list = new T[4];
            length = 0;
        }

        public void InsertAt(T element, int index)
        {
            if (length == list.Length)
            {
                T[] newList = new T[list.Length * 2];
                for (int i = 0; i < index; i++)
                {
                    newList[i] = list[i];
                }
                for (int i = index; i < length; i++)
                {
                    newList[i + 1] = list[i];
                }
                list = newList;
            }
            else
            {
                for (int i = length; i > index; i--)
                {
                    list[i] = list[i - 1];
                }
            }
            list[index] = element;
            length++;
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index > length - 1)
            {
                return;
            }

            for (int i = index; i < length; i++)
            {
                list[i] = list[i + 1];
            }
            length--;
        }

        public T Find(int index)
        {
            if (index < 0 || index > length - 1)
            {
                return default(T);
            }
            return list[index];
        }

        //------------------
        // Extra helper functions

        public int Count()
        {
            return length;
        }

        public void PrintList()
        {
            for (int i = 0; i < length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(list[i]);
            }
            Console.WriteLine();
        }
    }
}
