
using System;
using System.Collections;
using System.Collections.Generic;

namespace ACM.BL.Order.Model
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem.Model.OrderItem>();
        }

        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public IList<OrderItem.Model.OrderItem> OrderItems { get; set; }

        public bool Validate() =>
            OrderDate != null;
    }
}
