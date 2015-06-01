using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    public interface IPriorityQueue<TKey, TValue>
    {
        int Count { get; }
        void Insert(TKey key, TValue element);

        TValue RemoveMax();
    }
}
