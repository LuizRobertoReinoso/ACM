
namespace ACM.BL.OrderItem.Model
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public  int ProdutoId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate() =>
            Quantity > 0 && ProdutoId > 0 && PurchasePrice != null;
    }
}
