using System;
using System.Collections.Generic;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class OrderManager
    {
        private List<Order> ordersPlaced;

        public OrderManager()
        {
            ordersPlaced = new List<Order>();
            for (int i = 0; i < 15; i++)
            {
                ordersPlaced.Add(Order.GenerateOrder());
            }
        }

        public Order GetOrderByID(string orderID)
        {
            Guid orderGuid = Guid.Parse(orderID);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Build(ordersPlaced);
            return bst.Get(orderGuid);
        }

        public List<Order> SortOrders(int choice)
        {
            Sorter sortingAlgorithm;
            switch (choice)
            {
                case 1: sortingAlgorithm = new QuickSort(); break;
                case 2: sortingAlgorithm = new MergeSort(); break;
                case 3: sortingAlgorithm = new CustomSort(); break;
                default: throw new InvalidOperationException("Invalid Sorting Method Chosen");
            }

            return sortingAlgorithm.Sort(ordersPlaced);
        }

        public List<Order> GetMosturgentOrders()
        {
            PriorityQueue queue = new PriorityQueue();
            return queue.GetMostUrgentOrders(this.ordersPlaced);
        }
    }
}
