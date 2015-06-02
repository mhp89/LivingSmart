using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    /// <summary>
    /// Defines an interface to a priority queue.
    /// </summary>
    /// <typeparam name="TKey">Type of </typeparam>
    /// <typeparam name="TValue"></typeparam>
    public interface IPriorityQueue<TKey, TValue> where TKey : IComparable
    {
        /// <summary>
        /// Returns the number of elements in the priority queue.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Insert an elements in the priority queue with a specific priority. 
        /// </summary>
        /// <param name="key">Key used to specify priority - must implemets IComparable</param>
        /// <param name="element">The element associated with the key.</param>
        void Insert(TKey key, TValue element);

        TValue RemoveMax();
    }
}
