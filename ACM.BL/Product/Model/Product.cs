using Acme.Common;

namespace ACM.BL.Product.Model
{
    public class Product : EntityBase.EntityBase, ILoggable
    {
        public Product()
        {
            
        }
        
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;

        public string ProductName
        {
            get => _productName.InsertSpaces();
            set => _productName = value;
        }

        public override bool Validate() =>  
            CurrentPrice != null && !string.IsNullOrWhiteSpace(ProductName);

        public override string ToString() => ProductName;

        public string Log() =>
            $"{ProductId}: {ProductName} Detal: {ProductDescription} Status: {EntityState.ToString()}";
    }
}
