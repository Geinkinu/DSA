using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    /// <summary>
    /// Abstract class acting as parent class for all classes reflecting sorting algorithms
    /// This class requires no further modification
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class Sorter
    {
        /// <summary>
        /// Sorts the list of unsorted orders and returns a list with the same data sorted in the required way
        /// </summary>
        /// <param name="unsortedOrderList">the list of orders to be sorted</param> 
        /// <returns>T[] a list of orders which are sorted in the required order</returns>
        public abstract List<Order> Sort(List<Order> unsortedOrderList);
    }
}
