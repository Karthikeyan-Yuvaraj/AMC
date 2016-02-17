using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.BL
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay();

            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2016, 2, 14, 0, 0, 0, new TimeSpan(3));
                orderDisplay.Shipping = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.OrderDisplayitemsList = new List<OrderDisplayItems>();

            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItems()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayitemsList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItems()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayitemsList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2016, 2, 14, 0, 0, 0, new TimeSpan(3));
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
