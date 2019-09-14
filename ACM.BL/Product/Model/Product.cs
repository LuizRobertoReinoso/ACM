
namespace ACM.BL.Product.Model
{
    public class Product : EntityBase.EntityBase
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
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public override bool Validate() =>  
            CurrentPrice != null && !string.IsNullOrWhiteSpace(ProductName);

        public override string ToString() => ProductName;
    }
}
