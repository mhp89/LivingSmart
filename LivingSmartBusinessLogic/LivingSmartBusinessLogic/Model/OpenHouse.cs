using System;
using System.Collections.Generic;
using LivingSmartBusinessLogic;

namespace LivingSmartBusinessLogic.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OpenHouse
    {
        private readonly List<EstateAgent> brokers;
        private readonly List<KeyValuePair<decimal, Case>> keyCasePair;
        private readonly IPriorityQueue<decimal, Case> pq;
        private readonly Dictionary<EstateAgent, List<Case>> openHouse;

        /// <summary>
        /// Takes a list of brokers and a List of KeyValuesPairs of Decimals and Cases
        /// </summary>
        /// <param name="brokers"></param>
        /// <param name="keyCasePair"></param>
        public OpenHouse(List<EstateAgent> brokers, List<KeyValuePair<decimal, Case>> keyCasePair)
        {
            this.keyCasePair = keyCasePair;
            this.brokers = brokers;
            pq = new PriorityQueue<decimal, Case>();
            openHouse = new Dictionary<EstateAgent, List<Case>>();

            foreach (var caseAskingPricePair in this.keyCasePair)
            {
                pq.Insert(caseAskingPricePair.Key, caseAskingPricePair.Value);
            }
        }

        /// <summary>
        /// Distributes Cases to EstateAgents based on the Key in given in the constructor.
        /// The key could be the price of the house 
        /// </summary>
        /// <returns>Returns a dictionary containing Broker as key and a list of Cases as value.</returns>
        public Dictionary<EstateAgent, List<Case>> ReturnOpenHouse()
        {
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
        /// Helper method - shuffles a list of values
        /// </summary>
        /// <typeparam name="T">Type of elements in the list.</typeparam>
        /// <param name="list">The list of elements to be shuffled.</param>
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
