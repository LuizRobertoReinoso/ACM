using System;

namespace ACM.BL.Order.Repository
{
    public class OrderRepository
    {
        public Model.Order Retrieve(int orderId)
        {
            if (10.Equals(orderId))
                return new Model.Order(orderId)
                {
                    OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                        new TimeSpan(7, 0, 0))
                };
            return new Model.Order(orderId);
        }

        public bool Save()
        {

            return true;
        }
    }
}
