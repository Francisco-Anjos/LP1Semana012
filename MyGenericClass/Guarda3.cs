using System;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T[] items;

        public Guarda3()
        {
            items = new T[3];
        }

        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            return items[i];
        }
        
    }
}