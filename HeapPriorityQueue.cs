using System;

namespace HeapPriorityQueue
{
    /// <summary>
    /// Difines a generalized type-specific priority queue data structure which has
    /// methods: Add(), Clear(), IsEmpty(), Peek(), Remove(), and size().
    /// </summary>
    /// <typeparam name="T">This is type-safe generics version</typeparam>
    public interface IPriorityQueue<T>
    {
        void Add(T value);
        void Clear();
        bool IsEmpty();
        T Peek();
        T Remove();
        int size();
    }
    /// <summary>
    /// Defines a generalized type-specific Heap priority queue data structure 
    /// which implements interface IPriorityQueue<typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HeapPriorityQueue<T> : IPriorityQueue<T>
    {
        private T[] elements;
        private int size;
        //Constructs a new empty priority queque
        public HeapPriorityQueue()
        {
            elements = new T[10];
            size = 0;
        }

        public void Add(T value)
        {

        }

    }
}
