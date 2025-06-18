using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class MergeSort : Sorter
    {
        public override List<Order> Sort(List<Order> unsortedOrderList)
        {
            List<Order> copied = new List<Order>(unsortedOrderList);
            return MergeSortRecursive(copied);
        }

        private List<Order> MergeSortRecursive(List<Order> list)
        {
            if (list.Count <= 1)
                return list;

            int mid = list.Count / 2;
            List<Order> left = list.GetRange(0, mid);
            List<Order> right = list.GetRange(mid, list.Count - mid);

            return Merge(MergeSortRecursive(left), MergeSortRecursive(right));
        }

        private List<Order> Merge(List<Order> left, List<Order> right)
        {
            List<Order> result = new List<Order>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].placedOn >= right[j].placedOn)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
                result.Add(left[i++]);

            while (j < right.Count)
                result.Add(right[j++]);

            return result;
        }
    }
}
