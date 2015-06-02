using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LivingSmartBusinessLogic
{
    public class PriorityQueue<TKey, TValue> : IPriorityQueue<TKey, TValue> where TKey : IComparable
    {
        /// <summary>
        /// Returns the number of elements in the priority queue.
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        private const int InitialSize = 100;
        private KeyValuePair<TKey, TValue>[] heap;

        /// <summary>
        /// Creates an empty priority queue.
        /// </summary>
        public PriorityQueue() : this(InitialSize) { }

        /// <summary>
        /// Creates an empty priority queue with a specified initial capacity.
        /// </summary>
        /// <param name="initialSize">Initial capacity of the priority queue.</param>
        public PriorityQueue(int initialSize)
        {
            heap = new KeyValuePair<TKey, TValue>[initialSize];
            Count = 0;
        }

        /// <summary>
        /// Insert an elements in the priority queue with a specific priority. 
        /// </summary>
        /// <param name="key">Key used to specify priority - must implemet IComparable</param>
        /// <param name="element">The element associated with the key.</param>
        public void Insert(TKey key, TValue value)
        {
            if (Count >= heap.Length)
                Expand();

            int index = Count;
            heap[index] = new KeyValuePair<TKey, TValue>(key, value);

            while (index > 0 && heap[index].Key.CompareTo(heap[index / 2].Key) > 0)
            {
                KeyValuePair<TKey, TValue> temp = heap[index];
                heap[index] = heap[index / 2];
                heap[index / 2] = temp;

                index = index / 2;
            }

            Count++;
        }

        /// <summary>
        /// Removes the element from the priority queue having the higest priority.
        /// </summary>
        /// <returns>The element from the priority queue having the highest priority - default(TValue) if no elements exists.</returns>
        public TValue RemoveMax()
        {
            TValue maxElement = default(TValue);
            if (Count > 0)
            {
                maxElement = heap[0].Value;
                heap[0] = heap[heap.Length - 1];
                MaxHeapify(heap, 0);
                Count--;
            }
            return maxElement;
        }

        /// <summary>
        /// Doubles the capacity of the priority queue.
        /// </summary>
        private void Expand()
        {
            KeyValuePair<TKey, TValue>[] temp = new KeyValuePair<TKey, TValue>[2 * heap.Length];

            for (int i = 0; i < heap.Length; i++)
            {
                temp[i] = heap[i];
            }

            heap = temp;
        }

        /// <summary>
        /// Returns a string representation of the elements in the priority queue.
        /// </summary>
        /// <returns>a string representation of the elements in the priority queue.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{");
            for (int i = 0; i < Count; i++)
            {
                KeyValuePair<TKey, TValue> pair = heap[i];
                sb.Append(pair.Value.ToString());
                if (i < Count - 1)
                    sb.Append(",");
            }
            sb.Append("}");
            return sb.ToString();
        }

        /// <summary>
        /// Given a list of KeyValuePairs and an index, MaxHeapity restores the heap property. 
        /// </summary>
        /// <param name="heap"></param>
        /// <param name="index"></param>
        private void MaxHeapify(KeyValuePair<TKey, TValue>[] heap, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largestIndex = index;
            if (left <= heap.Length && heap[left].Key.CompareTo(heap[largestIndex].Key) > 0)
            {
                largestIndex = left;
            }
            if (right <= heap.Length && heap[right].Key.CompareTo(heap[largestIndex].Key) > 0)
            {
                largestIndex = right;
            }
            if (largestIndex != index)
            {
                KeyValuePair<TKey, TValue> temp = heap[index];
                heap[index] = heap[largestIndex];
                heap[largestIndex] = temp;
                MaxHeapify(heap, largestIndex);
            }
        }
    }
}
