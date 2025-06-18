using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class QuickSort : Sorter
    {
        public override List<Order> Sort(List<Order> unsortedOrderList)
        {
            List<Order> sortedList = new List<Order>(unsortedOrderList);
            QuickSortRecursive(sortedList, 0, sortedList.Count - 1);
            return sortedList;
        }

        private void QuickSortRecursive(List<Order> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(list, low, high);
                QuickSortRecursive(list, low, pivotIndex - 1);
                QuickSortRecursive(list, pivotIndex + 1, high);
            }
        }

        private int Partition(List<Order> list, int low, int high)
        {
            Order pivot = list[low];
            int left = low + 1;
            int right = high;

            while (left <= right)
            {
                while (left <= right && list[left].ID.CompareTo(pivot.ID) <= 0)
                    left++;

                while (left <= right && list[right].ID.CompareTo(pivot.ID) > 0)
                    right--;

                if (left < right)
                    Swap(list, left, right);
            }

            Swap(list, low, right);
            return right;
        }

        private void Swap(List<Order> list, int i, int j)
        {
            Order temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}