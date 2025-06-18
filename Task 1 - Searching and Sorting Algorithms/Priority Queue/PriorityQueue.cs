using System.Collections.Generic;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class PriorityQueue
    {
        private Heap heap;

        public void Build(List<Order> orders)
        {
            heap = new Heap();
            foreach (Order order in orders)
            {
                heap.Insert(order);
            }
        }

        public List<Order> GetMostUrgentOrders(List<Order> orders)
        {
            Build(orders);

            List<Order> urgent = new List<Order>();
            for (int i = 0; i < 5 && heap.Count() > 0; i++)
            {
                urgent.Add(heap.Remove());
            }

            return urgent;
        }
    }
}
