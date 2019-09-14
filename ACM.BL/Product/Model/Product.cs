using System.Xml.Schema;

namespace ACM.BL.Product.Model
{
    public class Product
    {
        public Product()
        {
            
        }
        
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate() =>
            CurrentPrice != null && !string.IsNullOrWhiteSpace(ProductName);
    }
}
