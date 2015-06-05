using System;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Defines an interface to a priority queue.
    /// </summary>
    /// <typeparam name="TKey">Type of key - must implement IComparable.</typeparam>
    /// <typeparam name="TValue">Type of value to be saved in the priority queue.</typeparam>
    /// <author>René Sørensen</author>
    public interface IPriorityQueue<TKey, TValue> where TKey : IComparable
    {
        /// <summary>
        /// Returns the number of elements in the priority queue.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Insert an elements in the priority queue with a specific priority. 
        /// </summary>
        /// <param name="key">Key used to specify priority - must implemet IComparable</param>
        /// <param name="element">The element associated with the key.</param>
        void Insert(TKey key, TValue element);

        /// <summary>
        /// Removes the element from the priority queue having the higest priority.
        /// </summary>
        /// <returns>The element from the priority queue having the highest priority - default(TValue) if no elements exists</returns>
        TValue RemoveMax();
    }
}
