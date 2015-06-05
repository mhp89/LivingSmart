using System;
using System.Collections.Generic;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// Given a list of cases and estate agents, this class is responsible for distributing
    /// cases to estate agents based on a given priority.
    /// </summary>
    /// <author>René Sørensen</author>>
    public class OpenHouse
    {
        private readonly List<EstateAgent> brokers;
        private readonly List<KeyValuePair<decimal, Case>> keyCasePairs;
        private IPriorityQueue<decimal, Case> pq;
        private readonly Dictionary<EstateAgent, List<Case>> openHouse;

        /// <summary>
        /// Takes a list of brokers and a List of KeyValuesPairs of Decimals and Cases
        /// </summary>
        /// <param name="brokers"></param>
        /// <param name="keyCasePairs"></param>
        /// <author>René Sørensen</author>>
        public OpenHouse(List<EstateAgent> brokers, List<KeyValuePair<decimal, Case>> keyCasePairs)
        {
            this.keyCasePairs = keyCasePairs;
            this.brokers = brokers;
            openHouse = new Dictionary<EstateAgent, List<Case>>();

            pq = new PriorityQueue<decimal, Case>();
            foreach (var caseAskingPricePair in this.keyCasePairs)
            {
                pq.Insert(caseAskingPricePair.Key, caseAskingPricePair.Value);
            }
        }

        private void LoadPriorityQueue()
        {
            pq = new PriorityQueue<decimal, Case>();
            foreach (var caseAskingPricePair in keyCasePairs)
            {
                pq.Insert(caseAskingPricePair.Key, caseAskingPricePair.Value);
            }
        }

        /// <summary>
        /// Distributes Cases to EstateAgents based on the Key in given in the constructor.
        /// The key could be the price of the house 
        /// </summary>
        /// <returns>Returns a dictionary containing Broker as key and a list of Cases as value.</returns>
        /// <author>René Sørensen</author>>
        public Dictionary<EstateAgent, List<Case>> ReturnOpenHouseShuffle()
        {
            LoadPriorityQueue();

            if (brokers.Count > 0)
            {
                int brokerIndex = 0;

                while (pq.Count > 0)
                {
                    if (brokerIndex == 0)
                        Shuffle(brokers);

                    EstateAgent b = brokers[brokerIndex];
                    Case c = pq.RemoveMax();

                    if (!openHouse.ContainsKey(b))
                    {
                        openHouse.Add(b, new List<Case>());
                    }
                    openHouse[b].Add(c);

                    brokerIndex = (brokerIndex + 1) % brokers.Count;
                }
            }
            return openHouse;
        }

        /// <summary>
        /// Distributes Cases to EstateAgents based on the Key in given in the constructor.
        /// The key could be the price of the house 
        /// </summary>
        /// <returns>Returns a dictionary containing Broker as key and a list of Cases as value.</returns>
        /// <author>René Sørensen</author>>
        public Dictionary<EstateAgent, List<Case>> ReturnOpenHouseEvenly()
        {
            LoadPriorityQueue();

            if (brokers.Count > 0)
            {
                bool usingLeft = true;
                Stack<EstateAgent> left = new Stack<EstateAgent>();
                Stack<EstateAgent> right = new Stack<EstateAgent>();
                EstateAgent estateAgent;
                Case c;

                foreach (EstateAgent agent in brokers)
                {
                    left.Push(agent);
                }

                while (pq.Count > 0)
                {
                    while (pq.Count > 0 && left.Count > 0)
                    {
                        c = pq.RemoveMax();
                        estateAgent = left.Pop();
                        right.Push(estateAgent);
                        if (!openHouse.ContainsKey(estateAgent))
                        {
                            openHouse.Add(estateAgent, new List<Case>());
                        }
                        openHouse[estateAgent].Add(c);
                    }

                    while (pq.Count > 0 && right.Count > 0)
                    {
                        c = pq.RemoveMax();
                        estateAgent = right.Pop();
                        left.Push(estateAgent);
                        if (!openHouse.ContainsKey(estateAgent))
                        {
                            openHouse.Add(estateAgent, new List<Case>());
                        }
                        openHouse[estateAgent].Add(c);
                    }
                }
            }
            return openHouse;
        }

        /// <summary>
        /// Helper method - shuffles a list of values
        /// </summary>
        /// <typeparam name="T">Type of elements in the list.</typeparam>
        /// <param name="list">The list of elements to be shuffled.</param>
        /// <author>René Sørensen</author>>
        private void Shuffle<T>(List<T> list)
        {
            if (list.Count >= 2)
            {
                Random rand = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < 10 * list.Count; i++)
                {
                    int i1 = rand.Next(0, list.Count);
                    int i2 = rand.Next(0, list.Count);

                    if (i1 != i2)
                    {
                        T temp = list[i1];
                        list[i1] = list[i2];
                        list[i2] = temp;
                    }
                }
            }
        }
    }
}
