using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    /// <summary>
    /// A class representing a node for a Binary Search Tree aimed at faciliating the search of Order objects
    /// by order id as descibed in Task 1
    /// This class requires no further addition/modification
    /// </summary>
    internal class TreeNode
    {
            public Order order { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(Order o) { this.order = o; this.Left = null; this.Right = null; }
        }
    }

