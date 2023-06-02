using System;

namespace JustLikeACollection
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
        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            items[i] = item;
        }
        public void Add(T item)
        {
            for (int i = 0; i < 3; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], default(T)))
                {
                    items[i] = item;
                    return;
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}