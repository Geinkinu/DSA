// The code in this class aims to help you test the data structures & algorithms implemented for Task 1
//It requires no further modification from your end.
using Task_1___Searching_and_Sorting_Algorithms;


#pragma warning disable CS7022 // The entry point of the program is global code; ignoring entry point
internal class Program
{
    private static void Main(string[] args)
    {
            OrderManager orderManager = new OrderManager();

            int choice = 0;

            do
            {
                //Console.Clear();
                Console.Write("Choose an Option: \n1.View Orders\n2.Search Orders\n3.View Most Urgent Orders\n4.Exit\nChoice :");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("\n\nSelect an Option:\n 1.View Orders sorted by ID\n2. View Orders sorted by Placed on Date\n3. Vew Orders sorted by Delivery Date\nChoice: ");
                            int sortChoice = Convert.ToInt32(Console.ReadLine());
                            List<Order> sortedOrders = orderManager.SortOrders(sortChoice);
                            Console.WriteLine("\n\n");
                            foreach (Order order in sortedOrders)
                            {
                                Console.WriteLine(order.ToString());
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Write("\n\nEnter Order ID : ");
                            string orderID = Console.ReadLine();
                            Order order = orderManager.GetOrderByID(orderID);
                            if (order != null)
                            {
                                Console.WriteLine(order.ToString());
                            }
                            else
                            {
                                Console.WriteLine($"No oOrder Found Matching ID : {orderID}");
                            }
                        }
                        break;
                    case 3:
                    {
                        Console.WriteLine("\n\nListing 5 most urgent orders");
                        List<Order> urgentOrders = orderManager.GetMosturgentOrders();
                        foreach (Order order in urgentOrders)
                        {
                            Console.WriteLine(order.ToString());
                        }
                    }break;
                case 4:
                    {
                        Console.WriteLine("\n\nExiting...");
                    }
                    break;
                    default:
                        Console.WriteLine("\n\nInvalid Option Selected. Press Any Key...");break;
                }
            } while (choice != 4);
        }
    }