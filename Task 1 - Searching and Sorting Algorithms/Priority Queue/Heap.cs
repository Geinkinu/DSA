using System;
using System.Collections.Generic;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class Heap
    {
        private List<Order> heap;

        public Heap()
        {
            heap = new List<Order>();
        }

        public void Insert(Order order)
        {
            heap.Add(order);
            int i = heap.Count - 1;

            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (heap[i].deliverOn < heap[parent].deliverOn)
                {
                    Swap(i, parent);
                    i = parent;
                }
                else
                    break;
            }
        }

        public Order Remove()
        {
            if (heap.Count == 0)
                return null;

            Order root = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            int i = 0;
            while (true)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;
                int smallest = i;

                if (left < heap.Count && heap[left].deliverOn < heap[smallest].deliverOn)
                    smallest = left;

                if (right < heap.Count && heap[right].deliverOn < heap[smallest].deliverOn)
                    smallest = right;

                if (smallest == i)
                    break;

                Swap(i, smallest);
                i = smallest;
            }

            return root;
        }

        private void Swap(int i, int j)
        {
            Order temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public int Count()
        {
            return heap.Count;
        }
    }
}
