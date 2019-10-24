using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
