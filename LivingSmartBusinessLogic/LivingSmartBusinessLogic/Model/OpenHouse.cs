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
        private List<EstateAgent> brokers;
        private List<KeyValuePair<decimal, Case>> caseAskingPricePairs;
        private IPriorityQueue<decimal, Case> pq;
        private Dictionary<EstateAgent, List<Case>> openHouse;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brokers"></param>
        /// <param name="cases"></param>
        public OpenHouse(List<EstateAgent> brokers, List<KeyValuePair<decimal, Case>> caseAskingPricePairs)
        {
            this.caseAskingPricePairs = caseAskingPricePairs;
            this.brokers = brokers;
            pq = new MyPriorityQueue<decimal, Case>();
            openHouse = new Dictionary<EstateAgent, List<Case>>();

            foreach (var caseAskingPricePair in this.caseAskingPricePairs)
            {
                pq.Insert(caseAskingPricePair.Key, caseAskingPricePair.Value);
            }
        }

        /// <summary>
        /// Given a list of brokers and a list of Cases, this method distributes the cases to the brokers
        /// evenly by price.
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
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
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
