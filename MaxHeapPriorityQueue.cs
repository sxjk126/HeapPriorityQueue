using System;
using System.Collections.Generic;
using System.Text;

namespace HeapPriorityQueue
{
    public class MaxHeapPriorityQueue<T> : IPriorityQueue<T> where T : IComparable<T>
    {
        private List<T> elements;
        public MaxHeapPriorityQueue()
        {
            elements = new List<T>();
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < elements.Count; i++)
            {
                str += elements[i].ToString() + " ";
            }
            str += "count = " + elements.Count;
            return str;
        }
        private int Parent(int index)
        {
            if (index != 0)
            {
                return (index - 1) / 2;
            }
            else
            {
                throw new Exception("There is no parent.");
            }
        }

        //Return the index of the left child of the given index in the heap.
        private int LeftChild(int index)
        {
            return index * 2 + 1;
        }

        //Return the index of the right child of the given index in the heap.
        private int RightChild(int index)
        {
            return index * 2 + 2;
        }

        //Return true if the given index has a parent in the heap
        private bool HasParent(int index)
        {
            return index > 0;
        }

        //Return true if the given index has a left child in the heap
        private bool HasLeftChild(int index)
        {

            return LeftChild(index) < elements.Count;

        }

        //Return true if the given index has a right child in the heap
        private bool HasRightChild(int index)
        {
            return RightChild(index) < elements.Count;

        }

        //Swaps the elements at the two given indexes in the array.
        private void Swap(List<T> newList, int index1, int index2)
        {
            T temp = newList[index1];
            newList[index1] = newList[index2];
            newList[index2] = temp;
        }

        public void Add(T value)
        {
            //Bubble index
            int index = elements.Count;
            //Put value into last slot
            elements.Add(value);
            //"Bubble up" until in order again
            bool done = false;
            while (!done && HasParent(index))
            {
                int parentIndex = Parent(index);
                if (elements[parentIndex].CompareTo(elements[index]) < 0)
                {
                    Swap(elements, index, parentIndex);
                    index = parentIndex;
                }
                else
                {
                    done = true;
                }
            }
        }

        public void Clear()
        {
            elements.Clear();
        }
        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("This array is empty!");
            }
            else
            {
                T frontValue = elements[0];
                return frontValue;
            }
        }

        public T Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("This array is empty!");
            }
            else
            {
                T frontValue = elements[0];
                elements[0] = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);

                //Bubble down until order is restored
                bool done = false;
                int index = 0;
                while (!done && HasLeftChild(index))
                {
                    int left = LeftChild(index);
                    int kid = left;
                    if (HasRightChild(index))
                    {
                        int right = RightChild(index);
                        if (elements[right].CompareTo(elements[left]) > 0)
                        {
                            kid = right;
                        }
                    }
                    if (elements[index].CompareTo(elements[kid]) < 0)
                    {
                        Swap(elements, index, kid);
                        index = kid;
                    }
                    else
                    {
                        done = true;
                    }
                }
                return frontValue;
            }
        }
    }
}
