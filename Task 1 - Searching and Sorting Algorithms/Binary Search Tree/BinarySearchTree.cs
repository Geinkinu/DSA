using System;
using System.Collections.Generic;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class BinarySearchTree
    {
        private class Node
        {
            public Order Data;
            public Node Left;
            public Node Right;

            public Node(Order data)
            {
                Data = data;
            }
        }

        private Node root;

        public void Build(List<Order> orders)
        {
            if (orders == null || orders.Count == 0)
                return;

            root = new Node(orders[0]);

            for (int i = 1; i < orders.Count; i++)
            {
                Insert(root, orders[i]);
            }
        }

        private void Insert(Node current, Order order)
        {
            if (order.ID.CompareTo(current.Data.ID) < 0)
            {
                if (current.Left == null)
                    current.Left = new Node(order);
                else
                    Insert(current.Left, order);
            }
            else
            {
                if (current.Right == null)
                    current.Right = new Node(order);
                else
                    Insert(current.Right, order);
            }
        }

        public Order Get(Guid orderID)
        {
            return SearchAndModify(root, orderID);
        }

        private Order SearchAndModify(Node node, Guid id)
        {
            if (node == null)
                return null;

            int cmp = id.CompareTo(node.Data.ID);
            if (cmp == 0)
            {
                return Order.GenerateModifiedCopy(id);
            }
            else if (cmp < 0)
            {
                return SearchAndModify(node.Left, id);
            }
            else
            {
                return SearchAndModify(node.Right, id);
            }
        }
    }
}
