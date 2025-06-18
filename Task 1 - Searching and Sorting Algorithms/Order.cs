using System;

namespace Task_1___Searching_and_Sorting_Algorithms
{
    internal class Order
    {
        public Guid ID { get; set; }
        public DateTime placedOn { get; set; }
        public DateTime deliverOn { get; set; }

        public static Order GenerateOrder()
        {
            Order order = new Order();
            order.ID = Guid.NewGuid();
            order.placedOn = DateTime.Now.AddDays(new Random().Next(-5, 0));
            order.deliverOn = DateTime.Now.AddDays(new Random().Next(0, 100));
            return order;
        }

        public static Order GenerateModifiedCopy(Guid id)
        {
            Order modified = new Order();
            modified.ID = id;
            modified.placedOn = DateTime.Now.AddDays(new Random().Next(-5, 0));
            modified.deliverOn = DateTime.Now.AddDays(new Random().Next(0, 100));
            return modified;
        }

        public override string ToString()
        {
            return $"Order ID : {this.ID}\tPlaced On : {this.placedOn}\tDeliver By : {this.deliverOn}\n";
        }
    }
}
